namespace LMS
{
    partial class Book_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Management));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_ISBN = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_author1 = new System.Windows.Forms.TextBox();
            this.textBox_author2 = new System.Windows.Forms.TextBox();
            this.textBox_pub = new System.Windows.Forms.TextBox();
            this.comboBox_category = new System.Windows.Forms.ComboBox();
            this.textBox_page = new System.Windows.Forms.TextBox();
            this.textBox_qty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(779, 29);
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
            this.toolStripSeparator1.Size = new System.Drawing.Size(57, 6);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logged In as :";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(625, 8);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 16);
            this.label_name.TabIndex = 3;
            // 
            // textBox_id
            // 
            this.textBox_id.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_id.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(167, 34);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_id.Size = new System.Drawing.Size(92, 27);
            this.textBox_id.TabIndex = 4;
            this.textBox_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_ISBN
            // 
            this.textBox_ISBN.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_ISBN.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ISBN.Location = new System.Drawing.Point(483, 34);
            this.textBox_ISBN.Name = "textBox_ISBN";
            this.textBox_ISBN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_ISBN.Size = new System.Drawing.Size(222, 27);
            this.textBox_ISBN.TabIndex = 5;
            this.textBox_ISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_title
            // 
            this.textBox_title.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_title.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_title.Location = new System.Drawing.Point(167, 88);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_title.Size = new System.Drawing.Size(538, 27);
            this.textBox_title.TabIndex = 6;
            this.textBox_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_author1
            // 
            this.textBox_author1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_author1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_author1.Location = new System.Drawing.Point(167, 140);
            this.textBox_author1.Name = "textBox_author1";
            this.textBox_author1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_author1.Size = new System.Drawing.Size(209, 27);
            this.textBox_author1.TabIndex = 7;
            this.textBox_author1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_author2
            // 
            this.textBox_author2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_author2.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_author2.Location = new System.Drawing.Point(505, 140);
            this.textBox_author2.Name = "textBox_author2";
            this.textBox_author2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_author2.Size = new System.Drawing.Size(200, 27);
            this.textBox_author2.TabIndex = 8;
            this.textBox_author2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_pub
            // 
            this.textBox_pub.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_pub.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pub.Location = new System.Drawing.Point(167, 193);
            this.textBox_pub.Name = "textBox_pub";
            this.textBox_pub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_pub.Size = new System.Drawing.Size(209, 27);
            this.textBox_pub.TabIndex = 9;
            this.textBox_pub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox_category
            // 
            this.comboBox_category.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_category.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_category.FormattingEnabled = true;
            this.comboBox_category.ItemHeight = 20;
            this.comboBox_category.Items.AddRange(new object[] {
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
            "Travel",
            ""});
            this.comboBox_category.Location = new System.Drawing.Point(505, 193);
            this.comboBox_category.Name = "comboBox_category";
            this.comboBox_category.Size = new System.Drawing.Size(200, 28);
            this.comboBox_category.TabIndex = 10;
            // 
            // textBox_page
            // 
            this.textBox_page.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_page.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_page.Location = new System.Drawing.Point(419, 249);
            this.textBox_page.Name = "textBox_page";
            this.textBox_page.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_page.Size = new System.Drawing.Size(96, 27);
            this.textBox_page.TabIndex = 12;
            this.textBox_page.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_qty
            // 
            this.textBox_qty.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_qty.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_qty.Location = new System.Drawing.Point(643, 249);
            this.textBox_qty.Name = "textBox_qty";
            this.textBox_qty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_qty.Size = new System.Drawing.Size(62, 27);
            this.textBox_qty.TabIndex = 13;
            this.textBox_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Book ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "1st Author";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "2nd Author";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Publisher";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(402, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(64, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Language";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Total Page";
            // 
            // comboBox_language
            // 
            this.comboBox_language.BackColor = System.Drawing.SystemColors.HighlightText;
            this.comboBox_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_language.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.ItemHeight = 20;
            this.comboBox_language.Items.AddRange(new object[] {
            "Bengali",
            "English",
            "Arabic"});
            this.comboBox_language.Location = new System.Drawing.Point(167, 249);
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.Size = new System.Drawing.Size(125, 28);
            this.comboBox_language.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(556, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 19);
            this.label11.TabIndex = 25;
            this.label11.Text = "Quantity";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.textBox_title);
            this.groupBox1.Controls.Add(this.button_search);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox_ISBN);
            this.groupBox1.Controls.Add(this.comboBox_language);
            this.groupBox1.Controls.Add(this.textBox_author1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_author2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_pub);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBox_category);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_page);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_qty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 308);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // button_search
            // 
            this.button_search.Image = global::LMS.Properties.Resources.Zoom_icon;
            this.button_search.Location = new System.Drawing.Point(279, 34);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(72, 30);
            this.button_search.TabIndex = 26;
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 43);
            this.panel2.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label13.Location = new System.Drawing.Point(303, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 28);
            this.label13.TabIndex = 2;
            this.label13.Text = "Book Details";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.button_cancel.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.ForeColor = System.Drawing.Color.Black;
            this.button_cancel.Image = global::LMS.Properties.Resources.Close_2_icon;
            this.button_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_cancel.Location = new System.Drawing.Point(616, 466);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(106, 35);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "&CANCEL";
            this.button_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Gainsboro;
            this.button_save.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Black;
            this.button_save.Image = global::LMS.Properties.Resources.Save_icon;
            this.button_save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_save.Location = new System.Drawing.Point(476, 466);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(106, 35);
            this.button_save.TabIndex = 14;
            this.button_save.Text = "&SAVE";
            this.button_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.Gainsboro;
            this.button_remove.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.ForeColor = System.Drawing.Color.Black;
            this.button_remove.Image = global::LMS.Properties.Resources.Delete_icon;
            this.button_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_remove.Location = new System.Drawing.Point(336, 466);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(106, 35);
            this.button_remove.TabIndex = 3;
            this.button_remove.Text = "&REMOVE";
            this.button_remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Gainsboro;
            this.button_update.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.Black;
            this.button_update.Image = global::LMS.Properties.Resources.Pencil_icon;
            this.button_update.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_update.Location = new System.Drawing.Point(192, 466);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(106, 35);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "&UPDATE";
            this.button_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Gainsboro;
            this.button_add.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Image = global::LMS.Properties.Resources.add_icon;
            this.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_add.Location = new System.Drawing.Point(49, 466);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(106, 35);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "&ADD";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
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
            this.panel1.Size = new System.Drawing.Size(779, 52);
            this.panel1.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(73, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 28);
            this.label12.TabIndex = 3;
            this.label12.Text = "Book Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LMS.Properties.Resources.Iconshock_Real_Vista_Project_Managment_Data_management;
            this.pictureBox1.Location = new System.Drawing.Point(27, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Book_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(779, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Book_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Management";
            this.Load += new System.EventHandler(this.Book_Management_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_ISBN;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.TextBox textBox_author1;
        private System.Windows.Forms.TextBox textBox_author2;
        private System.Windows.Forms.TextBox textBox_pub;
        private System.Windows.Forms.ComboBox comboBox_category;
        private System.Windows.Forms.TextBox textBox_page;
        private System.Windows.Forms.TextBox textBox_qty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}