using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_ListBox
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
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //按内容删除项
            listBox1.Items.Remove(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //插入项
            int i = listBox1.SelectedIndex;//获取ListBox中当前选中的行
            if (i == -1)//如果没有行被选中
            {
                i = 0;
            }

            listBox1.Items.Insert(i, textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //按索引删除项
            if (listBox1.SelectedIndex != -1)//如果选中了项目
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //获取ListBox的状态
            textBox2.Clear();

            textBox2.AppendText(string.Format("选中项数量:{0}\r\n", listBox1.SelectedItems.Count));

            if (!checkBox1.Checked && listBox1.SelectedItems.Count > 0)//如果是单选模式
            {
                textBox2.AppendText(string.Format("选中项索引号:{0}\r\n", listBox1.SelectedIndex));//如果为多选模式，SelectedIndex返回一个选中项的索引号
                textBox2.AppendText(string.Format("选中项内容:{0}\r\n", listBox1.SelectedItem.ToString()));
            }
            else
            {
                foreach (string str in listBox1.SelectedItems)
                {
                    textBox2.AppendText(string.Format("选中项内容:{0}\r\n", str));
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //清空全部项
            listBox1.Items.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //是否允许ListBox多选
            if (checkBox1.Checked)
            {
                listBox1.SelectionMode = SelectionMode.MultiSimple;
            }
            else
            {
                listBox1.SelectionMode = SelectionMode.One;
            }
        }


    }
}
