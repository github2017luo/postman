using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.IO;
using Postman.src.model;
using Postman.src.json;
using System.Text.RegularExpressions;
using Postman.src.view;

namespace Postman
{
    public partial class Postman : Form
    {
        private Bookmark _CurrentBookmark = null;
        public Postman()
        {
            InitializeComponent();
        }

        private void addPara_Click(object sender, EventArgs e)
        {
            parameter.Rows.Add();
        }

        private void deletePara_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr=parameter.CurrentRow;
            if (dr != null)
            {
                parameter.Rows.Remove(dr);
            }
        }

        private void Postman_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            if (methodCombobox.Items.Count > 0)
                methodCombobox.SelectedIndex = 0;
            List<Bookmark> bookmarks = Bookmark.getBookmarks();
            bookmarkTreeView.Nodes.Clear();
            foreach (var i in bookmarks)
            {
                string gro = i.group;
                string id = i.id;
                string name = i.name;
                int index = bookmarkTreeView.Nodes.IndexOfKey(gro);
                TreeNode tn = null;
                if (index <0)
                {
                    tn = new TreeNode(gro);
                    tn.Name = gro;
                    
                    index = bookmarkTreeView.Nodes.Add(tn);
                }
                tn = new TreeNode(name);
                tn.Name = id;
                bookmarkTreeView.Nodes[index].Nodes.Add(tn);
            }
            bookmarkTreeView.ExpandAll();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                string url = urlTextBox.Text.Trim();
                if (url == "") throw new Exception("url cannot be empty.");
                Dictionary<String, String> para = new Dictionary<String, String>();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < parameter.Rows.Count; i++)
                {
                    DataGridViewRow dr = parameter.Rows[i];
                    sb.Append(dr.Cells[0].Value.ToString() + "=" + dr.Cells[1].Value.ToString() + "&");
                }
                sb.Append("TCEHSETN=2014302030139");
                sb.Replace("&TCEHSETN=2014302030139", "");
                string method = methodCombobox.SelectedItem.ToString();
                string ret = string.Empty;

                ret = NetResourceGetter.getResource(url,sb.ToString(),method);
                result.Text = JsonFormat.formatJson(ret);
                //Regex re = new Regex("([\"A-Za-z\"].*?)");
                //Match mcs = re.Match(result.Text);
                //MessageBox.Show(mcs.Value);
                //result.Select(mcs.Index, mcs.Index + mcs.Length);

                //result.SelectionColor = Color.Red;
                //while ((mcs = mcs.NextMatch()).Length!=0)
                //{
                //    //MessageBox.Show(mcs.Value);
                //    result.Select(mcs.Index, mcs.Index + mcs.Length);
                //    result.SelectionColor = Color.Red;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBookmark_Click(object sender, EventArgs e)
        {
            try
            {
                string url = urlTextBox.Text.ToString();
                if (url == "") throw new Exception("url cannot be empty.");
                string name = bookmarkName.Text.Trim();
                if (name == "") throw new Exception("bookmark name cannot be empty.");
                string desc = descRichTextBox.Text.Trim();
                string gro = group.Text.Trim();
                if (gro == "") throw new Exception("group name cannot be empty.");
                Dictionary<string, string> para = new Dictionary<string, string>();
                for (int i = 0; i < parameter.Rows.Count; i++)
                {
                    DataGridViewRow dr = parameter.Rows[i];
                    para.Add(dr.Cells[0].Value.ToString(), dr.Cells[1].Value.ToString());
                }
                if (_CurrentBookmark != null)
                {
                    _CurrentBookmark.name = name;
                    _CurrentBookmark.url = url;
                    _CurrentBookmark.desc = desc;
                    _CurrentBookmark.parameter = para;
                    _CurrentBookmark.group = gro;
                    int res=_CurrentBookmark.update();
                    if (res > 0)
                    {
                        this.Text = "Postman";
                        this.BackColor = Color.FromArgb(224, 224, 224);
                    }
                    //MessageBox.Show("保存结果:" + (res > 0), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _CurrentBookmark = Bookmark.getBookmark(Bookmark.addBookmark(gro, name, url, desc, para));
                    if (_CurrentBookmark != null) 
                    {
                        this.Text = "Postman";
                        this.BackColor = Color.FromArgb(224, 224, 224);
                    }
                    //MessageBox.Show("保存结果:" + (_CurrentBookmark!=null), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bookmarkTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                TreeNode ctn = bookmarkTreeView.SelectedNode;
                if (ctn != null&&ctn.Level>0)
                {
                    _CurrentBookmark = Bookmark.getBookmark(ctn.Name);
                    if (_CurrentBookmark == null) throw new Exception("bookmark cannot be found!");
                    urlTextBox.Text = _CurrentBookmark.url;
                    bookmarkName.Text = _CurrentBookmark.name;
                    descRichTextBox.Text = _CurrentBookmark.desc;
                    group.Text = _CurrentBookmark.group;
                    parameter.Rows.Clear();
                    foreach (var i in _CurrentBookmark.parameter)
                    {
                        parameter.Rows.Add();
                        parameter.Rows[parameter.Rows.Count - 1].Cells[0].Value = i.Key;
                        parameter.Rows[parameter.Rows.Count - 1].Cells[1].Value = i.Value;
                    }
                    this.BackColor = Color.FromArgb(224, 224, 224);
                    this.Text = "Postman";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteBookmark_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode ctn = bookmarkTreeView.SelectedNode;
                if (ctn != null&&ctn.Level>0)
                {
                    MessageBox.Show("删除:" + (Bookmark.delete(ctn.Name) >0), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    init();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newPost_Click(object sender, EventArgs e)
        {
            _CurrentBookmark = null;
            this.Text = "Postman-*";
            this.BackColor = Color.Red;
            //urlTextBox.Text = "";
            //descRichTextBox.Text = "";
            //bookmarkName.Text = "";
            //result.Text = "";
            //group.Text = "";
            //parameter.Rows.Clear();
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("组织: ITL\n网址: http://itl.neepu.eu.cn\n作者: CHEN.Tsang\n邮箱: do.ze@foxmail.com\n\nCopyrights All Reserved.2017","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = "Postman-*";
            this.BackColor = Color.Red;
        }

        private void descRichTextBox_TextChanged(object sender, EventArgs e)
        {
            this.Text = "Postman-*";
            this.BackColor = Color.Red;
        }

        private void parameter_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            this.Text = "Postman-*";
            this.BackColor = Color.Red;
        }

        private void searchResult_Click(object sender, EventArgs e)
        {
            result.SelectAll();
            result.SelectionBackColor = Color.Black;
            result.Select(0,0);
            new Search(result).ShowDialog();
        }
    }
}
