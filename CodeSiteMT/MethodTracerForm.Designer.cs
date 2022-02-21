namespace CodeSiteMT
{
    partial class MethodTracerForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MethodTracerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTree = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.imageListTreeView = new System.Windows.Forms.ImageList(this.components);
            this.panelTreeBtn = new System.Windows.Forms.Panel();
            this.buttonCollapseAll = new System.Windows.Forms.Button();
            this.buttonExpandAll = new System.Windows.Forms.Button();
            this.buttonUnTraceAll = new System.Windows.Forms.Button();
            this.buttonTraceAll = new System.Windows.Forms.Button();
            this.panelOption = new System.Windows.Forms.Panel();
            this.cbIncludeCatch = new System.Windows.Forms.CheckBox();
            this.panelFind = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnFindPrev = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTree.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelTreeBtn.SuspendLayout();
            this.panelOption.SuspendLayout();
            this.panelFind.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(464, 45);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ImageKey = "(无)";
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CodeSite Method Tracer 能够在当前单元的方法内快速简单的增加/删除 CodeSite EnterMethod 和 ExitMethod 代码" +
    "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelTree);
            this.panel2.Controls.Add(this.panelOption);
            this.panel2.Controls.Add(this.panelFind);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 388);
            this.panel2.TabIndex = 2;
            // 
            // panelTree
            // 
            this.panelTree.Controls.Add(this.panel6);
            this.panelTree.Controls.Add(this.panelTreeBtn);
            this.panelTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTree.Location = new System.Drawing.Point(0, 32);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(464, 324);
            this.panelTree.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tvMain);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(8);
            this.panel6.Size = new System.Drawing.Size(353, 324);
            this.panel6.TabIndex = 1;
            // 
            // tvMain
            // 
            this.tvMain.CheckBoxes = true;
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.tvMain.HideSelection = false;
            this.tvMain.ImageKey = "Picture Less Brightness.bmp";
            this.tvMain.ImageList = this.imageListTreeView;
            this.tvMain.Location = new System.Drawing.Point(8, 8);
            this.tvMain.Name = "tvMain";
            this.tvMain.SelectedImageKey = "Picture Less Brightness.bmp";
            this.tvMain.Size = new System.Drawing.Size(337, 308);
            this.tvMain.TabIndex = 0;
            this.tvMain.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.tvMain.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.tvMain_DrawNode);
            this.tvMain.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMain_NodeMouseDoubleClick);
            // 
            // imageListTreeView
            // 
            this.imageListTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTreeView.ImageStream")));
            this.imageListTreeView.TransparentColor = System.Drawing.Color.Fuchsia;
            this.imageListTreeView.Images.SetKeyName(0, "vsCMElementOther");
            this.imageListTreeView.Images.SetKeyName(1, "vsCMElementClass");
            this.imageListTreeView.Images.SetKeyName(2, "vsCMElementFunction");
            this.imageListTreeView.Images.SetKeyName(3, "vsCMElementVariable");
            this.imageListTreeView.Images.SetKeyName(4, "vsCMElementProperty");
            this.imageListTreeView.Images.SetKeyName(5, "vsCMElementNamespace");
            this.imageListTreeView.Images.SetKeyName(6, "vsCMElementParameter");
            this.imageListTreeView.Images.SetKeyName(7, "vsCMElementAttribute");
            this.imageListTreeView.Images.SetKeyName(8, "vsCMElementInterface");
            this.imageListTreeView.Images.SetKeyName(9, "vsCMElementDelegate");
            this.imageListTreeView.Images.SetKeyName(10, "vsCMElementEnum");
            this.imageListTreeView.Images.SetKeyName(11, "vsCMElementStruct");
            // 
            // panelTreeBtn
            // 
            this.panelTreeBtn.Controls.Add(this.buttonCollapseAll);
            this.panelTreeBtn.Controls.Add(this.buttonExpandAll);
            this.panelTreeBtn.Controls.Add(this.buttonUnTraceAll);
            this.panelTreeBtn.Controls.Add(this.buttonTraceAll);
            this.panelTreeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTreeBtn.Enabled = false;
            this.panelTreeBtn.Location = new System.Drawing.Point(353, 0);
            this.panelTreeBtn.Name = "panelTreeBtn";
            this.panelTreeBtn.Padding = new System.Windows.Forms.Padding(11);
            this.panelTreeBtn.Size = new System.Drawing.Size(111, 324);
            this.panelTreeBtn.TabIndex = 2;
            // 
            // buttonCollapseAll
            // 
            this.buttonCollapseAll.Location = new System.Drawing.Point(5, 104);
            this.buttonCollapseAll.Name = "buttonCollapseAll";
            this.buttonCollapseAll.Size = new System.Drawing.Size(100, 23);
            this.buttonCollapseAll.TabIndex = 3;
            this.buttonCollapseAll.Text = "全部折叠";
            this.buttonCollapseAll.UseVisualStyleBackColor = true;
            this.buttonCollapseAll.Click += new System.EventHandler(this.buttonCollapseAll_Click);
            // 
            // buttonExpandAll
            // 
            this.buttonExpandAll.Location = new System.Drawing.Point(5, 75);
            this.buttonExpandAll.Name = "buttonExpandAll";
            this.buttonExpandAll.Size = new System.Drawing.Size(100, 23);
            this.buttonExpandAll.TabIndex = 2;
            this.buttonExpandAll.Text = "全部展开";
            this.buttonExpandAll.UseVisualStyleBackColor = true;
            this.buttonExpandAll.Click += new System.EventHandler(this.buttonExpandAll_Click);
            // 
            // buttonUnTraceAll
            // 
            this.buttonUnTraceAll.Location = new System.Drawing.Point(5, 37);
            this.buttonUnTraceAll.Name = "buttonUnTraceAll";
            this.buttonUnTraceAll.Size = new System.Drawing.Size(100, 23);
            this.buttonUnTraceAll.TabIndex = 1;
            this.buttonUnTraceAll.Text = "全部不跟踪";
            this.buttonUnTraceAll.UseVisualStyleBackColor = true;
            this.buttonUnTraceAll.Click += new System.EventHandler(this.buttonUnTraceAll_Click);
            // 
            // buttonTraceAll
            // 
            this.buttonTraceAll.Location = new System.Drawing.Point(5, 8);
            this.buttonTraceAll.Name = "buttonTraceAll";
            this.buttonTraceAll.Size = new System.Drawing.Size(100, 23);
            this.buttonTraceAll.TabIndex = 0;
            this.buttonTraceAll.Text = "全部跟踪";
            this.buttonTraceAll.UseVisualStyleBackColor = true;
            this.buttonTraceAll.Click += new System.EventHandler(this.buttonTraceAll_Click);
            // 
            // panelOption
            // 
            this.panelOption.Controls.Add(this.cbIncludeCatch);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOption.Location = new System.Drawing.Point(0, 356);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(464, 32);
            this.panelOption.TabIndex = 2;
            // 
            // cbIncludeCatch
            // 
            this.cbIncludeCatch.AutoSize = true;
            this.cbIncludeCatch.Checked = global::CodeSiteMT.Properties.Settings.Default.IncludeCatch;
            this.cbIncludeCatch.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CodeSiteMT.Properties.Settings.Default, "IncludeCatch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbIncludeCatch.Location = new System.Drawing.Point(8, 8);
            this.cbIncludeCatch.Name = "cbIncludeCatch";
            this.cbIncludeCatch.Size = new System.Drawing.Size(78, 16);
            this.cbIncludeCatch.TabIndex = 4;
            this.cbIncludeCatch.Text = "包含catch";
            this.cbIncludeCatch.UseVisualStyleBackColor = true;
            // 
            // panelFind
            // 
            this.panelFind.Controls.Add(this.panel9);
            this.panelFind.Controls.Add(this.panel8);
            this.panelFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFind.Location = new System.Drawing.Point(0, 0);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(464, 32);
            this.panelFind.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.tbFind);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(8);
            this.panel9.Size = new System.Drawing.Size(353, 32);
            this.panel9.TabIndex = 0;
            // 
            // tbFind
            // 
            this.tbFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFind.Location = new System.Drawing.Point(8, 8);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(337, 21);
            this.tbFind.TabIndex = 0;
            this.tbFind.TextChanged += new System.EventHandler(this.tbFind_TextChanged);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnFindPrev);
            this.panel8.Controls.Add(this.btnFindNext);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(353, 0);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(11);
            this.panel8.Size = new System.Drawing.Size(111, 32);
            this.panel8.TabIndex = 1;
            // 
            // btnFindPrev
            // 
            this.btnFindPrev.Location = new System.Drawing.Point(5, 6);
            this.btnFindPrev.Name = "btnFindPrev";
            this.btnFindPrev.Size = new System.Drawing.Size(49, 23);
            this.btnFindPrev.TabIndex = 0;
            this.btnFindPrev.Tag = "false";
            this.btnFindPrev.Text = "上一个";
            this.btnFindPrev.UseVisualStyleBackColor = true;
            this.btnFindPrev.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(56, 6);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(49, 23);
            this.btnFindNext.TabIndex = 1;
            this.btnFindNext.Tag = "true";
            this.btnFindNext.Text = "下一个";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonOk);
            this.panel3.Controls.Add(this.buttonCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 35);
            this.panel3.TabIndex = 3;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(302, 6);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(383, 6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // MethodTracerForm
            // 
            this.AcceptButton = this.buttonOk;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(464, 468);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MethodTracerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CodeSite Method Tracer for .NET";
            this.Load += new System.EventHandler(this.MethodTracerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTree.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelTreeBtn.ResumeLayout(false);
            this.panelOption.ResumeLayout(false);
            this.panelOption.PerformLayout();
            this.panelFind.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Panel panelTree;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelTreeBtn;
        private System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.ImageList imageListTreeView;
        private System.Windows.Forms.Button buttonCollapseAll;
        private System.Windows.Forms.Button buttonExpandAll;
        private System.Windows.Forms.Button buttonUnTraceAll;
        private System.Windows.Forms.Button buttonTraceAll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbIncludeCatch;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnFindPrev;

    }
}