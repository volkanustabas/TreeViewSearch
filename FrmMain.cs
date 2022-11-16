using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace TreeViewSearch
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            tv_main.Nodes.Clear();
            ListDirectory(tv_main, @"\\PATH");
        }

        private void ListDirectory(TreeView tv, string path)
        {
            var rootDirectoryInfo = new DirectoryInfo(path);
            tv_main.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }

        private bool SearchRecursive(IEnumerable nodes, string searchFor)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text.ToUpper().Contains(searchFor))
                {
                    tv_main.SelectedNode = node;
                    return true;
                }

                if (SearchRecursive(node.Nodes, searchFor))
                    return true;
            }

            return false;
        }

        private void SearchCommand()
        {
            var searchFor = tb_search.Text.Trim().ToUpper();
            if (searchFor != "")
                if (tv_main.Nodes.Count > 0)
                    if (SearchRecursive(tv_main.Nodes, searchFor))
                    {
                        tv_main.SelectedNode.Expand();
                        tv_main.Focus();
                    }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchCommand();
        }


        private void tb_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchCommand();
        }
    }
}