using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileHasher.org.Service
{
    public static class TreeHelper
    {
        /// <summary>
        /// Начинает создание дерева каталогов и файлов
        /// </summary>
        public static void PopulateTreeView(TreeView tv, string rootPath)
        {
            tv.Nodes.Clear();
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(rootPath);
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                rootNode.Checked = true;
                GetFiles(info, rootNode);
                GetDirectories(info.GetDirectories(), rootNode);
                tv.Nodes.Add(rootNode);
            }
        }

        /// <summary>
        /// Создаёт под катологи и файлы
        /// </summary>
        /// <param name="subDirs">Список дирректорий</param>
        /// <param name="nodeToAddTo">Корневой каталог для текущиго списка каталогов</param>
        private static void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 1);
                aNode.Checked = true;
                aNode.Tag = subDir;
                subSubDirs = subDir.GetDirectories();
                GetFiles(subDir, aNode);
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        /// <summary>
        /// Создаёт дерево файлов
        /// </summary>
        /// <param name="root">Корневой каталог</param>
        /// <param name="nodeToAddTo">Корневой узел</param>
        private static void GetFiles(DirectoryInfo root, TreeNode nodeToAddTo)
        {
            foreach (FileInfo fi in root.GetFiles())
            {
                TreeNode fnode = new TreeNode(fi.Name, 2, 2);
                fnode.Checked = true;
                fnode.Tag = fi;
                nodeToAddTo.Nodes.Add(fnode);
            }
        }
    }
}
