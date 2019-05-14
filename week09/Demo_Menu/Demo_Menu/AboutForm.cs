using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_Menu
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Links[0].LinkData = "http://blog.csdn.net/yemuzhiqin/";
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());

            //如果Text中就是链接URL的话，可直接写成：  
            //linkLabel1.Links[0].LinkData = linkLabel1.Text;
            //System.Diagnostics.Process.Start(linkLabel1.Text);

            linkLabel1.LinkVisited = true;//把控件的颜色设置为已访问的颜色
        }

    }
}
