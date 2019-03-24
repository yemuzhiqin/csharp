using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Hello,World!这是一个C#Windows Form程序！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
