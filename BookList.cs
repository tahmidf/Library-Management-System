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
    public partial class BookList : Form
    {
        string id1, type1;
        public BookList(string id, string type)
        {
            id1 = id;
            type1 = type;
            InitializeComponent();
            if(type == "Guest")
            {
                label_name.Text = type;
            }

            else if(type == "Admin")
            {
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
            }
            else
            {
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

        private void BookList_Load(object sender, EventArgs e) //Generate the data of the dataGridView when the form loads
        {
            textBox_search.Enabled = false;
            button_search.Enabled = false;
            button_search.BackColor = Color.Gainsboro;

            DataTable dataTable = new DataTable();
            MySqlConnection connection = null;
            try
            {
                string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                connection = new MySqlConnection(connectionString);

                string query = "SELECT book_id, book_title, author1, author2, book_pub, book_category, book_language, avail FROM lms.book;";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                connection.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dataTable);
                }

                dataGridView1.DataSource = dataTable;
                dataGridView1.DataMember = dataTable.TableName;
            }



            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                if (connection != null) connection.Close();
            }

        }

        private const int CP_NOCLOSE_BUTTON = 0x200; //Disabling the cross red button
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) //Format of the Availabilty column of the dataGridView
        {
            foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            {
                if ((Myrow.Cells[7].Value.ToString()).Equals("Yes"))
                {
                    Myrow.Cells[7].Style.BackColor = Color.Green;
                }
                else
                {
                    Myrow.Cells[7].Style.BackColor = Color.Red;
                }
            }
        }

        private void radioButton_category_CheckedChanged(object sender, EventArgs e) //Category radio button checked for ComboBox
        {
            if(radioButton_category.Checked == true)
            {
                textBox_search.Visible = false;
                comboBox_item.Visible = true;
                button_search.Enabled = true;
                button_search.BackColor = Color.White;
                comboBox_item.SelectedIndex = -1;
            }
            else
            {
                textBox_search.Visible = true;
                comboBox_item.Visible = false;
            }
        }

        private void radioButton_id_CheckedChanged(object sender, EventArgs e)
        {
            textBox_search.Text = "";
            textBox_search.Enabled = true;
            button_search.Enabled = true;
            button_search.BackColor = Color.White;
        }

        private void radioButton_title_CheckedChanged(object sender, EventArgs e)
        {
            textBox_search.Text = "";
            textBox_search.Enabled = true;
            button_search.Enabled = true;
            button_search.BackColor = Color.White;
        }

        private void radioButton_author_CheckedChanged(object sender, EventArgs e)
        {
            textBox_search.Text = "";
            textBox_search.Enabled = true;
            button_search.Enabled = true;
            button_search.BackColor = Color.White;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            MySqlConnection connection = null;
           
            string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
            connection = new MySqlConnection(connectionString);

            if(radioButton_id.Checked == true)
            {
                if (textBox_search.Text != "")
                {
                    try
                    {
                        string query = "SELECT book_id, book_title, author1, author2, book_pub, book_category, book_language, avail FROM lms.book WHERE book_id='" + textBox_search.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dataTable);
                        }

                        dataGridView1.DataSource = dataTable;
                        dataGridView1.DataMember = dataTable.TableName;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    finally
                    {
                        if (connection != null) connection.Close();
                    }
                }

                else
                {
                    MessageBox.Show("No Book ID provided!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if(radioButton_title.Checked == true)
            {
                if (textBox_search.Text != "")
                {
                    try
                    {
                        string query = "SELECT book_id, book_title, author1, author2, book_pub, book_category, book_language, avail FROM lms.book WHERE book_title='" + textBox_search.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dataTable);
                        }

                        dataGridView1.DataSource = dataTable;
                        dataGridView1.DataMember = dataTable.TableName;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    finally
                    {
                        if (connection != null) connection.Close();
                    }
                }

                else
                {
                    MessageBox.Show("No Book Title provided!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (radioButton_author.Checked == true)
            {
                if (textBox_search.Text != "")
                {
                    try
                    {
                        string query = "SELECT book_id, book_title, author1, author2, book_pub, book_category, book_language, avail FROM lms.book WHERE author1='" + textBox_search.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dataTable);
                        }

                        dataGridView1.DataSource = dataTable;
                        dataGridView1.DataMember = dataTable.TableName;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    finally
                    {
                        if (connection != null) connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No Author name provided!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (radioButton_category.Checked == true)
            {
                if (comboBox_item.SelectedIndex != -1)
                {
                    try
                    {
                        string cat = comboBox_item.SelectedItem.ToString();

                        string query = "SELECT book_id, book_title, author1, author2, book_pub, book_category, book_language, avail FROM lms.book WHERE book_category='" + cat + "'";
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        connection.Open();

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(dataTable);
                        }

                        dataGridView1.DataSource = dataTable;
                        dataGridView1.DataMember = dataTable.TableName;
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    finally
                    {
                        if (connection != null) connection.Close();
                    }
                }

                else
                {
                    MessageBox.Show("No Category selected!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_search_MouseHover(object sender, EventArgs e)
        {
            if(button_search.Enabled)
            {
                button_search.BackColor = Color.FromArgb(47, 152, 226);
                button_search.ForeColor = Color.White;
            }
        }

        private void button_search_MouseLeave(object sender, EventArgs e)
        {
            if(button_search.Enabled)
            {
                button_search.BackColor = Color.White;
                button_search.ForeColor = Color.Black;
            }
        }

        private void button_search_Enter(object sender, EventArgs e)
        {
            if (button_search.Enabled)
            {
                button_search.BackColor = Color.FromArgb(47, 152, 226);
                button_search.ForeColor = Color.White;
            }
        }

        private void button_search_Leave(object sender, EventArgs e)
        {
            if (button_search.Enabled)
            {
                button_search.BackColor = Color.White;
                button_search.ForeColor = Color.Black;
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_all_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_all.Checked == true)
            {
                BookList_Load(sender, e);
            }
        }
    }
}
