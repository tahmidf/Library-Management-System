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
    public partial class Admin : Form
    {
        private int hr, min, sec;
        string id1, type1;
        MySqlDataReader reader1;
        DateTime date = DateTime.Today;
        public Admin(string id, string type)
        {
            this.Enabled = true;
            id1 = id;
            type1 = type;
            InitializeComponent();
            label_date.Text = date.ToString("dd MMM, yyyy");
            hr = DateTime.Now.Hour;
            min = DateTime.Now.Minute;
            sec = DateTime.Now.Second;
            if (type == "Admin")
            {
                this.Text = type + " Dashboard";
                try
                {
                    string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    string query = "SELECT name FROM lms.admin_login WHERE id =" + id;
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    connection.Open();
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        label_name.Text = reader.GetString(0);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                try
                {
                    string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    string query = "SELECT mem_name FROM lms.temp_mem;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    connection.Open();
                    reader1 = cmd.ExecuteReader();

                    while (reader1.Read())
                    {
                        int i = 0;
                        listBox_notif.Items.Add(reader1.GetString(i++) + " needs sign up approval");
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            else if(type == "Member")
            {
                this.Text = type + " Dashboard";
                button_manage.Enabled = false;
                button_trans.Enabled = false;
                try
                {
                    string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    string query = "SELECT m_name FROM lms.member_login WHERE m_id =" + id;
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    connection.Open();
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        label_name.Text = reader.GetString(0);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
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

        private void btn_bookList_Click(object sender, EventArgs e)
        {
            BookList obj = new BookList(id1, type1);
            obj.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void listBox_notif_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string list_name = listBox_notif.SelectedItem.ToString();

                int l = list_name.IndexOf(" needs");
                string newString = "";
                if (l > 0)
                {
                    newString = list_name.Substring(0, l);
                }

                DialogResult result1 = MessageBox.Show(list_name, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result1 == DialogResult.OK)
                {
                    DialogResult result2 = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result2 == DialogResult.Yes)
                    {
                        try
                        {
                            string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                            MySqlConnection connection1 = new MySqlConnection(connectionString);

                            string query1 = "INSERT INTO lms.member_login SELECT mem_id, mem_name, mem_phone, mem_password FROM lms.temp_mem WHERE mem_name ='" + newString + "'";
                            MySqlCommand cmd1 = new MySqlCommand(query1, connection1);

                            connection1.Open();
                            int rowAffected = 0;
                            rowAffected = cmd1.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show(newString + " is successfully added as a member");
                                listBox_notif.Items.Remove(list_name);
                                deleteRowFromTable(newString);
                            }
                            connection1.Close();
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

                else if (result1 == DialogResult.Cancel)
                {
                    DialogResult result2 = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result2 == DialogResult.Yes)
                    {
                        listBox_notif.Items.Remove(list_name);
                        deleteRowFromTable(newString);
                    }
                }
            }

            catch(Exception ex) { }
            
        }

        private void deleteRowFromTable(string name)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                MySqlConnection connection1 = new MySqlConnection(connectionString);

                string query1 = "DELETE FROM lms.temp_mem WHERE mem_name ='" + name + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection1);

                connection1.Open();
                int rowAffected = 0;
                rowAffected = cmd1.ExecuteNonQuery();
                connection1.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hr = DateTime.Now.Hour;
            min = DateTime.Now.Minute;
            sec = DateTime.Now.Second;
            string tt = DateTime.Now.ToString("tt");

            string time = "";

            //padding leading zero
            
            if(hr > 12)
            {
                hr = hr - 12;
                if (hr < 10)
                {
                    time += "0" + hr;
                }

                else
                {
                    time += hr;
                }
            }
            else
            {
                if (hr < 10)
                {
                    time += "0" + hr;
                }

                else
                {
                    time += hr;
                }
            }
            
            time += ":";

            if (min < 10)
            {
                time += "0" + min;
            }
            else
            {
                time += min;
            }
            time += ":";

            if (sec < 10)
            {
                time += "0" + sec;
            }
            else
            {
                time += sec;
            }

            //update label
            lblTime.Text = time + " " + tt;
        }

        private void btn_bookList_MouseHover(object sender, EventArgs e)
        {
            btn_bookList.ForeColor = Color.FromArgb(229,126,49);
        }

        private void btn_bookList_MouseLeave(object sender, EventArgs e)
        {
            btn_bookList.ForeColor = Color.Gainsboro;
        }

        private void button_manage_MouseHover(object sender, EventArgs e)
        {
            button_manage.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void button_manage_MouseLeave(object sender, EventArgs e)
        {
            button_manage.ForeColor = Color.Gainsboro;
        }

        private void button_trans_MouseHover(object sender, EventArgs e)
        {
            button_trans.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void button_trans_MouseLeave(object sender, EventArgs e)
        {
            button_trans.ForeColor = Color.Gainsboro;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gainsboro;
        }

        private void button_acct_MouseHover(object sender, EventArgs e)
        {
            button_acct.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void button_acct_MouseLeave(object sender, EventArgs e)
        {
            button_acct.ForeColor = Color.Gainsboro;
        }

        private void button_manage_Enter(object sender, EventArgs e)
        {
            button_manage.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void button_manage_Leave(object sender, EventArgs e)
        {
            button_manage.ForeColor = Color.Gainsboro;
        }

        private void btn_bookList_Enter(object sender, EventArgs e)
        {
            btn_bookList.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void btn_bookList_Leave(object sender, EventArgs e)
        {
            btn_bookList.ForeColor = Color.Gainsboro;
        }

        private void button_trans_Enter(object sender, EventArgs e)
        {
            button_trans.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void button_trans_Leave(object sender, EventArgs e)
        {
            button_trans.ForeColor = Color.Gainsboro;
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Gainsboro;
        }

        private void button_acct_Enter(object sender, EventArgs e)
        {
            button_acct.ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void button_acct_Leave(object sender, EventArgs e)
        {
            button_acct.ForeColor = Color.Gainsboro;
        }

        private void button_manage_Click(object sender, EventArgs e)
        {
            //this.Enabled = false;
            Book_Management obj = new Book_Management(id1, type1);
            obj.ShowDialog();
        }

        private void button_trans_Click(object sender, EventArgs e)
        {
            BookTransaction obj = new BookTransaction(id1, type1);
            obj.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login obj = new Login();
            obj.Show();
        }
    }
}
