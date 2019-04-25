using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Demo_Menu
{
    public partial class Form1 : Form
    {

        //显示光标所在的行和列
        private void SetRowColInfo()
        {
            int index = textBox1.GetFirstCharIndexOfCurrentLine();//得到当前行第一个字符的索引
            int row = textBox1.GetLineFromCharIndex(index) + 1;//得到当前行的行号，从0开始，习惯是从1开始，所以+1
            int col = textBox1.SelectionStart - index + 1;//SelectionStart得到光标所在位置的索引减去当前行第一个字符的索引=光标所在的列数（从0开始）

            statubBar_Row.Text = row.ToString() + "行";
            statubBar_Col.Text = col.ToString() + "列";

        }


        private string _FileName = "";//文件名
        private bool _IsSaved = true;//是否已保存

        

        //保存文件
        private void SaveFile()
        {
            if (_FileName == "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    _FileName = saveFileDialog1.FileName;
                }
                else
                {
                    return;
                }
            }

            this.Text = _FileName;


            System.IO.StreamWriter sw = new System.IO.StreamWriter(_FileName);
            sw.WriteLine(textBox1.Text);
            sw.Flush();
            sw.Close();
            _IsSaved = true;
        }

        public Form1()
        {
            InitializeComponent();
        }



        //显示光标所在的行和列
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SetRowColInfo();
        }

        //退出
        private void mi_Exit_Click(object sender, EventArgs e)
        {
            if (!_IsSaved)
            {
                DialogResult dr = MessageBox.Show("文档内容已修改，要保存吗？", "保存提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                switch (dr)
                {
                    case DialogResult.Yes:
                        mi_SaveFile_Click(sender, e);
                        this.Close();
                        break;
                    case DialogResult.No:
                        this.Close();
                        break;
                    default:
                        textBox1.Focus();
                        break;
                }
            }
            else
            {
                this.Close();
            }
            
                
        }

        //新建
        private void mi_NewFile_Click(object sender, EventArgs e)
        {
            DialogResult dResult;
            if (!_IsSaved)
            {
                dResult = MessageBox.Show("当前文档已修改，要保存吗？", "保存提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dResult == DialogResult.Yes)
                {
                    if (this.textBox1.Text == "文本文档")
                    {
                        mi_SaveAS_Click(sender, e);
                    }
                    else
                    {
                        mi_SaveFile_Click(sender, e);
                    }
                }
                else if (dResult == DialogResult.No)
                {

                    _FileName = "";
                    _IsSaved = true;
                    textBox1.Clear();
                    this.Text = "新建文本文档";
                    textBox1.Focus();
                }
            }
            else
            {
                _FileName = "";
                _IsSaved = true;
                textBox1.Clear();
                this.Text = "新建文本文档";
                textBox1.Focus();
            }
        }

        //打开
        private void mi_OpenFile_Click(object sender, EventArgs e)
        {
            string fileName;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;

                    System.IO.StreamReader sr;//读取数据流
                    sr=new System.IO.StreamReader(fileName, Encoding.UTF8);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    textBox1.Focus();
                    _FileName = fileName;
                    _IsSaved = true;
                    this.Text = _FileName;
                }
                
        }

        //保存
        private void mi_SaveFile_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        //另存为
        private void mi_SaveAS_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _FileName = saveFileDialog1.FileName;
                SaveFile();
            }
        }

        //自动换行
        private void mi_AutoLine_Click(object sender, EventArgs e)
        {
            mi_AutoLine.Checked = !mi_AutoLine.Checked;
            textBox1.WordWrap = mi_AutoLine.Checked;
        }

        //字体
        private void mi_FontSetup_Click(object sender, EventArgs e)
        {

            fontDialog1.Font = textBox1.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }

        }

        //撤消
        private void mi_Edit_Cancel_Click(object sender, EventArgs e)
        {
            //if(textBox1.CanUndo)
            textBox1.Undo();
        }

        //复制
        private void mi_Edit_Copy_Click(object sender, EventArgs e)
        {
            textBox1.Copy();

            //if (textBox1.SelectedText != "")
            //    Clipboard.SetDataObject(textBox1.SelectedText);
        }

        //剪切
        private void mi_Edit_Cut_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        //粘贴
        private void mi_Edit_Paste_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        //状态栏
        private void mi_StatusStrip_Click(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).Checked=!((ToolStripMenuItem)sender).Checked;
            this.statusStrip1.Visible = ((ToolStripMenuItem)sender).Checked;
        }

        //关于记事本
        private void mi_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("琴琴记事本——一个用C#编写的记事小工具！Powered by 夜幕之琴\n\t\t2019-04--25宇宙", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //(new AboutBox()).ShowDialog();
            
        }


        //页面设置
        private void mi_PageSetup_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDialog1.Document.DefaultPageSettings = pageSetupDialog1.Document.DefaultPageSettings;
            }
        }

        //打印
        private void mi_Print_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                //printDialog1.Document.ToString() = textBox1.Text;
                printDialog1.Document.Print();
            }
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(textBox1, new Point(e.X, e.Y));
            }
            SetRowColInfo();
        }

        

        private void mi_Edit_DropDownOpened(object sender, EventArgs e)
        {
            mi_Edit_Cancel.Enabled = textBox1.CanUndo;

            mi_Edit_Copy.Enabled = textBox1.SelectionLength > 0;
            mi_Edit_Cut.Enabled = mi_Edit_Copy.Enabled;

            mi_Edit_Paste.Enabled = Clipboard.ContainsText();
            mi_Edit_Paste.Enabled = mi_Edit_Paste.Enabled;
        }


        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            mi_Edit_DropDownOpened(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _IsSaved = false;
        }
    }
}
