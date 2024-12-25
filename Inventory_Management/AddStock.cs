using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management
{
    public partial class AddStock : Form
    {
        SqlConnection conn;
        public AddStock()
        {
            InitializeComponent();
        }

        private void AddStock_Load(object sender, EventArgs e)
        {

            string connString = ""; //add your connection string
            conn = new SqlConnection(connString);

            comboBoxBookType.Items.AddRange(new string[] {
                "Fiction", "Non-Fiction", "Science Fiction", "Biography", "Mystery", "Fantasy", "Historical", "Romance","Educational","Children"
            });
            comboBoxBookType.SelectedIndex = 0;
            int nextId = GenerateNextBookId();
            textBoxid.Text = nextId.ToString();

            LoadSuppliers(comboBoxBookType.SelectedItem.ToString());
            LoadStockData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private int GenerateNextBookId()
        {
            int nextId = 1;

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sql = "SELECT MAX(book_id) FROM Books";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    if (dr[0] != DBNull.Value)
                    {
                        int maxId = Convert.ToInt32(dr[0]);
                        nextId = maxId + 1;
                    }
                }

                dr.Close();
            }
            finally
            {

                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return nextId;

        }
        private void LoadStockData()
        {
            string query = "SELECT * FROM Books";

            using (SqlConnection conn = new SqlConnection(""))//include connection string here
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void LoadSuppliers(string bookType)
        {
            string query = "SELECT supplier_id, supplier_name FROM Suppliers WHERE category  = @bookType";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@bookType", bookType);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable supplierData = new DataTable();

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            adapter.Fill(supplierData);

            comboBox1.DataSource = supplierData;
            comboBox1.DisplayMember = "supplier_name";
            comboBox1.ValueMember = "supplier_id";

            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                int bookId = int.Parse(textBoxid.Text);
                string bookName = textBoxBookName.Text;
                string bookAuthor = textBoxAuthor.Text;
                string publicationName = textBoxPublicationName.Text;
                decimal bookPrice = Convert.ToDecimal(textBoxPrice.Text);
                string bookType = comboBoxBookType.SelectedItem.ToString();
                int quantity = Convert.ToInt32(textBoxQuantity.Text);
                string description = textBoxDescription.Text;
                decimal supplierPrice = Convert.ToDecimal(textBox1.Text);

                int supplierId = Convert.ToInt32(comboBox1.SelectedValue);

                if (string.IsNullOrEmpty(bookName))
                {
                    textBoxBookName.BackColor = Color.LightPink;
                    throw new Exception("Please enter a Book Name.");
                }


                if (string.IsNullOrEmpty(bookAuthor))
                {
                    textBoxAuthor.BackColor = Color.LightPink;
                    throw new Exception("Please enter the Author's Name.");
                }

                if (string.IsNullOrEmpty(publicationName))
                {
                    textBoxPublicationName.BackColor = Color.LightPink;
                    throw new Exception("Please enter the Publication Name.");
                }

                if (string.IsNullOrEmpty(textBoxPrice.Text) || !decimal.TryParse(textBoxPrice.Text, out bookPrice) || bookPrice <= 0)
                {
                    textBoxPrice.BackColor = Color.LightPink;
                    throw new Exception("Please enter a valid Book Price.");
                }

                if (string.IsNullOrEmpty(bookType))
                {
                    comboBoxBookType.BackColor = Color.LightPink;
                    throw new Exception("Please select a Book Type.");
                }

                if (string.IsNullOrEmpty(textBoxQuantity.Text) || !int.TryParse(textBoxQuantity.Text, out quantity) || quantity <= 0)
                {
                    textBoxQuantity.BackColor = Color.LightPink;
                    throw new Exception("Please enter a valid Quantity.");
                }

                if (string.IsNullOrEmpty(description))
                {
                    textBoxDescription.BackColor = Color.LightPink;
                    throw new Exception("Please enter a Book Description.");
                }

                if (comboBox1.SelectedValue == null || !int.TryParse(comboBox1.SelectedValue.ToString(), out supplierId))
                {
                    comboBox1.BackColor = Color.LightPink;
                    throw new Exception("Please select a Supplier.");
                }

                string checkQuery = "SELECT COUNT(*) FROM Books WHERE book_name = '" + bookName + "'";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                int bookCount = (int)checkCmd.ExecuteScalar();

                if (bookCount > 0)
                {

                    string updateQuery = "UPDATE Books SET book_author = '" + bookAuthor + "', publication_name = '" + publicationName + "', " +
                                         "book_price = " + bookPrice + ", book_type = '" + bookType + "', quantity = " + quantity + ", " +
                                         "book_description = '" + description + "', supplier_id = " + supplierId + " WHERE book_name = '" + bookName + "'";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.ExecuteNonQuery();

                    string stockUpdateQuery = "UPDATE Stock SET price = " + bookPrice + ", supplier_price = " + supplierPrice + ", quantity = " + quantity +
                                              " WHERE book_name = '" + bookName + "'";
                    SqlCommand stockUpdateCmd = new SqlCommand(stockUpdateQuery, conn);
                    stockUpdateCmd.ExecuteNonQuery();

                    string inventoryUpdateQuery = "UPDATE Inventory SET current_stock = " + quantity + ", description = 'Record Updated' WHERE book_name = '" + bookName + "'";
                    SqlCommand inventoryUpdateCmd = new SqlCommand(inventoryUpdateQuery, conn);
                    inventoryUpdateCmd.ExecuteNonQuery();
                }
                else
                {

                    string insertQuery = "INSERT INTO Books (book_name, book_author, publication_name, book_price, book_type, quantity, book_description, supplier_id) " +
                                         "VALUES ('" + bookName + "', '" + bookAuthor + "', '" + publicationName + "', " + bookPrice + ", '" + bookType + "', " + quantity + ", '" + description + "', " + supplierId + ")";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.ExecuteNonQuery();

                    string stockInsertQuery = "INSERT INTO Stock (book_id, book_name, price, supplier_price, quantity, supplier_id) " +
                                              "VALUES (" + bookId + ", '" + bookName + "', " + bookPrice + ", " + supplierPrice + ", " + quantity + ", " + supplierId + ")";
                    SqlCommand stockInsertCmd = new SqlCommand(stockInsertQuery, conn);
                    stockInsertCmd.ExecuteNonQuery();

                    string inventoryInsertQuery = "INSERT INTO Inventory (book_id, book_name, initial_stock, current_stock, description) " +
                                                  "VALUES (" + bookId + ", '" + bookName + "', " + quantity + ", " + quantity + ", 'New Record added')";
                    SqlCommand inventoryInsertCmd = new SqlCommand(inventoryInsertQuery, conn);
                    inventoryInsertCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Book added successfully!");

                textBoxAuthor.Clear();
                textBoxBookName.Clear();
                textBoxDescription.Clear();
                textBoxPrice.Clear();
                textBoxPublicationName.Clear();
                textBoxQuantity.Clear();

                textBoxid.Text = GenerateNextBookId().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            LoadStockData();
        }

        private void comboBoxBookType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bookType = comboBoxBookType.SelectedItem.ToString();
            LoadSuppliers(bookType);
        }
    }


}


