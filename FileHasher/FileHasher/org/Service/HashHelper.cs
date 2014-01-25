using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FileHasher.org.model;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.ComponentModel;

namespace FileHasher.org.Service
{
    public static class HashHelper
    {
        private static string Root { get; set; }

        /// <summary>
        /// Создаёт хэш всех файлов и папок, указанных в списке отображения
        /// </summary>
        /// <param name="tv">Список отображения</param>
        /// <param name="savePath">Путь сохранения хеша</param>
        /// <param name="txtFormat">формат вывода данных</param>
        /// <param name="outPutType">Тип выходного формата</param>
        public static void MakeHash(TreeView tv, string savePath, string txtFormat, int outPutType)
        {
            HashTable ht = new HashTable();
            TreeNode rootNode = tv.Nodes[0];
            DirectoryInfo rdi = rootNode.Tag as DirectoryInfo;
            List<PathAndMD5> hash = new List<PathAndMD5>();
            MakeFile(rootNode, hash, null);
            MakeDir(rootNode, hash, null);

            ht.FilePathAndHash = hash;

            // save all hash
            if (outPutType == 1)
                IOHelper.SaveHashTableAsXml(ht, savePath);
            else
                IOHelper.SaveHashTableAsTxt(ht, savePath, txtFormat);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="ht"></param>
        private static void MakeDir(TreeNode root, List<PathAndMD5> hash, string folder)
        {
            foreach (TreeNode subNode in root.Nodes)
            {
                if (subNode.Tag is DirectoryInfo && subNode.Checked)
                {
                    DirectoryInfo subDir = subNode.Tag as DirectoryInfo;

                    if (subDir.GetFiles().Length != 0)
                    {
                        MakeFile(subNode, hash, folder == null ? subDir.Name : folder + @"\" + subDir.Name);
                    }
                    if (subNode.Nodes.Count > 0)
                    {
                        MakeDir(subNode, hash, folder == null ? subDir.Name : folder + @"\" + subDir.Name);
                    }
                    Application.DoEvents();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="rootDir"></param>
        /// <param name="hash"></param>
        private static void MakeFile(TreeNode root, List<PathAndMD5> hash, string folder)
        {
            FileStream fs;
            foreach (TreeNode subN in root.Nodes)
            {
                if (subN.Tag is FileInfo && subN.Checked)
                {
                    FileInfo fi = subN.Tag as FileInfo;
                    fs = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read);
                    hash.Add(new PathAndMD5(folder == null ? fi.Name : folder + @"\" + fi.Name, BitConverter.ToString(MD5.Create().ComputeHash(fs)).Replace("-", "")));
                }
            }
        }
    }
}
