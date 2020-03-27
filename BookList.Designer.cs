namespace LMS
{
    partial class BookList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookList));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_pub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.comboBox_item = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.radioButton_category = new System.Windows.Forms.RadioButton();
            this.radioButton_title = new System.Windows.Forms.RadioButton();
            this.radioButton_author = new System.Windows.Forms.RadioButton();
            this.radioButton_id = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Image = global::LMS.Properties.Resources.Custom_Icon_Design_Flatastic_1_Back;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(76, 25);
            this.fileToolStripMenuItem.Text = "&Back";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1085, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logged In as :";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label_name.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(1174, 8);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(16, 16);
            this.label_name.TabIndex = 3;
            this.label_name.Text = "d";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.book_title,
            this.author1,
            this.author2,
            this.book_pub,
            this.book_category,
            this.book_language,
            this.avail});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(1354, 526);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // book_id
            // 
            this.book_id.DataPropertyName = "book_id";
            this.book_id.HeaderText = "Book ID";
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // book_title
            // 
            this.book_title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.book_title.DataPropertyName = "book_title";
            this.book_title.HeaderText = "Title";
            this.book_title.Name = "book_title";
            this.book_title.ReadOnly = true;
            this.book_title.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // author1
            // 
            this.author1.DataPropertyName = "author1";
            this.author1.HeaderText = "1st Author";
            this.author1.Name = "author1";
            this.author1.ReadOnly = true;
            this.author1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.author1.Width = 200;
            // 
            // author2
            // 
            this.author2.DataPropertyName = "author2";
            this.author2.HeaderText = "2nd Author";
            this.author2.Name = "author2";
            this.author2.ReadOnly = true;
            this.author2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.author2.Width = 200;
            // 
            // book_pub
            // 
            this.book_pub.DataPropertyName = "book_pub";
            this.book_pub.FillWeight = 200F;
            this.book_pub.HeaderText = "Publisher";
            this.book_pub.Name = "book_pub";
            this.book_pub.ReadOnly = true;
            this.book_pub.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.book_pub.Width = 180;
            // 
            // book_category
            // 
            this.book_category.DataPropertyName = "book_category";
            this.book_category.HeaderText = "Category";
            this.book_category.Name = "book_category";
            this.book_category.ReadOnly = true;
            this.book_category.Width = 120;
            // 
            // book_language
            // 
            this.book_language.DataPropertyName = "book_language";
            this.book_language.HeaderText = "Language";
            this.book_language.Name = "book_language";
            this.book_language.ReadOnly = true;
            // 
            // avail
            // 
            this.avail.DataPropertyName = "avail";
            this.avail.HeaderText = "Availabilty";
            this.avail.Name = "avail";
            this.avail.ReadOnly = true;
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_all.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.radioButton_all.Location = new System.Drawing.Point(379, 26);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(46, 20);
            this.radioButton_all.TabIndex = 7;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "All";
            this.radioButton_all.UseVisualStyleBackColor = true;
            this.radioButton_all.CheckedChanged += new System.EventHandler(this.radioButton_all_CheckedChanged);
            // 
            // comboBox_item
            // 
            this.comboBox_item.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_item.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.comboBox_item.FormattingEnabled = true;
            this.comboBox_item.Items.AddRange(new object[] {
            "Art",
            "Autobiography",
            "Anthology",
            "Action & Adventure",
            "Biography",
            "Comic",
            "Cookbook",
            "Children\'s",
            "Drama",
            "Dictionary",
            "Diary",
            "Encyclopedia",
            "Fantasy",
            "Guide",
            "History",
            "Health",
            "Horror",
            "Journal",
            "Mathematics",
            "Mystery",
            "Poetry",
            "Religion",
            "Romance",
            "Science Fiction",
            "Satire",
            "Science",
            "Series",
            "Trilogy",
            "Travel"});
            this.comboBox_item.Location = new System.Drawing.Point(512, 23);
            this.comboBox_item.Name = "comboBox_item";
            this.comboBox_item.Size = new System.Drawing.Size(228, 24);
            this.comboBox_item.TabIndex = 6;
            this.comboBox_item.Visible = false;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Transparent;
            this.button_search.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(809, 20);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(97, 30);
            this.button_search.TabIndex = 5;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            this.button_search.Enter += new System.EventHandler(this.button_search_Enter);
            this.button_search.Leave += new System.EventHandler(this.button_search_Leave);
            this.button_search.MouseLeave += new System.EventHandler(this.button_search_MouseLeave);
            this.button_search.MouseHover += new System.EventHandler(this.button_search_MouseHover);
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.textBox_search.Location = new System.Drawing.Point(467, 24);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(313, 23);
            this.textBox_search.TabIndex = 4;
            // 
            // radioButton_category
            // 
            this.radioButton_category.AutoSize = true;
            this.radioButton_category.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.radioButton_category.Location = new System.Drawing.Point(244, 44);
            this.radioButton_category.Name = "radioButton_category";
            this.radioButton_category.Size = new System.Drawing.Size(87, 20);
            this.radioButton_category.TabIndex = 3;
            this.radioButton_category.TabStop = true;
            this.radioButton_category.Text = "Category";
            this.radioButton_category.UseVisualStyleBackColor = true;
            this.radioButton_category.CheckedChanged += new System.EventHandler(this.radioButton_category_CheckedChanged);
            // 
            // radioButton_title
            // 
            this.radioButton_title.AutoSize = true;
            this.radioButton_title.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.radioButton_title.Location = new System.Drawing.Point(244, 11);
            this.radioButton_title.Name = "radioButton_title";
            this.radioButton_title.Size = new System.Drawing.Size(96, 20);
            this.radioButton_title.TabIndex = 2;
            this.radioButton_title.TabStop = true;
            this.radioButton_title.Text = "Book Title";
            this.radioButton_title.UseVisualStyleBackColor = true;
            this.radioButton_title.CheckedChanged += new System.EventHandler(this.radioButton_title_CheckedChanged);
            // 
            // radioButton_author
            // 
            this.radioButton_author.AutoSize = true;
            this.radioButton_author.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.radioButton_author.Location = new System.Drawing.Point(130, 44);
            this.radioButton_author.Name = "radioButton_author";
            this.radioButton_author.Size = new System.Drawing.Size(75, 20);
            this.radioButton_author.TabIndex = 1;
            this.radioButton_author.TabStop = true;
            this.radioButton_author.Text = "Author";
            this.radioButton_author.UseVisualStyleBackColor = true;
            this.radioButton_author.CheckedChanged += new System.EventHandler(this.radioButton_author_CheckedChanged);
            // 
            // radioButton_id
            // 
            this.radioButton_id.AutoSize = true;
            this.radioButton_id.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.radioButton_id.Location = new System.Drawing.Point(130, 11);
            this.radioButton_id.Name = "radioButton_id";
            this.radioButton_id.Size = new System.Drawing.Size(80, 20);
            this.radioButton_id.TabIndex = 0;
            this.radioButton_id.TabStop = true;
            this.radioButton_id.Text = "Book ID";
            this.radioButton_id.UseVisualStyleBackColor = true;
            this.radioButton_id.CheckedChanged += new System.EventHandler(this.radioButton_id_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 52);
            this.panel1.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(85, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 32);
            this.label12.TabIndex = 4;
            this.label12.Text = "Book List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.radioButton_all);
            this.panel2.Controls.Add(this.radioButton_category);
            this.panel2.Controls.Add(this.comboBox_item);
            this.panel2.Controls.Add(this.radioButton_id);
            this.panel2.Controls.Add(this.button_search);
            this.panel2.Controls.Add(this.radioButton_author);
            this.panel2.Controls.Add(this.textBox_search);
            this.panel2.Controls.Add(this.radioButton_title);
            this.panel2.Location = new System.Drawing.Point(263, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1091, 74);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 74);
            this.panel3.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label13.Location = new System.Drawing.Point(93, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 28);
            this.label13.TabIndex = 4;
            this.label13.Text = "Search by";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.Itzikgur_My_Seven_Books_2;
            this.pictureBox1.Location = new System.Drawing.Point(36, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "BookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book List";
            this.Load += new System.EventHandler(this.BookList_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ComboBox comboBox_item;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.RadioButton radioButton_category;
        private System.Windows.Forms.RadioButton radioButton_title;
        private System.Windows.Forms.RadioButton radioButton_author;
        private System.Windows.Forms.RadioButton radioButton_id;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author1;
        private System.Windows.Forms.DataGridViewTextBoxColumn author2;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_pub;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_language;
        private System.Windows.Forms.DataGridViewTextBoxColumn avail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}