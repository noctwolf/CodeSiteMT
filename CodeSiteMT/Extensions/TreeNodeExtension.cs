using EnvDTE;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CodeSiteMT
{
    public static class TreeNodeExtension
    {
        public static void SetChild(this TreeNode treeNode)
        {
            var tn = treeNode.FirstNode;
            while (tn != null)
            {
                tn.Checked = treeNode.Checked;
                tn.SetChild();
                tn = tn.NextNode;
            }
        }

        public static void SetParent(this TreeNode value)
        {
            value = value.Parent;
            if (value != null)
            {
                TreeNode tn = value.FirstNode;
                bool check = false;
                while (tn != null)
                {
                    if (!(check = tn.Checked)) break;
                    tn = tn.NextNode;
                }
                value.Checked = check;
                value.SetParent();
            }
        }

        public static TreeNode Find(this TreeNode value, string text, bool next = false, bool best = false)
        {
            List<TreeNode> tnList = new List<TreeNode>();
            TreeNode node = value;
            do
            {
                node = next ? node.NextVisibleNode : node.PrevVisibleNode;
                if (node == null)
                    if (next)
                        node = value.TreeView.Nodes[0];
                    else
                    {
                        node = value.TreeView.Nodes[value.TreeView.Nodes.Count - 1];
                        while (node.NextVisibleNode != null) node = node.NextVisibleNode;
                    }
                if (node.ImageKey == vsCMElement.vsCMElementFunction.ToString()) tnList.Add(node);
            }
            while (node != value);
            tnList.RemoveAt(tnList.Count - 1);
            text = text.ToLower();
            if (best)
                return tnList.FirstOrDefault(f => f.Text.ToLower().Equals(text)) ??
                    tnList.FirstOrDefault(f => f.Text.ToLower().StartsWith(text)) ??
                    tnList.FirstOrDefault(f => f.Text.ToLower().Contains(text));
            else
                return tnList.FirstOrDefault(f => f.Text.ToLower().Contains(text));
        }
    }
}
