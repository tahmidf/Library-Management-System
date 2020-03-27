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
    public partial class BookTransaction : Form
    {
        string id1, type1;
        DateTime date = DateTime.Today;
        DataTable dataTable, dataTable1;

        public BookTransaction(string id, string type)
        {
            InitializeComponent();
            id1 = id;
            type1 = type;
            label_date.Text = date.ToString("dd MMM, yyyy");
            dateTimePicker_return.Value = DateTime.Today.AddDays(+7);

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

        private void BookTransaction_Load(object sender, EventArgs e)
        {
            this.ActiveControl = comboBox_transType;
            comboBox_transType.Enabled = true;
            comboBox_transType.SelectedIndex = -1;
            textBox_mid.Text = "";
            textBox_mid.Text = "";
            textBox_mname.Text = "";
            textBox_bid.Text = "";
            textBox_title.Text = "";
            textBox_issueNo.Text = "";
            textBox_mid.Enabled = false;
            textBox_mname.Enabled = false;
            textBox_bid.Enabled = false;
            textBox_title.Enabled = false;
            textBox_issueNo.Enabled = false;
            textBox_issueDate.Enabled = false;
            textBox_issueDate.Text = "";
            button_searchIssue.Visible = false;
            button_search1.Enabled = false;
            button_search2.Enabled = false;
            button_add.Enabled = false;
            button_add.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
            button_add.ForeColor = Color.Black;
            button_issue.Enabled = false;
            button_issue.Text = "ISSUE";
            button_issue.Image = LMS.Properties.Resources.Notary_icon__1_;
            button_issue.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
            button_reset.Enabled = false;
            dateTimePicker_return.Enabled = false;
            dataGridView1.Enabled = false;
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

        private void mode1() //Format of Book Issue
        {
            textBox_mid.Text = "";
            textBox_mid.Text = "";
            textBox_mname.Text = "";
            textBox_bid.Text = "";
            textBox_title.Text = "";
            textBox_issueNo.Text = "";
            textBox_mid.Enabled = true;
            textBox_mid.ReadOnly = false;
            textBox_mname.Enabled = true;
            textBox_bid.Enabled = true;
            textBox_title.Enabled = true;
            textBox_issueNo.Enabled = true;
            textBox_issueNo.ReadOnly = true;
            textBox_issueDate.Enabled = true;
            textBox_issueDate.Text = date.ToString("yyyy/MM/dd");
            button_searchIssue.Visible = false;
            button_search1.Enabled = true;
            button_search2.Enabled = true;
            button_add.Enabled = true;
            button_add.BackColor = Color.White;
            button_add.ForeColor = Color.Black;
            button_issue.Enabled = false;
            button_issue.Text = "ISSUE";
            button_issue.Image = LMS.Properties.Resources.Notary_icon__1_;
            button_issue.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
            button_reset.Enabled = true;
            dateTimePicker_return.Enabled = true;
        }

        private void mode2() //Format of Book Return
        {
            textBox_issueNo.Text = "";
            textBox_mid.Text = "";
            textBox_mid.Text = "";
            textBox_mname.Text = "";
            textBox_bid.Text = "";
            textBox_title.Text = "";
            textBox_mid.Enabled = true;
            textBox_mid.ReadOnly = true;
            textBox_mname.Enabled = true;
            textBox_bid.Enabled = false;
            textBox_title.Enabled = false;
            textBox_issueNo.Enabled = true;
            textBox_issueNo.ReadOnly = false;
            textBox_issueDate.Enabled = false;
            textBox_issueDate.Text = "";
            button_searchIssue.Visible = true;
            button_search1.Enabled = false;
            button_search2.Enabled = false;
            button_add.Enabled = false;
            button_add.BackColor = Color.FromKnownColor(KnownColor.ControlLight);
            button_add.ForeColor = Color.Black;
            button_issue.Enabled = true;
            button_issue.Text = "RETURN";
            button_issue.Image = null;
            button_issue.BackColor = Color.GreenYellow;
            button_reset.Enabled = true;
            dateTimePicker_return.Enabled = false;
            dataGridView1.Enabled = true;
        }

        void generateIssueNumber()
        {
            Random rnd = new Random();
            int id = rnd.Next(1000, 9999);
            textBox_issueNo.Text = "0" + id.ToString();
        }

        private void comboBox_transType_DropDownClosed(object sender, EventArgs e) //Book Issue/Book Return selection from ComboBox
        {
            if (comboBox_transType.SelectedIndex == 0)
            {
                comboBox_transType.Enabled = false;
                mode1();
                generateIssueNumber();
            }
            else if (comboBox_transType.SelectedIndex == 1)
            {
                comboBox_transType.Enabled = false;
                mode2();
            }
            else if (comboBox_transType.SelectedIndex == -1)
            {

            }
        }

        private void comboBox_transType_SelectedValueChanged(object sender, EventArgs e) //Book Issue/Book Return selection from ComboBox
        {
            if (comboBox_transType.SelectedIndex == 0)
            {
                comboBox_transType.Enabled = false;
                mode1();
                generateIssueNumber();
            }
            else if (comboBox_transType.SelectedIndex == 1)
            {
                comboBox_transType.Enabled = false;
                mode2();
            }
            else if (comboBox_transType.SelectedIndex == -1)
            {

            }
        }

        private void button_search1_Click(object sender, EventArgs e) //Retriving the Member name using the Member ID
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                string query = "SELECT m_name FROM lms.member_login WHERE m_id ='" + textBox_mid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox_mname.Text = reader.GetString(0);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button_search2_Click(object sender, EventArgs e) //Retriving the Title using the Book ID
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                string query = "SELECT book_title, book_qty FROM lms.book WHERE book_id ='" + textBox_bid.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader reader1;
                reader1 = cmd.ExecuteReader();

                if (reader1.Read())
                {
                    int qty = reader1.GetInt16(1); //Check for the Book Quantity available
                    if(qty > 0)
                    {
                        textBox_title.Text = reader1.GetString(0);
                    }

                    else
                    {
                        MessageBox.Show("This book (ID: " + textBox_bid.Text + ") is unavailable now!");
                        textBox_bid.Text = "";
                        textBox_title.Text = "";
                    }                    
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            if(comboBox_transType.SelectedIndex == 0)
            {
                try
                {
                    if (dataTable.Rows.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Sure you want to reset the page?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            deleteRowFromTable(textBox_issueNo.Text);
                            try
                            {
                                dataTable.Rows.Clear();
                            }

                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            BookTransaction_Load(sender, e);
                        }
                    }
                    else
                    {
                        BookTransaction_Load(sender, e);
                    }
                }

                catch(Exception ex)
                {
                    BookTransaction_Load(sender, e);
                }
            }
            else
            {
                BookTransaction_Load(sender, e);
            }          
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_title.Text != "" && textBox_mname.Text != "")
            {
                button_issue.Enabled = true;
                button_issue.BackColor = Color.Orange;
                dataGridView1.Enabled = true;
                try
                {   //Insert the data into temporary issue database from the Text boxes
                    string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    string query = "INSERT INTO lms.temp_issue(issue_no,book_id,mem_id,issue_date,return_date) VALUES ('" + textBox_issueNo.Text + "','" + textBox_bid.Text + "','" + textBox_mid.Text + "','" + textBox_issueDate.Text + "','" + dateTimePicker_return.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    connection.Open();
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    connection.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                dataTable = new DataTable();
                MySqlConnection connection1 = null;

                string connectionString1 = "datasource=localhost;port=3306;userid=root;password=1234;";
                connection1 = new MySqlConnection(connectionString1);

                try
                {   //Retrive the data from temporary issue database to the dataGridView
                    string query1 = "SELECT temp_issue.book_id, book.book_title, temp_issue.issue_date, temp_issue.return_date FROM lms.temp_issue INNER JOIN lms.book  ON temp_issue.book_id = book.book_id WHERE temp_issue.issue_no='" + textBox_issueNo.Text + "'";
                    MySqlCommand cmd1 = new MySqlCommand(query1, connection1);

                    connection1.Open();

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd1))
                    {
                        da.Fill(dataTable);
                    }

                    dataGridView1.DataSource = dataTable;
                    dataGridView1.DataMember = dataTable.TableName;
                    textBox_bid.Text = "";
                    textBox_title.Text = "";
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    if (connection1 != null) connection1.Close();
                }
            }

            else
            {
                MessageBox.Show("Required informations empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }          
        }

        private void dataGridView1_Click(object sender, EventArgs e) //When any place of the dataGridView is clicked
        {
            if (comboBox_transType.SelectedIndex == 0)
            {
                button_issue.Text = "ISSUE";
                button_issue.Image = LMS.Properties.Resources.Notary_icon__1_;
                button_issue.BackColor = Color.Orange;
            }
        }

        private void button_issue_Click(object sender, EventArgs e)
        {
            if (button_issue.Text == "ISSUE")
            {
                if (dataTable.Rows.Count > 0)
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {   //Insert all the informations from the temporary issue database to main book issue database
                            string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                            MySqlConnection connection = new MySqlConnection(connectionString);

                            string query = "INSERT INTO lms.book_issue SELECT temp_issue.issue_no, temp_issue.book_id, temp_issue.mem_id, temp_issue.issue_date, temp_issue.return_date, temp_issue.book_return FROM lms.temp_issue WHERE temp_issue.issue_no ='" + textBox_issueNo.Text + "'";
                            MySqlCommand cmd = new MySqlCommand(query, connection);

                            connection.Open();
                            int rowAffected = 0;
                            rowAffected = cmd.ExecuteNonQuery();
                            if (rowAffected > 0)
                            {
                                MessageBox.Show("Book issued to " + textBox_mname.Text + " successfully!");
                                dataTable1 = new DataTable();
                                MySqlConnection connection2 = null;
                                try
                                {   //The book ID of the issued books are stored in an array
                                    string connectionString2 = "datasource=localhost;port=3306;userid=root;password=1234;";
                                    connection2 = new MySqlConnection(connectionString2);

                                    string query2 = "SELECT book_id FROM lms.temp_issue";
                                    MySqlCommand cmd2 = new MySqlCommand(query2, connection2);

                                    connection2.Open();

                                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd2))
                                    {
                                        da.Fill(dataTable1);
                                        int TotalRow = dataTable1.Rows.Count;

                                        string[] bookid = new string[TotalRow];
                                        for (int i = 0; i < TotalRow; i++)
                                        {
                                            bookid[i] = dataTable1.Rows[i]["book_id"].ToString();
                                            try
                                            {   //Book quantity from the book database is decreased and availability updated of book IDs which where stored in the array
                                                string connectionString3 = "datasource=localhost;port=3306;userid=root;password=1234;";
                                                MySqlConnection connection3 = new MySqlConnection(connectionString3);

                                                string query3 = "UPDATE lms.book SET book_qty = book_qty-1, avail = (CASE WHEN book_qty > 0 THEN 'Yes' WHEN book_qty = 0 THEN 'No' END) WHERE book_id ='" + bookid[i] + "'";
                                                MySqlCommand cmd3 = new MySqlCommand(query3, connection3);

                                                connection3.Open();
                                                MySqlDataReader reader;
                                                reader = cmd3.ExecuteReader();
                                                connection3.Close();
                                            }

                                            catch (Exception ex2)
                                            {
                                                Console.WriteLine(ex2.Message);
                                            }
                                        }
                                    }
                                    dataTable1.Rows.Clear();
                                    connection2.Close();
                                }

                                catch (Exception exx)
                                {
                                    Console.WriteLine(exx.Message);
                                }

                                finally
                                {
                                    if (connection2 != null) connection2.Close();
                                }

                                deleteRowFromTable(textBox_issueNo.Text);
                                dataTable.Rows.Clear();
                                BookTransaction_Load(sender, e);
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
                    MessageBox.Show("There is no book to issue!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if(button_issue.Text == "RETURN")
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                string id = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

                try
                {   //book_return column of the book_issue database is updated
                    string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    string query = "UPDATE lms.book_issue SET book_return = 'yes' WHERE issue_no ='" + textBox_issueNo.Text + "' AND book_id ='" + id + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    connection.Open();
                    int rowAffected = 0;
                    rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        MessageBox.Show("Book ID: " + id + " returned.");

                        try
                        {   //book_qty is incremented and availability is updated in book database with the return of book
                            string connectionString1 = "datasource=localhost;port=3306;userid=root;password=1234;";
                            MySqlConnection connection1 = new MySqlConnection(connectionString1);

                            string query1 = "UPDATE lms.book SET book_qty = book_qty+1, avail = (CASE WHEN book_qty > 0 THEN 'Yes' WHEN book_qty = 0 THEN 'No' END) WHERE book_id ='" + id + "'";
                            MySqlCommand cmd1 = new MySqlCommand(query1, connection1);

                            connection1.Open();
                            MySqlDataReader reader;
                            reader = cmd1.ExecuteReader();
                            connection1.Close();
                        }

                        catch(Exception ex1)
                        {
                            Console.WriteLine(ex1.Message);
                        }

                        dataTable.Rows.RemoveAt(rowIndex);
                        if(dataTable.Rows.Count == 0)
                        {
                            BookTransaction_Load(sender, e);
                        }
                    }
                    connection.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            else if(button_issue.Text == "REMOVE")
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                string id = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

                try
                {
                    string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                    MySqlConnection connection = new MySqlConnection(connectionString);

                    string query = "DELETE FROM lms.temp_issue WHERE issue_no ='" + textBox_issueNo.Text + "' AND book_id ='" + id + "'";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    connection.Open();
                    int rowAffected = 0;
                    rowAffected = cmd.ExecuteNonQuery();
                    if (rowAffected > 0)
                    {
                        button_issue.Text = "ISSUE";
                        button_issue.Image = LMS.Properties.Resources.Notary_icon__1_;
                        button_issue.BackColor = Color.Orange;
                        dataTable.Rows.RemoveAt(rowIndex);
                    }
                    connection.Close();
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (comboBox_transType.SelectedIndex == 0)
            {
                button_issue.Text = "REMOVE";
                button_issue.Image = null;
                button_issue.BackColor = Color.Red;
            }

            else if (comboBox_transType.SelectedIndex == 1)
            {
                button_issue.Text = "RETURN";
                button_issue.Image = null;
                button_issue.BackColor = Color.GreenYellow;
            }
        }

        private void BookTransaction_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox_transType.SelectedIndex == 0 && dataGridView1.Enabled == true)
            {
                button_issue.Text = "ISSUE";
                button_issue.Image = LMS.Properties.Resources.Notary_icon__1_;
                button_issue.BackColor = Color.Orange;
            }
        }

        private void button_add_Enter(object sender, EventArgs e)
        {
            if(button_add.Enabled == true)
            {
                button_add.BackColor = Color.RoyalBlue;
                button_add.ForeColor = Color.White;
            }
        }

        private void button_add_Leave(object sender, EventArgs e)
        {
            if (button_add.Enabled == true)
            {
                button_add.BackColor = Color.White;
                button_add.ForeColor = Color.Black;
            }
        }

        private void button_add_MouseHover(object sender, EventArgs e)
        {
            if (button_add.Enabled == true)
            {
                button_add.BackColor = Color.RoyalBlue;
                button_add.ForeColor = Color.White;
            }
        }

        private void button_add_MouseLeave(object sender, EventArgs e)
        {
            if (button_add.Enabled == true)
            {
                button_add.BackColor = Color.White;
                button_add.ForeColor = Color.Black;
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (type1 == "Admin" || type1 == "Member")
            {
                this.Close();
            }
        }

        private void button_searchIssue_Click(object sender, EventArgs e)
        {
            dataTable = new DataTable();
            MySqlConnection connection = null;

            string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
            connection = new MySqlConnection(connectionString);

            try
            {
                string query = "SELECT book_issue.book_id, book.book_title, book_issue.issue_date, book_issue.return_date FROM lms.book_issue INNER JOIN lms.book  ON book_issue.book_id = book.book_id WHERE book_issue.book_return = 'no' AND book_issue.issue_no='" + textBox_issueNo.Text + "'";
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

            try
            {
                string connectionString1 = "datasource=localhost;port=3306;userid=root;password=1234;";
                MySqlConnection connection1 = new MySqlConnection(connectionString1);

                string query = "SELECT book_issue.mem_id, member_login.m_name FROM lms.book_issue INNER JOIN lms.member_login ON book_issue.mem_id = member_login.m_id WHERE book_issue.book_return = 'no' AND book_issue.issue_no='" + textBox_issueNo.Text + "'";
                MySqlCommand cmd = new MySqlCommand(query, connection1);
                connection1.Open();
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox_mid.Text = reader.GetString(0);
                    textBox_mname.Text = reader.GetString(1);
                }
                connection1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void deleteRowFromTable(string number)
        {
            try
            {
                string connectionString = "datasource=localhost;port=3306;userid=root;password=1234;";
                MySqlConnection connection1 = new MySqlConnection(connectionString);

                string query1 = "DELETE FROM lms.temp_issue WHERE issue_no ='" + number + "'";
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
    }
}
