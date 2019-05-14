using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //新增项
            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //按内容删除项
            comboBox1.Items.Remove(textBox1.Text);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            //插入项
            int i = comboBox1.SelectedIndex;//获取ComboBox中当前选中的行
            if (i == -1)//如果没有行被选中
            {
                i = 0;
            }

            comboBox1.Items.Insert(i, textBox1.Text);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //按索引删除项
            if (comboBox1.SelectedIndex != -1)//如果选中了项目
            {
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //获取ComboBox的状态
            textBox2.Clear();


            textBox2.AppendText(string.Format("选中项索引号:{0}\r\n", comboBox1.SelectedIndex));//如果为多选模式，SelectedIndex返回一个选中项的索引号

            if (comboBox1.SelectedIndex != -1)
            {
                textBox2.AppendText(string.Format("选中项内容:{0}\r\n", comboBox1.SelectedItem.ToString()));
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            //清空全部项
            comboBox1.Items.Clear();
        }


        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
       
       
    }
}
