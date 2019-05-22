namespace Demo_MDIForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_File_OpenForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_File_CloseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_File_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Win = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Win_NewForm = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Win_CloseForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mi_Win_Title = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Win_Title_H = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Win_Title_V = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Win_Cas = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Help_About = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_File,
            this.mi_Win,
            this.mi_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(581, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mi_File
            // 
            this.mi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_File_OpenForm,
            this.mi_File_CloseForm,
            this.toolStripSeparator1,
            this.mi_File_Exit});
            this.mi_File.Name = "mi_File";
            this.mi_File.Size = new System.Drawing.Size(79, 24);
            this.mi_File.Text = "文件（&F)";
            // 
            // mi_File_OpenForm
            // 
            this.mi_File_OpenForm.Name = "mi_File_OpenForm";
            this.mi_File_OpenForm.Size = new System.Drawing.Size(225, 24);
            this.mi_File_OpenForm.Text = "打开Form2窗口（&O)";
            this.mi_File_OpenForm.Click += new System.EventHandler(this.mi_File_OpenForm_Click);
            // 
            // mi_File_CloseForm
            // 
            this.mi_File_CloseForm.Name = "mi_File_CloseForm";
            this.mi_File_CloseForm.Size = new System.Drawing.Size(225, 24);
            this.mi_File_CloseForm.Text = "关闭Form2窗口（&C）";
            this.mi_File_CloseForm.Click += new System.EventHandler(this.mi_File_CloseForm_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(222, 6);
            // 
            // mi_File_Exit
            // 
            this.mi_File_Exit.Name = "mi_File_Exit";
            this.mi_File_Exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mi_File_Exit.Size = new System.Drawing.Size(225, 24);
            this.mi_File_Exit.Text = "退出（&X）";
            this.mi_File_Exit.Click += new System.EventHandler(this.mi_File_Exit_Click);
            // 
            // mi_Win
            // 
            this.mi_Win.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Win_NewForm,
            this.mi_Win_CloseForm,
            this.toolStripSeparator2,
            this.mi_Win_Title,
            this.mi_Win_Cas});
            this.mi_Win.Name = "mi_Win";
            this.mi_Win.Size = new System.Drawing.Size(96, 24);
            this.mi_Win.Text = "窗口（&W）";
            this.mi_Win.DropDownOpened += new System.EventHandler(this.mi_Win_DropDownOpened);
            // 
            // mi_Win_NewForm
            // 
            this.mi_Win_NewForm.Name = "mi_Win_NewForm";
            this.mi_Win_NewForm.Size = new System.Drawing.Size(180, 24);
            this.mi_Win_NewForm.Text = "新建窗口（&N）";
            this.mi_Win_NewForm.Click += new System.EventHandler(this.mi_Win_NewForm_Click);
            // 
            // mi_Win_CloseForm
            // 
            this.mi_Win_CloseForm.Name = "mi_Win_CloseForm";
            this.mi_Win_CloseForm.Size = new System.Drawing.Size(180, 24);
            this.mi_Win_CloseForm.Text = "关闭窗口（&C）";
            this.mi_Win_CloseForm.Click += new System.EventHandler(this.mi_Win_CloseForm_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // mi_Win_Title
            // 
            this.mi_Win_Title.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Win_Title_H,
            this.mi_Win_Title_V});
            this.mi_Win_Title.Name = "mi_Win_Title";
            this.mi_Win_Title.Size = new System.Drawing.Size(180, 24);
            this.mi_Win_Title.Text = "平铺窗口（&T）";
            // 
            // mi_Win_Title_H
            // 
            this.mi_Win_Title_H.Name = "mi_Win_Title_H";
            this.mi_Win_Title_H.Size = new System.Drawing.Size(180, 24);
            this.mi_Win_Title_H.Text = "水平排列（&H）";
            this.mi_Win_Title_H.Click += new System.EventHandler(this.mi_Win_Title_H_Click);
            // 
            // mi_Win_Title_V
            // 
            this.mi_Win_Title_V.Name = "mi_Win_Title_V";
            this.mi_Win_Title_V.Size = new System.Drawing.Size(180, 24);
            this.mi_Win_Title_V.Text = "垂直排列（&V)";
            this.mi_Win_Title_V.Click += new System.EventHandler(this.mi_Win_Title_V_Click);
            // 
            // mi_Win_Cas
            // 
            this.mi_Win_Cas.Name = "mi_Win_Cas";
            this.mi_Win_Cas.Size = new System.Drawing.Size(180, 24);
            this.mi_Win_Cas.Text = "层叠窗口（&A）";
            this.mi_Win_Cas.Click += new System.EventHandler(this.mi_Win_Cas_Click);
            // 
            // mi_Help
            // 
            this.mi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Help_About});
            this.mi_Help.Name = "mi_Help";
            this.mi_Help.Size = new System.Drawing.Size(93, 24);
            this.mi_Help.Text = "帮助（&H）";
            // 
            // mi_Help_About
            // 
            this.mi_Help_About.Checked = true;
            this.mi_Help_About.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mi_Help_About.Name = "mi_Help_About";
            this.mi_Help_About.Size = new System.Drawing.Size(194, 24);
            this.mi_Help_About.Text = "关于本程序（&A）";
            this.mi_Help_About.Click += new System.EventHandler(this.mi_Help_About_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 334);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "MDI窗口演示";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mi_File;
        private System.Windows.Forms.ToolStripMenuItem mi_File_OpenForm;
        private System.Windows.Forms.ToolStripMenuItem mi_File_CloseForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mi_File_Exit;
        private System.Windows.Forms.ToolStripMenuItem mi_Win;
        private System.Windows.Forms.ToolStripMenuItem mi_Win_NewForm;
        private System.Windows.Forms.ToolStripMenuItem mi_Win_CloseForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mi_Win_Title;
        private System.Windows.Forms.ToolStripMenuItem mi_Win_Title_H;
        private System.Windows.Forms.ToolStripMenuItem mi_Win_Title_V;
        private System.Windows.Forms.ToolStripMenuItem mi_Win_Cas;
        private System.Windows.Forms.ToolStripMenuItem mi_Help;
        private System.Windows.Forms.ToolStripMenuItem mi_Help_About;
    }
}

