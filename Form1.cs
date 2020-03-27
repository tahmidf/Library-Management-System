using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = combo_type;
            combo_type.SelectedIndex = 2;
            btn_login.Text = "Book List";
            text_id.Enabled = false;
            text_pw.Enabled = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (combo_type.Text == "Admin")
            {
                if (text_id.Text != "" && text_pw.Text != "")
                {
                    try
                    {
                        string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                        MySqlConnection connection = new MySqlConnection(connectionString);

                        string query = "SELECT password FROM lms.admin_login WHERE id ='" + text_id.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        connection.Open();
                        MySqlDataReader reader;
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            if (text_pw.Text == reader.GetString(0))
                            {
                                MessageBox.Show("Login Successfull!");
                                this.Hide();
                                Admin obj = new Admin(text_id.Text, combo_type.Text);
                                obj.Show();
                            }

                            else
                            {
                                MessageBox.Show("Wrong Password!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        else
                        {
                            MessageBox.Show("Invalid ID!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        connection.Close();
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Fields are empty!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (combo_type.Text == "Member")
            {
                if (text_id.Text != "" && text_pw.Text != "")
                {
                    try
                    {
                        string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                        MySqlConnection connection = new MySqlConnection(connectionString);

                        string query = "SELECT m_password FROM lms.member_login WHERE m_id ='" + text_id.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        connection.Open();
                        MySqlDataReader reader;
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            if (text_pw.Text == reader.GetString(0))
                            {
                                MessageBox.Show("Login Successfull!");
                                this.Hide();
                                Admin obj = new Admin(text_id.Text, combo_type.Text);
                                obj.Show();
                            }
                            else
                            {
                                MessageBox.Show("Wrong Password!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                        else
                        {
                            MessageBox.Show("Invalid ID!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        connection.Close();
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Fields are empty!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (combo_type.Text == "Guest")
            {
                BookList obj = new BookList(text_id.Text, combo_type.Text);
                obj.ShowDialog();
            }
            
        }

        private void combo_type_DropDownClosed(object sender, EventArgs e)
        {
            if (combo_type.Text == "Guest")
            {
                btn_login.Text = "Book List";               
                text_id.Enabled = false;
                text_pw.Enabled = false;
            }
            else
            {
                btn_login.Text = "Log In";
                text_id.Enabled = true;
                text_pw.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp obj = new SignUp();
            obj.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void combo_type_SelectedValueChanged(object sender, EventArgs e)
        {
            if (combo_type.Text == "Guest")
            {
                btn_login.Text = "Book List";
                text_id.Enabled = false;
                text_pw.Enabled = false;
            }
            else
            {
                btn_login.Text = "Log In";
                text_id.Enabled = true;
                text_pw.Enabled = true;
            }
        }

        private void btn_login_MouseHover(object sender, EventArgs e)
        {
            if (btn_login.Text == "Book List")
            {
                btn_login.BackColor = Color.FromArgb(229, 126, 65);
                btn_login.ForeColor = Color.White;
            }
            else
            {
                btn_login.BackColor = Color.FromArgb(47, 152, 226);
                btn_login.ForeColor = Color.White;
            }
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.White;
            btn_login.ForeColor = Color.Black;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(3,171,65);
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(3, 171, 65);
            button1.ForeColor = Color.White;
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
        }

        private void btn_login_Enter(object sender, EventArgs e)
        {
            if (btn_login.Text == "Book List")
            {
                btn_login.BackColor = Color.FromArgb(229, 126, 65);
                btn_login.ForeColor = Color.White;
            }
            else
            {
                btn_login.BackColor = Color.FromArgb(47, 152, 226);
                btn_login.ForeColor = Color.White;
            }
        }

        private void btn_login_Leave(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.White;
            btn_login.ForeColor = Color.Black;
        }
    }
}
