using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_Math
{
    public partial class Form1 : Form
    {

        private int _a;
        private int _b;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            _a = r.Next(1, 10);
            _b = r.Next(1, 10);
            label2.Text = Convert.ToString(_a) + "+" + Convert.ToString(_b) + "=";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            if (x == _a + _b)
            {
                lbl_Msg.Text = "你答对了，真棒！";
            }
            else
            {
                lbl_Msg.Text = "你答错了，继续加油！";
                textBox1.Focus();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Next_Click(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//回车键
                button2_Click(button2, e);
        }

       
    }
}
