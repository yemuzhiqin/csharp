using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo_MDIForm
{
    public partial class Form1 : Form
    {

        Form2 myForm;


        public Form1()
        {
            InitializeComponent();
        }

        //退出
        private void mi_File_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //新建窗体
        private void mi_File_OpenForm_Click(object sender, EventArgs e)
        {
            if (myForm == null)
            {
                myForm = new Form2();
                myForm.MdiParent = this;
            }
            myForm.Show();
        }

        //关闭窗体
        private void mi_File_CloseForm_Click(object sender, EventArgs e)
        {
            if (myForm != null)
            {
                myForm.Close();
                myForm = null;
            }
        }

        //新建窗体
        private void mi_Win_NewForm_Click(object sender, EventArgs e)
        {
            Form aForm = new Form();
            aForm.MdiParent = this;
            aForm.Text=string.Format("Mdi Window {0}",this.MdiChildren.Count()+1);
            aForm.Width = 450;
            aForm.Show();

        }

        //关闭窗体
        private void mi_Win_CloseForm_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        //使无窗体时呈现灰色
        private void mi_Win_DropDownOpened(object sender, EventArgs e)
        {
            mi_Win_CloseForm.Enabled = this.MdiChildren.Count() > 0;
        }

        //水平平铺
        private void mi_Win_Title_H_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        //垂直平铺
        private void mi_Win_Title_V_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        //层叠窗口
        private void mi_Win_Cas_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        //关于本程序
        private void mi_Help_About_Click(object sender, EventArgs e)
        {
            (new AboutForm()).Show();
        }

        

    }
}
