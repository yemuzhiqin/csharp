namespace Demo_SqlConn
{
    partial class SqlConnForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_Srv = new System.Windows.Forms.TextBox();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_DbName = new System.Windows.Forms.TextBox();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusBar_Msg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ReadConfig = new System.Windows.Forms.Button();
            this.btn_Start2 = new System.Windows.Forms.Button();
            this.btn_Stop2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_Config = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库服务器：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据库登录名：";
            // 
            // txtBox_Srv
            // 
            this.txtBox_Srv.Location = new System.Drawing.Point(149, 43);
            this.txtBox_Srv.Name = "txtBox_Srv";
            this.txtBox_Srv.Size = new System.Drawing.Size(137, 25);
            this.txtBox_Srv.TabIndex = 2;
            // 
            // textBox_User
            // 
            this.textBox_User.Location = new System.Drawing.Point(149, 89);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(137, 25);
            this.textBox_User.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据库名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "登录密码：";
            // 
            // textBox_DbName
            // 
            this.textBox_DbName.Location = new System.Drawing.Point(503, 43);
            this.textBox_DbName.Name = "textBox_DbName";
            this.textBox_DbName.Size = new System.Drawing.Size(137, 25);
            this.textBox_DbName.TabIndex = 6;
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Location = new System.Drawing.Point(503, 89);
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.Size = new System.Drawing.Size(137, 25);
            this.textBox_Pwd.TabIndex = 7;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(149, 146);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(137, 30);
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "开始连接数据库";
            this.btn_Start.UseVisualStyleBackColor = true;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(503, 146);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(137, 30);
            this.btn_Stop.TabIndex = 9;
            this.btn_Stop.Text = "断开连接数据库";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Stop);
            this.groupBox1.Controls.Add(this.btn_Start);
            this.groupBox1.Controls.Add(this.textBox_Pwd);
            this.groupBox1.Controls.Add(this.textBox_DbName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_User);
            this.groupBox1.Controls.Add(this.txtBox_Srv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "代码拼接数据库连接信息：";
            // 
            // statusBar_Msg
            // 
            this.statusBar_Msg.Location = new System.Drawing.Point(24, 423);
            this.statusBar_Msg.Name = "statusBar_Msg";
            this.statusBar_Msg.Size = new System.Drawing.Size(296, 25);
            this.statusBar_Msg.TabIndex = 4;
            this.statusBar_Msg.TextChanged += new System.EventHandler(this.statusBar_Msg_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 0;
            // 
            // btn_ReadConfig
            // 
            this.btn_ReadConfig.Location = new System.Drawing.Point(9, 37);
            this.btn_ReadConfig.Name = "btn_ReadConfig";
            this.btn_ReadConfig.Size = new System.Drawing.Size(94, 25);
            this.btn_ReadConfig.TabIndex = 1;
            this.btn_ReadConfig.Text = "读取配置";
            this.btn_ReadConfig.UseVisualStyleBackColor = true;
            this.btn_ReadConfig.Click += new System.EventHandler(this.btn_ReadConfig_Click);
            // 
            // btn_Start2
            // 
            this.btn_Start2.Location = new System.Drawing.Point(149, 140);
            this.btn_Start2.Name = "btn_Start2";
            this.btn_Start2.Size = new System.Drawing.Size(137, 30);
            this.btn_Start2.TabIndex = 9;
            this.btn_Start2.Text = "开始连接数据库";
            this.btn_Start2.UseVisualStyleBackColor = true;
            this.btn_Start2.Click += new System.EventHandler(this.btn_Start2_Click);
            // 
            // btn_Stop2
            // 
            this.btn_Stop2.Location = new System.Drawing.Point(503, 140);
            this.btn_Stop2.Name = "btn_Stop2";
            this.btn_Stop2.Size = new System.Drawing.Size(137, 30);
            this.btn_Stop2.TabIndex = 10;
            this.btn_Stop2.Text = "断开连接数据库";
            this.btn_Stop2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Config);
            this.groupBox2.Controls.Add(this.btn_Stop2);
            this.groupBox2.Controls.Add(this.btn_Start2);
            this.groupBox2.Controls.Add(this.btn_ReadConfig);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "从App.config配置文件中读取数据库连接信息：";
            // 
            // textBox_Config
            // 
            this.textBox_Config.Location = new System.Drawing.Point(12, 68);
            this.textBox_Config.Multiline = true;
            this.textBox_Config.Name = "textBox_Config";
            this.textBox_Config.Size = new System.Drawing.Size(628, 66);
            this.textBox_Config.TabIndex = 11;
            this.textBox_Config.TextChanged += new System.EventHandler(this.textBox_Config_TextChanged);
            // 
            // SqlConnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 459);
            this.Controls.Add(this.statusBar_Msg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SqlConnForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_Srv;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_DbName;
        private System.Windows.Forms.TextBox textBox_Pwd;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox statusBar_Msg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ReadConfig;
        private System.Windows.Forms.Button btn_Start2;
        private System.Windows.Forms.Button btn_Stop2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Config;

    }
}

