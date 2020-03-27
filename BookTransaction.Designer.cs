namespace LMS
{
    partial class BookTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTransaction));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issue_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_bid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_mname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_return = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_issueDate = new System.Windows.Forms.TextBox();
            this.button_searchIssue = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_issueNo = new System.Windows.Forms.TextBox();
            this.button_search2 = new System.Windows.Forms.Button();
            this.button_search1 = new System.Windows.Forms.Button();
            this.comboBox_transType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_issue = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.menuToolStripMenuItem.Image = global::LMS.Properties.Resources.Custom_Icon_Design_Flatastic_1_Back;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.menuToolStripMenuItem.Text = "&Back";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.book_title,
            this.issue_date,
            this.return_date});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 4;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(807, 176);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // book_id
            // 
            this.book_id.DataPropertyName = "book_id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.book_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.book_id.HeaderText = "   Book ID";
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            // 
            // book_title
            // 
            this.book_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.book_title.DataPropertyName = "book_title";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            this.book_title.DefaultCellStyle = dataGridViewCellStyle3;
            this.book_title.HeaderText = "Title";
            this.book_title.Name = "book_title";
            this.book_title.ReadOnly = true;
            // 
            // issue_date
            // 
            this.issue_date.DataPropertyName = "issue_date";
            this.issue_date.HeaderText = "   Issue Date";
            this.issue_date.Name = "issue_date";
            this.issue_date.ReadOnly = true;
            this.issue_date.Width = 120;
            // 
            // return_date
            // 
            this.return_date.DataPropertyName = "return_date";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.return_date.DefaultCellStyle = dataGridViewCellStyle4;
            this.return_date.HeaderText = " Return Date";
            this.return_date.Name = "return_date";
            this.return_date.ReadOnly = true;
            this.return_date.Width = 120;
            // 
            // textBox_bid
            // 
            this.textBox_bid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_bid.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_bid.Location = new System.Drawing.Point(146, 125);
            this.textBox_bid.Name = "textBox_bid";
            this.textBox_bid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_bid.Size = new System.Drawing.Size(113, 28);
            this.textBox_bid.TabIndex = 6;
            this.textBox_bid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Book ID";
            // 
            // textBox_title
            // 
            this.textBox_title.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_title.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_title.Location = new System.Drawing.Point(419, 125);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.ReadOnly = true;
            this.textBox_title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_title.Size = new System.Drawing.Size(335, 28);
            this.textBox_title.TabIndex = 30;
            this.textBox_title.TabStop = false;
            this.textBox_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Title";
            // 
            // textBox_mname
            // 
            this.textBox_mname.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_mname.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mname.Location = new System.Drawing.Point(419, 72);
            this.textBox_mname.Name = "textBox_mname";
            this.textBox_mname.ReadOnly = true;
            this.textBox_mname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_mname.Size = new System.Drawing.Size(335, 28);
            this.textBox_mname.TabIndex = 35;
            this.textBox_mname.TabStop = false;
            this.textBox_mname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name";
            // 
            // textBox_mid
            // 
            this.textBox_mid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_mid.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mid.Location = new System.Drawing.Point(146, 72);
            this.textBox_mid.Name = "textBox_mid";
            this.textBox_mid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_mid.Size = new System.Drawing.Size(113, 28);
            this.textBox_mid.TabIndex = 4;
            this.textBox_mid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Member ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Issue Date";
            // 
            // dateTimePicker_return
            // 
            this.dateTimePicker_return.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_return.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_return.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_return.Location = new System.Drawing.Point(480, 177);
            this.dateTimePicker_return.Name = "dateTimePicker_return";
            this.dateTimePicker_return.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker_return.Size = new System.Drawing.Size(162, 28);
            this.dateTimePicker_return.TabIndex = 9;
            this.dateTimePicker_return.Value = new System.DateTime(2016, 5, 30, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "Return Date";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.textBox_issueDate);
            this.groupBox1.Controls.Add(this.button_searchIssue);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_title);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.textBox_issueNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker_return);
            this.groupBox1.Controls.Add(this.textBox_bid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_search2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_mname);
            this.groupBox1.Controls.Add(this.textBox_mid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_search1);
            this.groupBox1.Location = new System.Drawing.Point(0, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 223);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            // 
            // textBox_issueDate
            // 
            this.textBox_issueDate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_issueDate.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_issueDate.Location = new System.Drawing.Point(146, 176);
            this.textBox_issueDate.Name = "textBox_issueDate";
            this.textBox_issueDate.ReadOnly = true;
            this.textBox_issueDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_issueDate.Size = new System.Drawing.Size(191, 28);
            this.textBox_issueDate.TabIndex = 8;
            this.textBox_issueDate.TabStop = false;
            this.textBox_issueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_searchIssue
            // 
            this.button_searchIssue.Image = global::LMS.Properties.Resources.Zoom_icon;
            this.button_searchIssue.Location = new System.Drawing.Point(265, 17);
            this.button_searchIssue.Name = "button_searchIssue";
            this.button_searchIssue.Size = new System.Drawing.Size(72, 30);
            this.button_searchIssue.TabIndex = 3;
            this.button_searchIssue.UseVisualStyleBackColor = true;
            this.button_searchIssue.Visible = false;
            this.button_searchIssue.Click += new System.EventHandler(this.button_searchIssue_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "Issue No";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Image = global::LMS.Properties.Resources.add_icon;
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_add.Location = new System.Drawing.Point(671, 172);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(83, 35);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "ADD";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            this.button_add.Enter += new System.EventHandler(this.button_add_Enter);
            this.button_add.Leave += new System.EventHandler(this.button_add_Leave);
            this.button_add.MouseLeave += new System.EventHandler(this.button_add_MouseLeave);
            this.button_add.MouseHover += new System.EventHandler(this.button_add_MouseHover);
            // 
            // textBox_issueNo
            // 
            this.textBox_issueNo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_issueNo.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_issueNo.Location = new System.Drawing.Point(146, 19);
            this.textBox_issueNo.Name = "textBox_issueNo";
            this.textBox_issueNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_issueNo.Size = new System.Drawing.Size(113, 28);
            this.textBox_issueNo.TabIndex = 2;
            this.textBox_issueNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_search2
            // 
            this.button_search2.Image = global::LMS.Properties.Resources.Zoom_icon;
            this.button_search2.Location = new System.Drawing.Point(265, 123);
            this.button_search2.Name = "button_search2";
            this.button_search2.Size = new System.Drawing.Size(72, 30);
            this.button_search2.TabIndex = 7;
            this.button_search2.UseVisualStyleBackColor = true;
            this.button_search2.Click += new System.EventHandler(this.button_search2_Click);
            // 
            // button_search1
            // 
            this.button_search1.Image = global::LMS.Properties.Resources.Zoom_icon;
            this.button_search1.Location = new System.Drawing.Point(265, 70);
            this.button_search1.Name = "button_search1";
            this.button_search1.Size = new System.Drawing.Size(72, 30);
            this.button_search1.TabIndex = 5;
            this.button_search1.UseVisualStyleBackColor = true;
            this.button_search1.Click += new System.EventHandler(this.button_search1_Click);
            // 
            // comboBox_transType
            // 
            this.comboBox_transType.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox_transType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_transType.Font = new System.Drawing.Font("Century Schoolbook", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_transType.FormattingEnabled = true;
            this.comboBox_transType.ItemHeight = 21;
            this.comboBox_transType.Items.AddRange(new object[] {
            "Issue Book",
            "Return Book"});
            this.comboBox_transType.Location = new System.Drawing.Point(211, 98);
            this.comboBox_transType.Name = "comboBox_transType";
            this.comboBox_transType.Size = new System.Drawing.Size(151, 29);
            this.comboBox_transType.TabIndex = 1;
            this.comboBox_transType.DropDownClosed += new System.EventHandler(this.comboBox_transType_DropDownClosed);
            this.comboBox_transType.SelectedValueChanged += new System.EventHandler(this.comboBox_transType_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(592, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "Logged In as :";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(680, 7);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 16);
            this.label_name.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(49, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Book Issue/Return";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.Gainsboro;
            this.label_date.Location = new System.Drawing.Point(674, 102);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(0, 19);
            this.label_date.TabIndex = 48;
            this.label_date.Visible = false;
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_reset.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Image = global::LMS.Properties.Resources.Button_Refresh_icon;
            this.button_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_reset.Location = new System.Drawing.Point(546, 569);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(104, 35);
            this.button_reset.TabIndex = 11;
            this.button_reset.Text = "RESET";
            this.button_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_issue
            // 
            this.button_issue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_issue.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_issue.Image = global::LMS.Properties.Resources.Notary_icon__1_;
            this.button_issue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_issue.Location = new System.Drawing.Point(671, 569);
            this.button_issue.Name = "button_issue";
            this.button_issue.Size = new System.Drawing.Size(104, 35);
            this.button_issue.TabIndex = 12;
            this.button_issue.Text = "ISSUE";
            this.button_issue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_issue.UseVisualStyleBackColor = false;
            this.button_issue.Click += new System.EventHandler(this.button_issue_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 52);
            this.panel1.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(68, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 28);
            this.label10.TabIndex = 2;
            this.label10.Text = "Book Transaction";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.Notary_icon__1_;
            this.pictureBox1.Location = new System.Drawing.Point(28, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BookTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(807, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_transType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_issue);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BookTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Transaction";
            this.Load += new System.EventHandler(this.BookTransaction_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BookTransaction_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_issue;
        private System.Windows.Forms.Button button_search2;
        private System.Windows.Forms.TextBox textBox_bid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_mname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search1;
        private System.Windows.Forms.TextBox textBox_mid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_return;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_issueNo;
        private System.Windows.Forms.ComboBox comboBox_transType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_searchIssue;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.TextBox textBox_issueDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn issue_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn return_date;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}