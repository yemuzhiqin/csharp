using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_HelloWorld_In_Designer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //在这里编写代码，windows窗口中不会显示信息，只有在执行时才会显示出来，若想要在窗口中显示，则只需要把代码写在Form.Designer中即可
            //Label Label1 = new Label();
            //Label1.Text = "Hello,World!";
            //Label1.Parent = this;
            //Label1.Location = new Point(30, 20);
            //Label1.AutoSize = true;
            //Label1.BackColor = System.Drawing.Color.LightGreen;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label Label2 = new Label();//Label2的作用域只在本函数中
            Label2.Parent = this;
            Label2.AutoSize = true;
            Label2.Location = new Point(100, 80);
            Label2.Text = "夜幕之琴";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label1.BackColor = System.Drawing.Color.LightSalmon;//Label1是Form1中的一个字段，作用域为此类
            //Label2.BackColor = System.Drawing.Color.LightSalmon;//会出错，Label2的作用域不包含此函数
            int w1 = this.Width;//窗口的宽度
            int w2 = Label1.Width;//标签Label1的宽度
            int w = (w1 - w2) / 2;//计算Label1.w的值
            Label1.Location = new Point(w, Label1.Location.Y);
        }
    }
}
