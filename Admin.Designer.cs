namespace LMS
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.listBox_notif = new System.Windows.Forms.ListBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_acct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_bookList = new System.Windows.Forms.Button();
            this.button_trans = new System.Windows.Forms.Button();
            this.button_manage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signOutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 25);
            this.fileToolStripMenuItem.Text = "&Menu";
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = global::LMS.Properties.Resources.Hopstarter_3d_Cartoon_Vol3_Windows_Turn_Off;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.signOutToolStripMenuItem.Text = "&Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = global::LMS.Properties.Resources.Hopstarter_Sleek_Xp_Basic_Close_2;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1111, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Logged In as :";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label_name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(1201, 7);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 16);
            this.label_name.TabIndex = 2;
            // 
            // listBox_notif
            // 
            this.listBox_notif.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_notif.ForeColor = System.Drawing.Color.Red;
            this.listBox_notif.FormattingEnabled = true;
            this.listBox_notif.ItemHeight = 18;
            this.listBox_notif.Location = new System.Drawing.Point(-2, 102);
            this.listBox_notif.Name = "listBox_notif";
            this.listBox_notif.Size = new System.Drawing.Size(303, 364);
            this.listBox_notif.TabIndex = 0;
            this.listBox_notif.TabStop = false;
            this.listBox_notif.DoubleClick += new System.EventHandler(this.listBox_notif_DoubleClick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Century Schoolbook", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.lblTime.Location = new System.Drawing.Point(843, 45);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(127, 32);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(36, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 47);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ornate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(183, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Library";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.button_acct);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_bookList);
            this.panel1.Controls.Add(this.button_trans);
            this.panel1.Controls.Add(this.button_manage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 712);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::LMS.Properties.Resources.Pelfusion_Long_Shadow_Media_Settings;
            this.pictureBox6.Location = new System.Drawing.Point(35, 476);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 38);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LMS.Properties.Resources.Hopstarter_Soft_Scraps_User_Clients;
            this.pictureBox5.Location = new System.Drawing.Point(35, 388);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 38);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LMS.Properties.Resources.Notary_icon__1_;
            this.pictureBox4.Location = new System.Drawing.Point(35, 298);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LMS.Properties.Resources.Iconshock_Real_Vista_Project_Managment_Data_management;
            this.pictureBox3.Location = new System.Drawing.Point(35, 209);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LMS.Properties.Resources.Itzikgur_My_Seven_Books_2;
            this.pictureBox2.Location = new System.Drawing.Point(35, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // button_acct
            // 
            this.button_acct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button_acct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button_acct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button_acct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_acct.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_acct.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_acct.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_acct.Location = new System.Drawing.Point(0, 451);
            this.button_acct.Name = "button_acct";
            this.button_acct.Size = new System.Drawing.Size(280, 90);
            this.button_acct.TabIndex = 6;
            this.button_acct.Text = "        Account Settings";
            this.button_acct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_acct.UseVisualStyleBackColor = false;
            this.button_acct.Enter += new System.EventHandler(this.button_acct_Enter);
            this.button_acct.Leave += new System.EventHandler(this.button_acct_Leave);
            this.button_acct.MouseLeave += new System.EventHandler(this.button_acct_MouseLeave);
            this.button_acct.MouseHover += new System.EventHandler(this.button_acct_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 90);
            this.button1.TabIndex = 5;
            this.button1.Text = "     Member Details";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Enter += new System.EventHandler(this.button1_Enter);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 96);
            this.panel2.TabIndex = 1;
            // 
            // btn_bookList
            // 
            this.btn_bookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_bookList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_bookList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btn_bookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bookList.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_bookList.Location = new System.Drawing.Point(0, 95);
            this.btn_bookList.Name = "btn_bookList";
            this.btn_bookList.Size = new System.Drawing.Size(280, 90);
            this.btn_bookList.TabIndex = 2;
            this.btn_bookList.Text = "    View All Books";
            this.btn_bookList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_bookList.UseVisualStyleBackColor = false;
            this.btn_bookList.Click += new System.EventHandler(this.btn_bookList_Click);
            this.btn_bookList.Enter += new System.EventHandler(this.btn_bookList_Enter);
            this.btn_bookList.Leave += new System.EventHandler(this.btn_bookList_Leave);
            this.btn_bookList.MouseLeave += new System.EventHandler(this.btn_bookList_MouseLeave);
            this.btn_bookList.MouseHover += new System.EventHandler(this.btn_bookList_MouseHover);
            // 
            // button_trans
            // 
            this.button_trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button_trans.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button_trans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button_trans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trans.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_trans.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_trans.Location = new System.Drawing.Point(0, 273);
            this.button_trans.Name = "button_trans";
            this.button_trans.Size = new System.Drawing.Size(280, 90);
            this.button_trans.TabIndex = 4;
            this.button_trans.Text = "         Book Transaction";
            this.button_trans.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_trans.UseVisualStyleBackColor = false;
            this.button_trans.Click += new System.EventHandler(this.button_trans_Click);
            this.button_trans.Enter += new System.EventHandler(this.button_trans_Enter);
            this.button_trans.Leave += new System.EventHandler(this.button_trans_Leave);
            this.button_trans.MouseLeave += new System.EventHandler(this.button_trans_MouseLeave);
            this.button_trans.MouseHover += new System.EventHandler(this.button_trans_MouseHover);
            // 
            // button_manage
            // 
            this.button_manage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button_manage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.button_manage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button_manage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_manage.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_manage.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_manage.Location = new System.Drawing.Point(0, 184);
            this.button_manage.Name = "button_manage";
            this.button_manage.Size = new System.Drawing.Size(282, 90);
            this.button_manage.TabIndex = 3;
            this.button_manage.Text = "   Manage Books";
            this.button_manage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_manage.UseVisualStyleBackColor = false;
            this.button_manage.Click += new System.EventHandler(this.button_manage_Click);
            this.button_manage.Enter += new System.EventHandler(this.button_manage_Enter);
            this.button_manage.Leave += new System.EventHandler(this.button_manage_Leave);
            this.button_manage.MouseLeave += new System.EventHandler(this.button_manage_MouseLeave);
            this.button_manage.MouseHover += new System.EventHandler(this.button_manage_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label_date);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(287, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1075, 100);
            this.panel3.TabIndex = 10;
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.BackColor = System.Drawing.Color.Transparent;
            this.label_date.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label_date.Location = new System.Drawing.Point(862, 18);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(74, 23);
            this.label_date.TabIndex = 7;
            this.label_date.Text = "-- --- ----";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label4.Location = new System.Drawing.Point(104, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::LMS.Properties.Resources.Actions_home_icon;
            this.pictureBox1.Location = new System.Drawing.Point(41, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 41);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(152)))), ((int)(((byte)(226)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.listBox_notif);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1057, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 612);
            this.panel4.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 426);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(301, 182);
            this.panel6.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(301, 102);
            this.panel5.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(83, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Notifications";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button btn_bookList;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button button_manage;
        private System.Windows.Forms.ListBox listBox_notif;
        private System.Windows.Forms.Button button_acct;
        private System.Windows.Forms.Button button_trans;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}