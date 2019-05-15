using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TabPage CreateNewPage()
        {
            int iCount = tabControl1.TabPages.Count + 1;

            TabPage aPage = new TabPage();
            aPage.Text = "New_Page" + iCount.ToString();
            aPage.UseVisualStyleBackColor = true;
            aPage.ImageIndex = 2;
            return aPage;
        }

        //增加新的一页
        private void button1_Click(object sender, EventArgs e)
        {
            TabPage aPage = CreateNewPage();
            tabControl1.TabPages.Add(aPage);
            tabControl1.SelectedTab = aPage;
        }

        //插入新的一页
        private void button2_Click(object sender, EventArgs e)
        {
            int iCurrPageIndex = tabControl1.SelectedIndex;
            if (iCurrPageIndex == -1)
            {
                iCurrPageIndex = 0;
            }

            TabPage aPage = CreateNewPage();
            aPage.BackColor = Color.Blue;

            tabControl1.TabPages.Insert(iCurrPageIndex, aPage);
            tabControl1.SelectedTab = aPage;
        }

        //删除当前页（方法一）
        private void button3_Click(object sender, EventArgs e)
        {
          
            int x = tabControl1.SelectedIndex;

            if (x != -1)
            {
                tabControl1.TabPages.RemoveAt(x);//通过索引号来删除页
                if (x < tabControl1.TabPages.Count - 1)
                {
                    tabControl1.SelectedIndex = x;
                }
            }
        }

        //删除当前页（方法二）
        private void button4_Click(object sender, EventArgs e)
        {
            int x = tabControl1.SelectedIndex;

            if (tabControl1.SelectedTab != null)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);//通过页面对象来删除页
                if (x < tabControl1.TabPages.Count - 1)
                {
                    tabControl1.SelectedIndex = x;
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
