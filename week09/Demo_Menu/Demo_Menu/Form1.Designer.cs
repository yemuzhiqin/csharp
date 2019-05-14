namespace Demo_Menu
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_SaveAS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_PageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Edit_Cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.格式OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_AutoLine = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_FontSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_StatusStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_About = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statubBar_Row = new System.Windows.Forms.ToolStripStatusLabel();
            this.statubBar_Col = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.statusBar_Encode = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.mi_Edit,
            this.格式OToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(851, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_NewFile,
            this.mi_OpenFile,
            this.mi_SaveFile,
            this.mi_SaveAS,
            this.toolStripSeparator1,
            this.mi_PageSetup,
            this.mi_Print,
            this.toolStripSeparator3,
            this.mi_Exit});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.文件FToolStripMenuItem.Text = "文件（&F）";
            // 
            // mi_NewFile
            // 
            this.mi_NewFile.Name = "mi_NewFile";
            this.mi_NewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mi_NewFile.Size = new System.Drawing.Size(220, 24);
            this.mi_NewFile.Text = "新建（&N）";
            this.mi_NewFile.Click += new System.EventHandler(this.mi_NewFile_Click);
            // 
            // mi_OpenFile
            // 
            this.mi_OpenFile.Name = "mi_OpenFile";
            this.mi_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mi_OpenFile.Size = new System.Drawing.Size(220, 24);
            this.mi_OpenFile.Text = "打开（&O）...";
            this.mi_OpenFile.Click += new System.EventHandler(this.mi_OpenFile_Click);
            // 
            // mi_SaveFile
            // 
            this.mi_SaveFile.Name = "mi_SaveFile";
            this.mi_SaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_SaveFile.Size = new System.Drawing.Size(220, 24);
            this.mi_SaveFile.Text = "保存（&S）";
            this.mi_SaveFile.Click += new System.EventHandler(this.mi_SaveFile_Click);
            // 
            // mi_SaveAS
            // 
            this.mi_SaveAS.Name = "mi_SaveAS";
            this.mi_SaveAS.Size = new System.Drawing.Size(220, 24);
            this.mi_SaveAS.Text = "另存为（&A）...";
            this.mi_SaveAS.Click += new System.EventHandler(this.mi_SaveAS_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // mi_PageSetup
            // 
            this.mi_PageSetup.Name = "mi_PageSetup";
            this.mi_PageSetup.Size = new System.Drawing.Size(220, 24);
            this.mi_PageSetup.Text = "页面设置（&U）";
            this.mi_PageSetup.Click += new System.EventHandler(this.mi_PageSetup_Click);
            // 
            // mi_Print
            // 
            this.mi_Print.Name = "mi_Print";
            this.mi_Print.Size = new System.Drawing.Size(220, 24);
            this.mi_Print.Text = "打印（&P）";
            this.mi_Print.Click += new System.EventHandler(this.mi_Print_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(217, 6);
            // 
            // mi_Exit
            // 
            this.mi_Exit.Name = "mi_Exit";
            this.mi_Exit.Size = new System.Drawing.Size(220, 24);
            this.mi_Exit.Text = "退出（&X）";
            this.mi_Exit.Click += new System.EventHandler(this.mi_Exit_Click);
            // 
            // mi_Edit
            // 
            this.mi_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Edit_Cancel,
            this.mi_Edit_Copy,
            this.mi_Edit_Cut,
            this.mi_Edit_Paste});
            this.mi_Edit.Name = "mi_Edit";
            this.mi_Edit.Size = new System.Drawing.Size(89, 24);
            this.mi_Edit.Text = "编辑（&E）";
            this.mi_Edit.DropDownOpened += new System.EventHandler(this.mi_Edit_DropDownOpened);
            // 
            // mi_Edit_Cancel
            // 
            this.mi_Edit_Cancel.Name = "mi_Edit_Cancel";
            this.mi_Edit_Cancel.Size = new System.Drawing.Size(164, 24);
            this.mi_Edit_Cancel.Text = "撤消（&U）";
            this.mi_Edit_Cancel.Click += new System.EventHandler(this.mi_Edit_Cancel_Click);
            // 
            // mi_Edit_Copy
            // 
            this.mi_Edit_Copy.Name = "mi_Edit_Copy";
            this.mi_Edit_Copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mi_Edit_Copy.Size = new System.Drawing.Size(164, 24);
            this.mi_Edit_Copy.Text = "复制";
            this.mi_Edit_Copy.Click += new System.EventHandler(this.mi_Edit_Copy_Click);
            // 
            // mi_Edit_Cut
            // 
            this.mi_Edit_Cut.Name = "mi_Edit_Cut";
            this.mi_Edit_Cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mi_Edit_Cut.Size = new System.Drawing.Size(164, 24);
            this.mi_Edit_Cut.Text = "剪切";
            this.mi_Edit_Cut.Click += new System.EventHandler(this.mi_Edit_Cut_Click);
            // 
            // mi_Edit_Paste
            // 
            this.mi_Edit_Paste.Name = "mi_Edit_Paste";
            this.mi_Edit_Paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mi_Edit_Paste.Size = new System.Drawing.Size(164, 24);
            this.mi_Edit_Paste.Text = "粘贴";
            this.mi_Edit_Paste.Click += new System.EventHandler(this.mi_Edit_Paste_Click);
            // 
            // 格式OToolStripMenuItem
            // 
            this.格式OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_AutoLine,
            this.toolStripSeparator2,
            this.mi_FontSetup});
            this.格式OToolStripMenuItem.Name = "格式OToolStripMenuItem";
            this.格式OToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.格式OToolStripMenuItem.Text = "格式（&O）";
            // 
            // mi_AutoLine
            // 
            this.mi_AutoLine.Checked = true;
            this.mi_AutoLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_AutoLine.Name = "mi_AutoLine";
            this.mi_AutoLine.Size = new System.Drawing.Size(179, 24);
            this.mi_AutoLine.Text = "自动换行（&A）";
            this.mi_AutoLine.Click += new System.EventHandler(this.mi_AutoLine_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // mi_FontSetup
            // 
            this.mi_FontSetup.Name = "mi_FontSetup";
            this.mi_FontSetup.Size = new System.Drawing.Size(179, 24);
            this.mi_FontSetup.Text = "字体（&F）";
            this.mi_FontSetup.Click += new System.EventHandler(this.mi_FontSetup_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_StatusStrip});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.查看ToolStripMenuItem.Text = "查看（&V）";
            // 
            // mi_StatusStrip
            // 
            this.mi_StatusStrip.Checked = true;
            this.mi_StatusStrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_StatusStrip.Name = "mi_StatusStrip";
            this.mi_StatusStrip.Size = new System.Drawing.Size(162, 24);
            this.mi_StatusStrip.Text = "状态栏（&S）";
            this.mi_StatusStrip.Click += new System.EventHandler(this.mi_StatusStrip_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助VToolStripMenuItem,
            this.toolStripSeparator4,
            this.mi_About});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.帮助HToolStripMenuItem.Text = "帮助（&H）";
            // 
            // 查看帮助VToolStripMenuItem
            // 
            this.查看帮助VToolStripMenuItem.Name = "查看帮助VToolStripMenuItem";
            this.查看帮助VToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.查看帮助VToolStripMenuItem.Text = "查看帮助（&H）";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(191, 6);
            // 
            // mi_About
            // 
            this.mi_About.Name = "mi_About";
            this.mi_About.Size = new System.Drawing.Size(194, 24);
            this.mi_About.Text = "关于记事本（&A）";
            this.mi_About.Click += new System.EventHandler(this.mi_About_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(851, 388);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            this.textBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseUp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "文本文档（*.text)|*.text|所有文件(*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "文本文档（*.text)|*.text|所有文件(*.*)|*.*";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statubBar_Row,
            this.statubBar_Col,
            this.statusBar_Encode});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(851, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(701, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // statubBar_Row
            // 
            this.statubBar_Row.Name = "statubBar_Row";
            this.statubBar_Row.Size = new System.Drawing.Size(33, 20);
            this.statubBar_Row.Text = "1行";
            // 
            // statubBar_Col
            // 
            this.statubBar_Col.Name = "statubBar_Col";
            this.statubBar_Col.Size = new System.Drawing.Size(33, 20);
            this.statubBar_Col.Text = "1列";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // statusBar_Encode
            // 
            this.statusBar_Encode.Name = "statusBar_Encode";
            this.statusBar_Encode.Size = new System.Drawing.Size(69, 20);
            this.statusBar_Encode.Text = "编码格式";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 420);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "我的记事本";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_NewFile;
        private System.Windows.Forms.ToolStripMenuItem mi_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem mi_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem mi_SaveAS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_Exit;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit_Cancel;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem mi_Edit_Paste;
        private System.Windows.Forms.ToolStripMenuItem 格式OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_AutoLine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statubBar_Row;
        private System.Windows.Forms.ToolStripStatusLabel statubBar_Col;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_StatusStrip;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_About;
        private System.Windows.Forms.ToolStripMenuItem mi_PageSetup;
        private System.Windows.Forms.ToolStripMenuItem mi_Print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem mi_FontSetup;
        private System.Windows.Forms.ToolStripStatusLabel statusBar_Encode;
    }
}

