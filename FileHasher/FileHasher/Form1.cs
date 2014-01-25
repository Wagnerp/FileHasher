using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using FileHasher.org.model;
using FileHasher.org.Service;

namespace FileHasher
{
    public partial class mainF : Form
    {
        string log = null;
        BackgroundWorker bgworker = new BackgroundWorker();
        Stopwatch sw = new Stopwatch();
        Timer tm = new Timer();

        public mainF()
        {
            InitializeComponent();
        }

        private void mainF_Load(object sender, EventArgs e)
        {
            bgworker.WorkerReportsProgress = true;
            bgworker.WorkerSupportsCancellation = true;
            bgworker.DoWork += new DoWorkEventHandler(bgworker_DoWork);
            bgworker.ProgressChanged += new ProgressChangedEventHandler(bgworker_ProgressChanged);
            bgworker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgworker_RunWorkerCompleted);
            tm.Tick += new EventHandler(tickTak);
            tm.Interval = 100;
        }

        private void tickTak(object sender, EventArgs e)
        {
            TimeSpan ts = sw.Elapsed;
            string outTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            infoout.Text = log + "Прошло времени: " + outTime;
        }

        private void bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;            
            HashHelper.MakeHash(treeView1, tb_savePath.Text);            
        }

        private void bgworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //
        }

        private void bgworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                infoout.Text = log + "Ошибка. :)\n";
            }
            else if (e.Cancelled)
            {
                infoout.Text = log + "Операция отменена\n";
            }
            else
            {
                TimeSpan ts = sw.Elapsed;
                string outTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                sw.Stop();
                tm.Stop();
                log += "Хеш с генерирован\n";                
                log += "Времени затрачено: " + outTime + "\n";
                infoout.Text = log;
                
            }
        }

        private void but_rootDir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                tb_rootPath.Text = folderDlg.SelectedPath;
                TreeHelper.PopulateTreeView(treeView1, tb_rootPath.Text);
                infoout.Clear();
                infoout.AppendText("Загружено файлов и папок: " + treeView1.GetNodeCount(true) + "\n");
                log = infoout.Text;
            }
        }

        private void but_saveHash_Click(object sender, EventArgs e)
        {
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                tb_savePath.Text = folderDlg.SelectedPath;
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            if (newSelected.Tag is FileInfo)
            {
                FileInfo fi = (FileInfo)newSelected.Tag;
                infoout.Text =  log + fi.FullName;
            }
            else
            {
                DirectoryInfo di = (DirectoryInfo)newSelected.Tag;
                infoout.Text = log + di.FullName;
            }
        }

        private void but_makeHash_Click(object sender, EventArgs e)
        {            
            infoout.Text = log + "Начат процесс генерации хеша, ожидайте.\n";                      
            log = infoout.Text;
            sw.Start();
            tm.Start();
            bgworker.RunWorkerAsync();
        }

        private void deleteTreeNode_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
            catch
            {

            }
        }
    }
}
