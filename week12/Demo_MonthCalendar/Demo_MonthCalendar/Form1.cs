using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //月历
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.TodayDate.ToString("yyyy-MM-dd");//返回月历的今天日期
            textBox2.Text = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd");//返回所选月历的开始日期
            textBox3.Text = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd");//返回所选月历的结束日期
        }

        //退出
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //多选日期最大天数
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = Convert.ToInt16(numericUpDown1.Value);
        }
    }
}
