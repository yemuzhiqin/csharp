using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace Demo_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left < -label1.Width)
            {
                label1.Left = this.Width;
            }
            else
            {
                label1.Left = label1.Left - 3;
            }
        }

        //开始广告
        private void mi_Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            splitContainer1.Panel2.Show();
        }

        //停止广告
        private void mi_Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            splitContainer1.Panel2.Hide();
        }

        //点击鼠标右键时显示contextMenuStrip1
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
            }
        }


        //未点击时显示灰色
        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            mi_Start.Enabled = !timer1.Enabled;
            mi_Stop.Enabled = !mi_Start.Enabled;
        }
    }
}
