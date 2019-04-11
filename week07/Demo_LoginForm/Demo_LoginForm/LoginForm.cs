using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_LoginForm
{
    public partial class Form1 : Form
    {

        private string _UserName = "yeqin";
        private string _UserPwd="123456";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            if ((userName == _UserName) && (userPwd == _UserPwd))
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

        private void txt_UserPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            if (e.KeyChar == 13)//回车键
                btn_Login_Click(btn_Login, e);
            else if (e.KeyChar == 27)//ESC键
                btn_Cancel_Click(sender, e);
        }

        private void txt_UserPwd_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
