using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo_SqlConn
{
    public partial class SqlConnForm : Form
    {
        SqlConnection sqlConn = new SqlConnection();

        public SqlConnForm()
        {
            InitializeComponent();
            UpdateDbStatus();
            textBox_Config.Text = "";
            
            
        }

        private void UpdateDbStatus()//更新数据库的状态
        {
            if (sqlConn.State == ConnectionState.Open)
            {
                statusBar_Msg.Text = "数据库连接已打开！";
                btn_Start.Enabled = false;
                btn_Start2.Enabled = false;
                btn_Stop.Enabled = true;
                btn_Stop2.Enabled = true;
            }
            else if (sqlConn.State == ConnectionState.Closed)
            {
                statusBar_Msg.Text = "数据库连接已断开！";
                btn_Start.Enabled = true;
                btn_Start2.Enabled = textBox_Config.Text.Trim() != "";
                btn_Stop.Enabled = false;
                btn_Stop2.Enabled = false;
            }
            return;
        }

        private void LinkDbSrv(string connStr)
        {
            sqlConn.ConnectionString = connStr;
            try
            {
                sqlConn.Close();
                sqlConn.Open();
                UpdateDbStatus();
            }
            catch (Exception er)
            {
                MessageBox.Show(string.Format("数据库连接失败！{0}", er.Message), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateDbStatus();
                //throw er;
            }
        }

       
        private void sqlConn_StateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState == ConnectionState.Open)
            {
                statusBar_Msg.Text = "数据库连接已打开！";
                btn_Start.Enabled = false;
                btn_Stop.Enabled = true;
            }
            else if (e.CurrentState == ConnectionState.Closed)
            {
                statusBar_Msg.Text = "数据库连接已断开！";
                btn_Start.Enabled = true;
                btn_Stop.Enabled = false;
            }
        }


        private void btn_Start2_Click(object sender, EventArgs e)
        {
            LinkDbSrv(textBox_Config.Text);
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            sqlConn.Close();
            UpdateDbStatus();
        }

        private void textBox_Config_TextChanged(object sender, EventArgs e)
        {
            UpdateDbStatus();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            string connStr = "Data Source=" + txtBox_Srv.Text + ";Initial Catalog=" + textBox_DbName.Text + ";Persist Security Info=True;User ID=" + textBox_User.Text + ";Password=" + textBox_Pwd.Text;
            LinkDbSrv(connStr);
        }

        private void btn_ReadConfig_Click(object sender, EventArgs e)
        {
            textBox_Config.Text = Demo_SqlConn.Properties.Settings.Default.MyConnectionString;
        }

        private void statusBar_Msg_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
