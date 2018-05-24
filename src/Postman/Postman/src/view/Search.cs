using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postman.src.view
{
    public partial class Search : Form
    {
        private RichTextBox _RichTextBox;
        public Search(RichTextBox rtb)
        {
            InitializeComponent();
            this._RichTextBox = rtb;
        }
        int index = -1;
        private void submit_Click(object sender, EventArgs e)
        {
            string con = content.Text.Trim();
            if (con == "") 
            {
                MessageBox.Show("请输入内容！");
                return;
            }
            index = _RichTextBox.Text.IndexOf(con, index+1);
            if (index > 0)
            {
                _RichTextBox.Focus();
                _RichTextBox.Select(index, con.Length);
                _RichTextBox.SelectionBackColor = Color.Blue;
                _RichTextBox.ScrollToCaret();
            }
            else
            {
                index = 0;
            }
        }

        private void content_TextChanged(object sender, EventArgs e)
        {
            index = -1;
        }
    }
}
