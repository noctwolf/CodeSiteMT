using EnvDTE;
using EnvDTE80;
using Raize.CodeSiteLogging;
using System;
using System.Windows.Forms;
using VSLangProj;

namespace CodeSiteMT
{
    public partial class MethodTracerForm : Form
    {
        const string csName = "Raize.CodeSiteLogging";
        DTE dte;
        CodeImport ciCodeSiteLogging;

        FileCodeModel CodeModel => dte.ActiveDocument.ProjectItem.FileCodeModel;

        public MethodTracerForm()
        {
            InitializeComponent();
        }

        public static DialogResult Execute(DTE value)
        {
            bool CheckCodeModel()
            {
                try
                {
                    Document doc = value.ActiveDocument;
                    if (doc == null)
                    {
                        MessageBox.Show("没有活动文档", "加载文档", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return false;
                    }
                    FileCodeModel fcm = doc.ProjectItem.FileCodeModel;
                    if (fcm == null)
                        MessageBox.Show("活动文档没有代码模型", "加载文档", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    else if (!fcm.Language.Equals(CodeModelLanguageConstants.vsCMLanguageCSharp))
                        MessageBox.Show("代码的编程语言不是C#语言", "加载文档", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    else
                        return true;
                    return false;
                }
                catch (Exception ex)
                {
                    CodeSite.SendException("CheckCodeModel", ex);
                    MessageBox.Show("未知异常\r\n" + ex.Message, "加载文档", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
            }
            if (!CheckCodeModel()) return DialogResult.Abort;
            return new MethodTracerForm() { dte = value }.ShowDialog();
        }

        private void AddReference()
        {
            Project prj = dte.ActiveDocument.ProjectItem.ContainingProject;
            if (prj.Kind == PrjKind.prjKindCSharpProject)
            {
                VSProject vsp = (VSProject)prj.Object;
                Reference refe = vsp.References.Find(csName);
                if (refe == null) vsp.References.Add(csName);
                prj.InstallPackage("Vikings.CodeSite.Extensions");
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            dte.UndoContext.Open("CodeSite方法追踪");
            try
            {
                ImportCodeSite();
                SetCodeSite();
                Properties.Settings.Default.Save();
            }
            finally
            {
                dte.UndoContext.Close();
            }
        }

        private void SetCodeSite(TreeNode treeNode = null)
        {
            TreeNode tn = null;
            if (treeNode != null) tn = treeNode.FirstNode;
            else if (tvMain.Nodes.Count > 0) tn = tvMain.Nodes[0];
            while (tn != null)
            {
                if (tn.ImageKey == vsCMElement.vsCMElementFunction.ToString())
                {
                    CodeFunction cf = tn.Tag as CodeFunction;
                    if (tn.Checked)
                        cf.AddCodeSite();
                    else
                        cf.DeleteCodeSite();
                }
                else
                    SetCodeSite(tn);
                tn = tn.NextNode;
            }
        }

        private void MethodTracerForm_Load(object sender, EventArgs e)
        {
            try
            {
                tvMain.Nodes.Clear();
                foreach (CodeElement item in CodeModel.CodeElements) RecurseElements(item, tvMain.Nodes);
                panelTreeBtn.Enabled = tvMain.Nodes.Count > 0;
                panelFind.Enabled = panelTreeBtn.Enabled;
                if (panelTreeBtn.Enabled)
                {
                    tvMain.Sort();
                    tvMain.ExpandAll();
                    tvMain.TopNode = tvMain.Nodes[0];
                }
                //throw new Exception("测试");
            }
            catch (Exception exc)
            {
                MessageBox.Show("异常" + exc.Message);
                CodeSite.SendException("MethodTracerForm_Load", exc);
            }
        }

        private void RecurseElements(CodeElement elt, TreeNodeCollection ns)
        {
            TreeNode tn = null;
            void TreeNodeAdd() { tn = ns.Add(elt.FullName, elt.Name, elt.Kind.ToString(), elt.Kind.ToString()); }
            if (elt.Kind == vsCMElement.vsCMElementImportStmt)
            {
                CodeImport ci = (CodeImport)elt;
                if (ci.Namespace == csName) ciCodeSiteLogging = ci;
            }
            else if ((elt.Kind == vsCMElement.vsCMElementNamespace))
            {
                TreeNodeAdd();
                CodeNamespace cn = (CodeNamespace)elt;
                foreach (CodeElement item in cn.Members) RecurseElements(item, tn.Nodes);
            }
            else if (elt.Kind == vsCMElement.vsCMElementClass || elt.Kind == vsCMElement.vsCMElementStruct)
            {
                TreeNodeAdd();
                CodeType ct = (CodeType)elt;
                foreach (CodeElement item in ct.Members) RecurseElements(item, tn.Nodes);
            }
            else if (elt.Kind == vsCMElement.vsCMElementProperty)
            {
                TreeNodeAdd();
                CodeProperty cp = (CodeProperty)elt;
                if (cp.Getter != null) RecurseElements((CodeElement)cp.Getter, tn.Nodes);
                if (cp.Setter != null) RecurseElements((CodeElement)cp.Setter, tn.Nodes);
            }
            else if (elt.Kind == vsCMElement.vsCMElementFunction)
            {
                CodeFunction cf = (CodeFunction)elt;
                try
                {
                    if (cf.MustImplement || !(cf.HasBody() || cf.HasExpressionBody())) return;//跳过抽象方法和没有主体的方法
                    tn = ns.Add(elt.FullName, cf.GetSetName() ?? elt.Name, elt.Kind.ToString(), elt.Kind.ToString());
                    tn.Tag = cf;
                    tn.Checked = cf.ExistsCodeSite();
                    tn.SetParent();
                }
                catch (Exception ex)
                {
                    CodeSite.SendException("elt.Name", ex);
                }
            }

            //移除没有方法的节点
            if (tn != null && tn.Nodes.Count == 0 && elt.Kind != vsCMElement.vsCMElementFunction) tn.Remove();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.Unknown) return;
            //遍历子节点
            e.Node.SetChild();
            //遍历父节点
            e.Node.SetParent();
        }

        private void TraceAll(bool check)
        {
            TreeNode tn = tvMain.Nodes[0];
            while (tn != null)
            {
                tn.Checked = check;
                tn.SetChild();
                tn = tn.NextNode;
            }
        }

        private void buttonTraceAll_Click(object sender, EventArgs e) => TraceAll(true);

        private void buttonUnTraceAll_Click(object sender, EventArgs e) => TraceAll(false);

        private void ImportCodeSite()
        {
            AddReference();
            if (ciCodeSiteLogging == null)
            {
                FileCodeModel2 fcm2 = (FileCodeModel2)CodeModel;
                ciCodeSiteLogging = fcm2.AddImport(csName, 0, null);
            }
        }

        private void buttonExpandAll_Click(object sender, EventArgs e)
        {
            this.tvMain.ExpandAll();
        }

        private void buttonCollapseAll_Click(object sender, EventArgs e)
        {
            this.tvMain.CollapseAll();
        }

        private void tbFind_TextChanged(object sender, EventArgs e)
        {
            TreeNode node = tvMain.Nodes[0].Find(tbFind.Text, true, true);
            if (node != null) tvMain.SelectedNode = node;
        }

        private void tvMain_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            TreeNode node = tvMain.SelectedNode ?? tvMain.Nodes[0];
            node = node.Find(tbFind.Text, bool.Parse((string)(sender as Control).Tag));
            if (node != null) tvMain.SelectedNode = node;
        }

        private void tvMain_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.ImageKey == vsCMElement.vsCMElementFunction.ToString())
            {
                CodeFunction cf = e.Node.Tag as CodeFunction;
                TextSelection ts = dte.ActiveDocument.Selection as TextSelection;
                ts.MoveToPoint(cf.StartPoint);
            }
        }
    }
}
