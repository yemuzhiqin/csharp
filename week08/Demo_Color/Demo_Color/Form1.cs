using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //设置标签背景颜色
            label1.BackColor = System.Drawing.Color.Plum;//两种写法等价
            //label1.BackColor = System.Drawing.Color.FromArgb(221, 160, 221);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //设置标签前景颜色
            label1.ForeColor = System.Drawing.Color.Red;
            //label1.ForeColor = Color.FromArgb(255, 0, 0);
        }

       
    }
}
