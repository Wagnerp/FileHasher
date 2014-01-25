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
        BackgroundWorker bgworker = new BackgroundWorker();
        Stopwatch sw = new Stopwatch();
        Timer tm = new Timer();
        int type = 1;

        public mainF()
        {
            InitializeComponent();
            cb_output_format.SelectedIndex = 1;
            cb_output_format.SelectedIndexChanged += new EventHandler(FormatChanged);
        }

        private void FormatChanged(object sender, EventArgs e)
        {
            switch (cb_output_format.SelectedIndex)
            {
                case 0:
                    lb_format.Visible = tb_textformat.Visible = true;
                    break;
                case 1:
                    lb_format.Visible = tb_textformat.Visible = false;
                    break;
            }
        }

        private void FormLoaded(object sender, EventArgs e)
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
            TimeElapsed.Text = String.Format("Time elapsed: {0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
        }

        private void bgworker_DoWork(object sender, DoWorkEventArgs e)
        {
            but_makeHash.Invoke((MethodInvoker)delegate { but_makeHash.Enabled = false; });
            BackgroundWorker worker = sender as BackgroundWorker;
            try
            {
                HashHelper.MakeHash(treeView1, tb_savePath.Text, tb_textformat.Text, type);
            }
            catch(Exception ex)
            {
                sw.Stop();
                tm.Stop();
                MessageBox.Show("Select Input dir and Output dir.", "Error");
            }
        }

        private void bgworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //
        }

        private void bgworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null) { }
            else if (e.Cancelled) { }
            else
            {
                sw.Stop();
                tm.Stop();
                InfoStatus.Text = "Done";
                but_makeHash.Invoke((MethodInvoker)delegate { but_makeHash.Enabled = true; });
            }
        }

        private void OpenRootDir(object sender, EventArgs e)
        {
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                tb_rootPath.Text = folderDlg.SelectedPath;
                TreeHelper.PopulateTreeView(treeView1, tb_rootPath.Text);
                TotalFiles.Text = String.Format("Files loaded: {0}", treeView1.GetNodeCount(true));
            }
        }

        private void OpenSaveDir(object sender, EventArgs e)
        {
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                tb_savePath.Text = folderDlg.SelectedPath;
            }
        }

        private void SelectNode(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            if (newSelected.Tag is FileInfo)
            {
                FileInfo fi = (FileInfo)newSelected.Tag;
                lb_file_path_info.Text =  fi.FullName;
            }
            else
            {
                DirectoryInfo di = (DirectoryInfo)newSelected.Tag;
                lb_file_path_info.Text = di.FullName;
            }
        }

        private void GenerateHash(object sender, EventArgs e)
        {
            if (!tb_textformat.Text.Contains("{0}") || !tb_textformat.Text.Contains("{1}"))
            {
                MessageBox.Show("Wrong string format.", "Error");
                return;
            }
            if (string.IsNullOrEmpty(tb_rootPath.Text) || string.IsNullOrEmpty(tb_savePath.Text))
            {
                MessageBox.Show("Directories filed is empty.", "Error");
                return;
            }
            if (!Directory.Exists(tb_savePath.Text) || !Directory.Exists(tb_rootPath.Text))
            {
                MessageBox.Show("Selected directories is not exist.", "Error");
                return;
            }
            type = cb_output_format.SelectedIndex;
            sw.Start();
            tm.Start();            
            bgworker.RunWorkerAsync();
        }

        private void deleteTreeNode_Click(object sender, EventArgs e)
        {
            try { treeView1.Nodes.Remove(treeView1.SelectedNode); }
            catch { }
        }
    }
}
