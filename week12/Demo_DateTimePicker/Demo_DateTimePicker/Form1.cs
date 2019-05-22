using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //长日期
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Long;
        }

        //短日期
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        //时间
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Time;
        }

        //自定义
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = textBox2.Text;
        }

        //获取结果按钮
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.dateTimePicker1.Value.ToString();
            this.textBox1.Text = this.dateTimePicker1.Text;
        }
    }
}
