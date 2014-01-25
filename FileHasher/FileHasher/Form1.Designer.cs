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
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.but_makeHash = new System.Windows.Forms.Button();
            this.infoout = new System.Windows.Forms.RichTextBox();
            this.tvMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteTreeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tvMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_rootPath
            // 
            this.tb_rootPath.Location = new System.Drawing.Point(12, 12);
            this.tb_rootPath.Name = "tb_rootPath";
            this.tb_rootPath.Size = new System.Drawing.Size(333, 20);
            this.tb_rootPath.TabIndex = 0;
            // 
            // tb_savePath
            // 
            this.tb_savePath.Location = new System.Drawing.Point(12, 38);
            this.tb_savePath.Name = "tb_savePath";
            this.tb_savePath.Size = new System.Drawing.Size(333, 20);
            this.tb_savePath.TabIndex = 1;
            // 
            // but_rootDir
            // 
            this.but_rootDir.Location = new System.Drawing.Point(355, 10);
            this.but_rootDir.Name = "but_rootDir";
            this.but_rootDir.Size = new System.Drawing.Size(75, 23);
            this.but_rootDir.TabIndex = 2;
            this.but_rootDir.Text = "Path to root";
            this.but_rootDir.UseVisualStyleBackColor = true;
            this.but_rootDir.Click += new System.EventHandler(this.but_rootDir_Click);
            // 
            // but_saveHash
            // 
            this.but_saveHash.Location = new System.Drawing.Point(355, 39);
            this.but_saveHash.Name = "but_saveHash";
            this.but_saveHash.Size = new System.Drawing.Size(75, 23);
            this.but_saveHash.TabIndex = 3;
            this.but_saveHash.Text = "Path to save";
            this.but_saveHash.UseVisualStyleBackColor = true;
            this.but_saveHash.Click += new System.EventHandler(this.but_saveHash_Click);
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
            this.treeView1.Location = new System.Drawing.Point(12, 130);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(418, 238);
            this.treeView1.TabIndex = 4;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
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
            this.but_makeHash.Location = new System.Drawing.Point(331, 68);
            this.but_makeHash.Name = "but_makeHash";
            this.but_makeHash.Size = new System.Drawing.Size(99, 23);
            this.but_makeHash.TabIndex = 5;
            this.but_makeHash.Text = "Generate hash";
            this.but_makeHash.UseVisualStyleBackColor = true;
            this.but_makeHash.Click += new System.EventHandler(this.but_makeHash_Click);
            // 
            // infoout
            // 
            this.infoout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoout.Location = new System.Drawing.Point(12, 64);
            this.infoout.Name = "infoout";
            this.infoout.ReadOnly = true;
            this.infoout.Size = new System.Drawing.Size(313, 60);
            this.infoout.TabIndex = 6;
            this.infoout.Text = "";
            // 
            // tvMenu
            // 
            this.tvMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteTreeNode});
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(119, 26);
            // 
            // deleteTreeNode
            // 
            this.deleteTreeNode.Name = "deleteTreeNode";
            this.deleteTreeNode.Size = new System.Drawing.Size(152, 22);
            this.deleteTreeNode.Text = "Удалить";
            this.deleteTreeNode.Click += new System.EventHandler(this.deleteTreeNode_Click);
            // 
            // mainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 380);
            this.Controls.Add(this.infoout);
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
            this.Load += new System.EventHandler(this.mainF_Load);
            this.tvMenu.ResumeLayout(false);
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
        private System.Windows.Forms.RichTextBox infoout;
        private System.Windows.Forms.ContextMenuStrip tvMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteTreeNode;
    }
}

