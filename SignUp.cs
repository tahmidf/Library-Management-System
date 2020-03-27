using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace LMS
{
    public partial class SignUp : Form
    {
        Regex phoneNumpattern = new Regex(@"^(?:\+?88)?01[15-9]\d{8}$");
        public SignUp()
        {
            InitializeComponent();
            check_cpw.Checked = false;
            button_getID.Enabled = true;
            label_message.Visible = false;
            label_message1.Visible = true;

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.ActiveControl = text_name;
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            button_getID.Enabled = true;
            label_message.Visible = false;
            label_message1.Visible = true;
            text_id.Text = "";
            text_name.Text = "";
            text_pw.Text = "";
            text_cpw.Text = "";
            textBox_phone.Text = "";
            check_cpw.Checked = false;
        }


        private void check_cpw_CheckedChanged(object sender, EventArgs e)
        {
            if (check_cpw.Checked)
            {
                text_pw.UseSystemPasswordChar = false;
                text_cpw.UseSystemPasswordChar = false;
            }
            else
            {
                text_pw.UseSystemPasswordChar = true;
                text_cpw.UseSystemPasswordChar = true;
            }
        }

        private void button_signUp_Click(object sender, EventArgs e)
        {
            if (text_id.Text == "" || text_name.Text == "" || textBox_phone.Text == "" || text_pw.Text == "" || text_cpw.Text == "")
            {
                MessageBox.Show("Required Field Empty!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (phoneNumpattern.IsMatch(textBox_phone.Text))
            {
                if (text_pw.Text != text_cpw.Text)
                {
                    MessageBox.Show("Password didn't match!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                        MySqlConnection connection = new MySqlConnection(connectionString);

                        string query = "INSERT INTO lms.temp_mem(mem_id,mem_name,mem_phone,mem_password) VALUES ('" + text_id.Text + "','" + text_name.Text + "','" + textBox_phone.Text + "','" + text_pw.Text + "')";
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        connection.Open();
                        int rowAffected = 0;
                        rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Sign Up successfull! Wait for the approval...");
                            this.Close();
                            Login obj = new Login();
                            obj.Show();
                        }
                        connection.Close();
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            else
            {
                MessageBox.Show("Invalid Phone Number!!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_getID_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(1000, 9999);
            text_id.Text = id.ToString();
            button_getID.Enabled = false;
            label_message.Visible = true;
            label_message1.Visible = false;
        }

        private void button_reset_Enter(object sender, EventArgs e)
        {
            button_reset.BackColor = Color.FromArgb(3, 171, 65);
            button_reset.ForeColor = Color.White;
        }

        private void button_reset_Leave(object sender, EventArgs e)
        {
            button_reset.BackColor = Color.White;
            button_reset.ForeColor = Color.Black;
        }

        private void button_reset_MouseHover(object sender, EventArgs e)
        {
            button_reset.BackColor = Color.FromArgb(3, 171, 65);
            button_reset.ForeColor = Color.White;
        }

        private void button_reset_MouseLeave(object sender, EventArgs e)
        {
            button_reset.BackColor = Color.White;
            button_reset.ForeColor = Color.Black;
        }

        private void button_signUp_Enter(object sender, EventArgs e)
        {
            button_signUp.BackColor = Color.FromArgb(47, 152, 226);
            button_signUp.ForeColor = Color.White;
        }

        private void button_signUp_Leave(object sender, EventArgs e)
        {
            button_signUp.BackColor = Color.White;
            button_signUp.ForeColor = Color.Black;
        }

        private void button_signUp_MouseHover(object sender, EventArgs e)
        {
            button_signUp.BackColor = Color.FromArgb(47, 152, 226);
            button_signUp.ForeColor = Color.White;
        }

        private void button_signUp_MouseLeave(object sender, EventArgs e)
        {
            button_signUp.BackColor = Color.White;
            button_signUp.ForeColor = Color.Black;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login obj = new Login();
            obj.Show();
        }
    }
}