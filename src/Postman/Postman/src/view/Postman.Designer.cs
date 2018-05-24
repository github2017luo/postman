namespace Postman
{
    partial class Postman
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postman));
            this.mainTLP = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.newPost = new System.Windows.Forms.ToolStripMenuItem();
            this.setting = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.group = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.RichTextBox();
            this.descRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bookmarkName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookmarkPanel = new System.Windows.Forms.Panel();
            this.bookmarkTreeView = new System.Windows.Forms.TreeView();
            this.bookmarkContentMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePara = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addPara = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.parameter = new System.Windows.Forms.DataGridView();
            this.key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submit = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.methodCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchResult = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTLP.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.bookmarkPanel.SuspendLayout();
            this.bookmarkContentMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parameter)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTLP
            // 
            this.mainTLP.ColumnCount = 1;
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTLP.Controls.Add(this.mainMenuStrip, 0, 0);
            this.mainTLP.Controls.Add(this.mainPanel, 0, 1);
            this.mainTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTLP.Location = new System.Drawing.Point(0, 0);
            this.mainTLP.Margin = new System.Windows.Forms.Padding(0);
            this.mainTLP.Name = "mainTLP";
            this.mainTLP.RowCount = 2;
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.mainTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTLP.Size = new System.Drawing.Size(742, 449);
            this.mainTLP.TabIndex = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file,
            this.bookmark,
            this.about});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.mainMenuStrip.Size = new System.Drawing.Size(742, 27);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "菜单";
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPost,
            this.searchResult,
            this.setting});
            this.file.ForeColor = System.Drawing.Color.Black;
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(44, 21);
            this.file.Text = "文件";
            // 
            // newPost
            // 
            this.newPost.Name = "newPost";
            this.newPost.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newPost.Size = new System.Drawing.Size(152, 22);
            this.newPost.Text = "新建";
            this.newPost.Click += new System.EventHandler(this.newPost_Click);
            // 
            // setting
            // 
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(152, 22);
            this.setting.Text = "设置";
            // 
            // bookmark
            // 
            this.bookmark.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveBookmark});
            this.bookmark.Name = "bookmark";
            this.bookmark.Size = new System.Drawing.Size(44, 21);
            this.bookmark.Text = "书签";
            // 
            // saveBookmark
            // 
            this.saveBookmark.Name = "saveBookmark";
            this.saveBookmark.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveBookmark.Size = new System.Drawing.Size(168, 22);
            this.saveBookmark.Text = "保存书签";
            this.saveBookmark.Click += new System.EventHandler(this.saveBookmark_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(44, 21);
            this.about.Text = "关于";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.group);
            this.mainPanel.Controls.Add(this.label7);
            this.mainPanel.Controls.Add(this.result);
            this.mainPanel.Controls.Add(this.descRichTextBox);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.bookmarkName);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.bookmarkPanel);
            this.mainPanel.Controls.Add(this.deletePara);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.addPara);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.parameter);
            this.mainPanel.Controls.Add(this.submit);
            this.mainPanel.Controls.Add(this.urlTextBox);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.methodCombobox);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 29);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(742, 420);
            this.mainPanel.TabIndex = 1;
            // 
            // group
            // 
            this.group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.group.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.group.ForeColor = System.Drawing.Color.White;
            this.group.Location = new System.Drawing.Point(214, 72);
            this.group.Multiline = true;
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(106, 21);
            this.group.TabIndex = 18;
            this.group.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(180, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "分组";
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result.BackColor = System.Drawing.Color.Black;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.result.Location = new System.Drawing.Point(214, 241);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(417, 154);
            this.result.TabIndex = 16;
            this.result.Text = "";
            // 
            // descRichTextBox
            // 
            this.descRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.descRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descRichTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.descRichTextBox.ForeColor = System.Drawing.Color.White;
            this.descRichTextBox.Location = new System.Drawing.Point(365, 45);
            this.descRichTextBox.Name = "descRichTextBox";
            this.descRichTextBox.Size = new System.Drawing.Size(266, 48);
            this.descRichTextBox.TabIndex = 15;
            this.descRichTextBox.Text = "";
            this.descRichTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(331, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "描述";
            // 
            // bookmarkName
            // 
            this.bookmarkName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.bookmarkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookmarkName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookmarkName.ForeColor = System.Drawing.Color.White;
            this.bookmarkName.Location = new System.Drawing.Point(214, 45);
            this.bookmarkName.Multiline = true;
            this.bookmarkName.Name = "bookmarkName";
            this.bookmarkName.Size = new System.Drawing.Size(106, 21);
            this.bookmarkName.TabIndex = 13;
            this.bookmarkName.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(180, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "名称";
            // 
            // bookmarkPanel
            // 
            this.bookmarkPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bookmarkPanel.Controls.Add(this.bookmarkTreeView);
            this.bookmarkPanel.Location = new System.Drawing.Point(12, 4);
            this.bookmarkPanel.Name = "bookmarkPanel";
            this.bookmarkPanel.Size = new System.Drawing.Size(162, 391);
            this.bookmarkPanel.TabIndex = 11;
            // 
            // bookmarkTreeView
            // 
            this.bookmarkTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.bookmarkTreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookmarkTreeView.ContextMenuStrip = this.bookmarkContentMenuStrip;
            this.bookmarkTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarkTreeView.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bookmarkTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookmarkTreeView.Location = new System.Drawing.Point(0, 0);
            this.bookmarkTreeView.Margin = new System.Windows.Forms.Padding(0);
            this.bookmarkTreeView.Name = "bookmarkTreeView";
            this.bookmarkTreeView.Size = new System.Drawing.Size(162, 391);
            this.bookmarkTreeView.TabIndex = 0;
            this.bookmarkTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.bookmarkTreeView_NodeMouseDoubleClick);
            // 
            // bookmarkContentMenuStrip
            // 
            this.bookmarkContentMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteBookmark});
            this.bookmarkContentMenuStrip.Name = "bookmarkContentMenuStrip";
            this.bookmarkContentMenuStrip.Size = new System.Drawing.Size(101, 26);
            // 
            // deleteBookmark
            // 
            this.deleteBookmark.Name = "deleteBookmark";
            this.deleteBookmark.Size = new System.Drawing.Size(100, 22);
            this.deleteBookmark.Text = "删除";
            this.deleteBookmark.Click += new System.EventHandler(this.deleteBookmark_Click);
            // 
            // deletePara
            // 
            this.deletePara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.deletePara.FlatAppearance.BorderSize = 0;
            this.deletePara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePara.Font = new System.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
            this.deletePara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.deletePara.Location = new System.Drawing.Point(651, 147);
            this.deletePara.Name = "deletePara";
            this.deletePara.Size = new System.Drawing.Size(75, 23);
            this.deletePara.TabIndex = 10;
            this.deletePara.Text = "delete";
            this.deletePara.UseVisualStyleBackColor = false;
            this.deletePara.Click += new System.EventHandler(this.deletePara_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(180, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "结果";
            // 
            // addPara
            // 
            this.addPara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addPara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.addPara.FlatAppearance.BorderSize = 0;
            this.addPara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPara.Font = new System.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.addPara.Location = new System.Drawing.Point(651, 106);
            this.addPara.Name = "addPara";
            this.addPara.Size = new System.Drawing.Size(75, 23);
            this.addPara.TabIndex = 7;
            this.addPara.Text = "add";
            this.addPara.UseVisualStyleBackColor = false;
            this.addPara.Click += new System.EventHandler(this.addPara_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(180, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "参数";
            // 
            // parameter
            // 
            this.parameter.AllowUserToAddRows = false;
            this.parameter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parameter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.parameter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.parameter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.parameter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.parameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parameter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.key,
            this.value});
            this.parameter.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.parameter.Location = new System.Drawing.Point(214, 109);
            this.parameter.MultiSelect = false;
            this.parameter.Name = "parameter";
            this.parameter.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.parameter.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.parameter.RowTemplate.Height = 23;
            this.parameter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.parameter.Size = new System.Drawing.Size(417, 106);
            this.parameter.TabIndex = 5;
            this.parameter.RowHeightChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.parameter_RowHeightChanged);
            // 
            // key
            // 
            this.key.HeaderText = "key";
            this.key.Name = "key";
            // 
            // value
            // 
            this.value.HeaderText = "value";
            this.value.Name = "value";
            // 
            // submit
            // 
            this.submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(123)))), ((int)(((byte)(237)))));
            this.submit.FlatAppearance.BorderSize = 0;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(649, 15);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(88, 31);
            this.submit.TabIndex = 4;
            this.submit.Text = "send";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.urlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urlTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.urlTextBox.ForeColor = System.Drawing.Color.White;
            this.urlTextBox.Location = new System.Drawing.Point(365, 15);
            this.urlTextBox.Multiline = true;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(266, 21);
            this.urlTextBox.TabIndex = 3;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(293, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "URL";
            // 
            // methodCombobox
            // 
            this.methodCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.methodCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.methodCombobox.ForeColor = System.Drawing.Color.White;
            this.methodCombobox.FormattingEnabled = true;
            this.methodCombobox.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.methodCombobox.Location = new System.Drawing.Point(214, 12);
            this.methodCombobox.Name = "methodCombobox";
            this.methodCombobox.Size = new System.Drawing.Size(73, 24);
            this.methodCombobox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "方法";
            // 
            // searchResult
            // 
            this.searchResult.Name = "searchResult";
            this.searchResult.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.searchResult.Size = new System.Drawing.Size(152, 22);
            this.searchResult.Text = "搜索";
            this.searchResult.Click += new System.EventHandler(this.searchResult_Click);
            // 
            // Postman
            // 
            this.AcceptButton = this.submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(742, 449);
            this.Controls.Add(this.mainTLP);
            this.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Postman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Postman_Load);
            this.mainTLP.ResumeLayout(false);
            this.mainTLP.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.bookmarkPanel.ResumeLayout(false);
            this.bookmarkContentMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parameter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTLP;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ComboBox methodCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button addPara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView parameter;
        private System.Windows.Forms.DataGridViewTextBoxColumn key;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deletePara;
        private System.Windows.Forms.ToolStripMenuItem setting;
        private System.Windows.Forms.ToolStripMenuItem bookmark;
        private System.Windows.Forms.Panel bookmarkPanel;
        private System.Windows.Forms.TreeView bookmarkTreeView;
        private System.Windows.Forms.RichTextBox descRichTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bookmarkName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip bookmarkContentMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteBookmark;
        private System.Windows.Forms.ToolStripMenuItem newPost;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem saveBookmark;
        private System.Windows.Forms.TextBox group;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem searchResult;
    }
}

