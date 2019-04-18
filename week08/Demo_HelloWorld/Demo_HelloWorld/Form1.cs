using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //标签内容在窗体上不可见，只有在执行时才可见
            Label label2 = new Label();
            label2.AutoSize = true;
            label2.Parent = this;
            label2.BackColor = System.Drawing.Color.Cyan;
            label2.Location = new System.Drawing.Point(150, 100);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 12);
            label2.Text = "Hello World!";
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("微软雅黑", 24F);
        }

    
    }
}
