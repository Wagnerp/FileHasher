namespace FileHasher
{
    partial class mainF
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainF));
            this.tb_rootPath = new System.Windows.Forms.TextBox();
            this.tb_savePath = new System.Windows.Forms.TextBox();
            this.but_rootDir = new System.Windows.Forms.Button();
            this.but_saveHash = new System.Windows.Forms.Button();
            this.folderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tvMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.but_makeHash = new System.Windows.Forms.Button();
            this.cb_output_format = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_textformat = new System.Windows.Forms.TextBox();
            this.lb_format = new System.Windows.Forms.Label();
            this.status_bar = new System.Windows.Forms.StatusStrip();
            this.TotalFiles = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimeElapsed = new System.Windows.Forms.ToolStripStatusLabel();
            this.InfoStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lb_file_path_info = new System.Windows.Forms.Label();
            this.tvMenu.SuspendLayout();
            this.status_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_rootPath
            // 
            this.tb_rootPath.Location = new System.Drawing.Point(12, 12);
            this.tb_rootPath.Name = "tb_rootPath";
            this.tb_rootPath.Size = new System.Drawing.Size(268, 20);
            this.tb_rootPath.TabIndex = 0;
            // 
            // tb_savePath
            // 
            this.tb_savePath.Location = new System.Drawing.Point(12, 38);
            this.tb_savePath.Name = "tb_savePath";
            this.tb_savePath.Size = new System.Drawing.Size(268, 20);
            this.tb_savePath.TabIndex = 1;
            // 
            // but_rootDir
            // 
            this.but_rootDir.Location = new System.Drawing.Point(286, 10);
            this.but_rootDir.Name = "but_rootDir";
            this.but_rootDir.Size = new System.Drawing.Size(144, 23);
            this.but_rootDir.TabIndex = 2;
            this.but_rootDir.Text = "Input dir";
            this.but_rootDir.UseVisualStyleBackColor = true;
            this.but_rootDir.Click += new System.EventHandler(this.OpenRootDir);
            // 
            // but_saveHash
            // 
            this.but_saveHash.Location = new System.Drawing.Point(286, 39);
            this.but_saveHash.Name = "but_saveHash";
            this.but_saveHash.Size = new System.Drawing.Size(144, 23);
            this.but_saveHash.TabIndex = 3;
            this.but_saveHash.Text = "Output dir";
            this.but_saveHash.UseVisualStyleBackColor = true;
            this.but_saveHash.Click += new System.EventHandler(this.OpenSaveDir);
            // 
            // folderDlg
            // 
            this.folderDlg.Description = "Указать путь к папке с файлами для хеша";
            this.folderDlg.ShowNewFolderButton = false;
            // 
            // treeView1
            // 
            this.treeView1.CheckBoxes = true;
            this.treeView1.ContextMenuStrip = this.tvMenu;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imgList;
            this.treeView1.Location = new System.Drawing.Point(12, 136);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(418, 219);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.SelectNode);
            // 
            // tvMenu
            // 
            this.tvMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTreeNode});
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(120, 26);
            // 
            // deleteTreeNode
            // 
            this.deleteTreeNode.Name = "deleteTreeNode";
            this.deleteTreeNode.Size = new System.Drawing.Size(119, 22);
            this.deleteTreeNode.Text = "Удалить";
            this.deleteTreeNode.Click += new System.EventHandler(this.deleteTreeNode_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "closeF.png");
            this.imgList.Images.SetKeyName(1, "openF.png");
            this.imgList.Images.SetKeyName(2, "file.png");
            // 
            // but_makeHash
            // 
            this.but_makeHash.Location = new System.Drawing.Point(286, 68);
            this.but_makeHash.Name = "but_makeHash";
            this.but_makeHash.Size = new System.Drawing.Size(144, 23);
            this.but_makeHash.TabIndex = 5;
            this.but_makeHash.Text = "Generate";
            this.but_makeHash.UseVisualStyleBackColor = true;
            this.but_makeHash.Click += new System.EventHandler(this.GenerateHash);
            // 
            // cb_output_format
            // 
            this.cb_output_format.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_output_format.FormattingEnabled = true;
            this.cb_output_format.Items.AddRange(new object[] {
            "txt format",
            "xml format"});
            this.cb_output_format.Location = new System.Drawing.Point(114, 63);
            this.cb_output_format.Name = "cb_output_format";
            this.cb_output_format.Size = new System.Drawing.Size(119, 21);
            this.cb_output_format.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output format data:";
            // 
            // tb_textformat
            // 
            this.tb_textformat.Location = new System.Drawing.Point(114, 87);
            this.tb_textformat.Name = "tb_textformat";
            this.tb_textformat.Size = new System.Drawing.Size(117, 20);
            this.tb_textformat.TabIndex = 8;
            this.tb_textformat.Text = "{0}:{1}";
            this.toolTip1.SetToolTip(this.tb_textformat, "{0} - file name and path\r\n{1} - hash");
            this.tb_textformat.Visible = false;
            // 
            // lb_format
            // 
            this.lb_format.AutoSize = true;
            this.lb_format.Location = new System.Drawing.Point(6, 90);
            this.lb_format.Name = "lb_format";
            this.lb_format.Size = new System.Drawing.Size(102, 13);
            this.lb_format.TabIndex = 9;
            this.lb_format.Text = "Output string format:";
            this.lb_format.Visible = false;
            // 
            // status_bar
            // 
            this.status_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalFiles,
            this.TimeElapsed,
            this.InfoStatus});
            this.status_bar.Location = new System.Drawing.Point(0, 358);
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(442, 22);
            this.status_bar.TabIndex = 10;
            this.status_bar.Text = "statusStrip1";
            // 
            // TotalFiles
            // 
            this.TotalFiles.Name = "TotalFiles";
            this.TotalFiles.Size = new System.Drawing.Size(0, 17);
            // 
            // TimeElapsed
            // 
            this.TimeElapsed.Name = "TimeElapsed";
            this.TimeElapsed.Size = new System.Drawing.Size(0, 17);
            // 
            // InfoStatus
            // 
            this.InfoStatus.Name = "InfoStatus";
            this.InfoStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lb_file_path_info
            // 
            this.lb_file_path_info.AutoSize = true;
            this.lb_file_path_info.Location = new System.Drawing.Point(12, 120);
            this.lb_file_path_info.Name = "lb_file_path_info";
            this.lb_file_path_info.Size = new System.Drawing.Size(0, 13);
            this.lb_file_path_info.TabIndex = 11;
            // 
            // mainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 380);
            this.Controls.Add(this.lb_file_path_info);
            this.Controls.Add(this.status_bar);
            this.Controls.Add(this.lb_format);
            this.Controls.Add(this.tb_textformat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_output_format);
            this.Controls.Add(this.but_makeHash);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.but_saveHash);
            this.Controls.Add(this.but_rootDir);
            this.Controls.Add(this.tb_savePath);
            this.Controls.Add(this.tb_rootPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasher";
            this.Load += new System.EventHandler(this.FormLoaded);
            this.tvMenu.ResumeLayout(false);
            this.status_bar.ResumeLayout(false);
            this.status_bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_rootPath;
        private System.Windows.Forms.TextBox tb_savePath;
        private System.Windows.Forms.Button but_rootDir;
        private System.Windows.Forms.Button but_saveHash;
        private System.Windows.Forms.FolderBrowserDialog folderDlg;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Button but_makeHash;
        private System.Windows.Forms.ContextMenuStrip tvMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteTreeNode;
        private System.Windows.Forms.ComboBox cb_output_format;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_textformat;
        private System.Windows.Forms.Label lb_format;
        private System.Windows.Forms.StatusStrip status_bar;
        private System.Windows.Forms.ToolStripStatusLabel TotalFiles;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lb_file_path_info;
        private System.Windows.Forms.ToolStripStatusLabel TimeElapsed;
        private System.Windows.Forms.ToolStripStatusLabel InfoStatus;
    }
}

