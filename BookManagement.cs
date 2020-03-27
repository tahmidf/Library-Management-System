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
    public partial class Book_Management : Form
    {
        string id1, type1;
        int button_click = 0;
        public Book_Management(string id, string type)
        {
            InitializeComponent();
            id1 = id;
            type1 = type;
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

        private void Book_Management_Load(object sender, EventArgs e)
        {
            textBox_id.Text = "";
            textBox_ISBN.Text = "";
            textBox_title.Text = "";
            textBox_author1.Text = "";
            textBox_author2.Text = "";
            textBox_pub.Text = "";
            comboBox_category.Text = "";
            comboBox_language.Text = "";
            textBox_page.Text = "";
            textBox_qty.Text = "";
            textBox_id.Enabled = false;
            button_search.Enabled = false;
            textBox_ISBN.Enabled = false;
            textBox_title.Enabled = false;
            textBox_author1.Enabled = false;
            textBox_author2.Enabled = false;
            textBox_pub.Enabled = false;
            comboBox_category.Enabled = false;
            comboBox_language.Enabled = false;
            textBox_page.Enabled = false;
            textBox_qty.Enabled = false;
            button_add.Enabled = true;
            button_update.Enabled = true;
            button_remove.Enabled = true;
            button_save.Enabled = false;
            button_save.Text = "SAVE";
            button_cancel.Enabled = false;
            textBox_ISBN.ReadOnly = false;
            textBox_title.ReadOnly = false;
            textBox_author1.ReadOnly = false;
            textBox_author2.ReadOnly = false;
            textBox_pub.ReadOnly = false;
            textBox_page.ReadOnly = false;
            textBox_qty.ReadOnly = false;
        }

        private void mode2()
        {
            textBox_id.Enabled = true;
            button_search.Enabled = false;
            textBox_ISBN.Enabled = true;
            textBox_title.Enabled = true;
            textBox_author1.Enabled = true;
            textBox_author2.Enabled = true;
            textBox_pub.Enabled = true;
            comboBox_category.Enabled = true;
            comboBox_language.Enabled = true;
            textBox_page.Enabled = true;
            textBox_qty.Enabled = true;
            button_add.Enabled = false;
            button_update.Enabled = false;
            button_remove.Enabled = false;
            button_save.Enabled = true;
            button_cancel.Enabled = true;
            textBox_ISBN.ReadOnly = false;
            textBox_title.ReadOnly = false;
            textBox_author1.ReadOnly = false;
            textBox_author2.ReadOnly = false;
            textBox_pub.ReadOnly = false;
            textBox_page.ReadOnly = false;
            textBox_qty.ReadOnly = false;
        }

        private void mode3()
        {
            textBox_id.Enabled = true;
            button_search.Enabled = true;
            textBox_ISBN.Enabled = false;
            textBox_title.Enabled = false;
            textBox_author1.Enabled = false;
            textBox_author2.Enabled = false;
            textBox_pub.Enabled = false;
            comboBox_category.Enabled = false;
            comboBox_language.Enabled = false;
            textBox_page.Enabled = false;
            textBox_qty.Enabled = false;
            button_add.Enabled = false;
            button_update.Enabled = false;
            button_remove.Enabled = false;
            button_save.Enabled = false;
            button_cancel.Enabled = true;
            textBox_ISBN.ReadOnly = false;
            textBox_title.ReadOnly = false;
            textBox_author1.ReadOnly = false;
            textBox_author2.ReadOnly = false;
            textBox_pub.ReadOnly = false;
            textBox_page.ReadOnly = false;
            textBox_qty.ReadOnly = false;
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

        private void button_add_Click(object sender, EventArgs e)
        {
            button_click = 1;
            mode2();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            button_click = 2;
            mode3();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            button_click = 3;
            mode3();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(textBox_id.Text != "" && textBox_ISBN.Text != "" && textBox_title.Text != "" && textBox_author1.Text != "" && textBox_pub.Text != "" && comboBox_category.Text != "" && comboBox_language.Text != "" && textBox_page.Text != "" && textBox_qty.Text != "")
            {
                if (button_click == 1)
                {
                    DialogResult result1 = MessageBox.Show("Sure you want to save?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        try
                        {
                            string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                            MySqlConnection connection = new MySqlConnection(connectionString);

                            string query = "INSERT INTO lms.book(book_id,book_isbn,book_title,author1,author2,book_pub,book_category,book_language,book_page,book_qty) VALUES ('" + textBox_id.Text + "','" + textBox_ISBN.Text + "','" + textBox_title.Text + "','" + textBox_author1.Text + "','" + textBox_author2.Text + "','" + textBox_pub.Text + "','" + comboBox_category.Text + "','" + comboBox_language.Text + "','" + textBox_page.Text + "','" + textBox_qty.Text + "')";
                            MySqlCommand cmd = new MySqlCommand(query, connection);

                            connection.Open();
                            int rowAffected = 0;
                            rowAffected = cmd.ExecuteNonQuery();

                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Book added to the library!");
                                Book_Management_Load(sender, e);
                            }
                            connection.Close();
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

                else if (button_click == 2)
                {
                    DialogResult result1 = MessageBox.Show("Sure you want to save?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        try
                        {
                            string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                            MySqlConnection connection = new MySqlConnection(connectionString);

                            string query = "UPDATE lms.book SET book_isbn ='" + textBox_ISBN.Text + "', book_title ='" + textBox_title.Text + "', author1 ='" + textBox_author1.Text + "', author2 ='" + textBox_author2.Text + "', book_pub ='" + textBox_pub.Text + "', book_category ='" + comboBox_category.Text + "', book_language ='" + comboBox_language.Text + "', book_page ='" + textBox_page.Text + "', book_qty ='" + textBox_qty.Text + "' WHERE book_id ='" + textBox_id.Text + "'"; 
                            MySqlCommand cmd = new MySqlCommand(query, connection);

                            connection.Open();
                            int rowAffected = 0;
                            rowAffected = cmd.ExecuteNonQuery();

                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Book updated successfully!");
                                Book_Management_Load(sender, e);
                            }
                            connection.Close();
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }

                else if (button_click == 3)
                {
                    DialogResult result1 = MessageBox.Show("Sure you want to remove this book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result1 == DialogResult.Yes)
                    {
                        try
                        {
                            string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                            MySqlConnection connection = new MySqlConnection(connectionString);

                            string query = "DELETE FROM lms.book WHERE book_id ='" + textBox_id.Text + "'";
                            MySqlCommand cmd = new MySqlCommand(query, connection);

                            connection.Open();
                            int rowAffected = 0;
                            rowAffected = cmd.ExecuteNonQuery();

                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Book removed successfully!");
                                Book_Management_Load(sender, e);
                            }
                            connection.Close();
                        }

                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Required fields are empty!","Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }     
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Sure you want to cancel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result1 == DialogResult.Yes)
            {
                Book_Management_Load(sender, e);
            }
            
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            int counter = 0;
            if(textBox_id.Text != "")
            {
                try
                {
                    string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    string query = "SELECT * FROM lms.book WHERE book_id='" + textBox_id.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        textBox_ISBN.Text = reader.GetString(1);
                        textBox_title.Text = reader.GetString(2);
                        textBox_author1.Text = reader.GetString(3);
                        textBox_author2.Text = reader.GetString(4);
                        textBox_pub.Text = reader.GetString(5);
                        comboBox_category.Text = reader.GetString(6);
                        comboBox_language.Text = reader.GetString(7);
                        textBox_page.Text = reader.GetString(8);
                        textBox_qty.Text = reader.GetString(9);
                        textBox_id.Enabled = false;
                        button_search.Enabled = false;
                        textBox_ISBN.Enabled = true;
                        textBox_title.Enabled = true;
                        textBox_author1.Enabled = true;
                        textBox_author2.Enabled = true;
                        textBox_pub.Enabled = true;
                        comboBox_category.Enabled = true;
                        comboBox_language.Enabled = true;
                        textBox_page.Enabled = true;
                        textBox_qty.Enabled = true;
                        button_add.Enabled = false;
                        button_update.Enabled = false;
                        button_remove.Enabled = false;
                        button_save.Enabled = true;
                        if(button_click == 3)
                        {
                            textBox_ISBN.ReadOnly = true;
                            textBox_title.ReadOnly = true;
                            textBox_author1.ReadOnly = true;
                            textBox_author2.ReadOnly = true;
                            textBox_pub.ReadOnly = true;
                            comboBox_category.Enabled = false;
                            comboBox_language.Enabled = false;
                            textBox_page.ReadOnly = true;
                            textBox_qty.ReadOnly = true;
                            button_save.Text = "DELETE";
                        }
                        button_cancel.Enabled = true;
                        counter++;
                    }

                    if(counter == 0)
                    {
                        MessageBox.Show("No such ID found!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox_id.Text = "";
                    }
                    connection.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (type1 == "Admin" || type1 == "Member")
            {
                this.Close();
            }
        }
    }
}
