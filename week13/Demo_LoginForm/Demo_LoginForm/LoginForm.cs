using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Demo_LoginForm
{
    public partial class Form1 : Form
    {

        //private string _UserName = "yeqin";
        //private string _UserPwd="123456";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool CheckUserInfo(string userName, string userPwd)//从数据库中验证用户和密码
        {
            string connStr = Properties.Settings.Default.MyConnectionString;
            SqlConnection sqlConn = new SqlConnection();
            sqlConn.ConnectionString = connStr;

            try
            {
                sqlConn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("数据库连接失败！请检查配置文件信息!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //查询满足该条件(用户名+密码+帐号是否停止)的记录有多少条
            string sqlStr = string.Format("select count(*) from Table_Czy where UserId='{0}' and UserPwd='{1}' and UserIsStoped=0", userName, userPwd);

            SqlCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = sqlStr;

            int iResult = Convert.ToInt32(sqlCmd.ExecuteScalar());//ExecuteScalar()方法可返回SqlCommand执行后的首行首列的结果

            sqlConn.Close();//后面的代码不再需要对数据库的操作了，直接断开与数据库的连接
            if (iResult > 0)
                return true;
            else
                return false;
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            txt_UserName.Text = "";
            txt_UserPwd.Text = "";
            this.Close();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            string userPwd = txt_UserPwd.Text;

            if (CheckUserInfo(userName,userPwd))
            {
                MessageBox.Show(this, "用户名和密码验证通过，登陆成功！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "用户名和密码验证失败，请检查后重试！", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_UserName.Focus();//空间获取焦点
            }
        }

        private void txt_UserName_TextChanged(object sender, EventArgs e)
        {
            btn_Login.Enabled = (txt_UserName.Text != "") && (txt_UserPwd.Text != "");
        }

        //private void txt_UserPwd_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    //MessageBox.Show(e.KeyChar.ToString());
        //    if (e.KeyChar == 13)//回车键
        //        btn_Login_Click(btn_Login, e);
        //    else if (e.KeyChar == 27)//ESC键
        //        btn_Cancel_Click(sender, e);
        //}

        private void txt_UserPwd_KeyDown(object sender, KeyEventArgs e)
        {
            //此事件与KeyPress事件只需其一即可，不可两者均写
            if (e.KeyCode == Keys.Enter)//回车键
            {
                btn_Login_Click(sender, e);
            }
            else if(e.KeyCode==Keys.Cancel)
            {
                btn_Login_Click(sender,e);
            }
        }
    }
}
