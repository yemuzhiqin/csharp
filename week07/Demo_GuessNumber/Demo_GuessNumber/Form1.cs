using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_GuessNumber
{
    public partial class Form1 : Form
    {
        int GameNum = 0;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            if (x == GameNum)
            {
                MessageBox.Show("你猜对了！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (x < GameNum)
            {
                MessageBox.Show("你猜小了！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("你猜大了！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            GameNum = r.Next(1, 100);
            textBox1.Text = "";
            textBox2.Text = "";
            if (textBox2.CanFocus)
            {
                textBox2.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = GameNum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2_Click(button2, e);
        }
    }
}
