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
    public partial class UpdateStocks : Form
    {


        public UpdateStocks()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellContentClick;

        }

        private void UpdateStocks_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Fiction");
            comboBox1.Items.Add("Non-Fiction");
            comboBox1.Items.Add("Science Fiction");
            comboBox1.Items.Add("Biography");
            comboBox1.Items.Add("Mystery");
            comboBox1.Items.Add("Fantasy");
            comboBox1.Items.Add("Historical");
            comboBox1.Items.Add("Romance");
            comboBox1.SelectedIndex = 0;
            LoadStockData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idText = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(idText) || !IsNumeric(idText))
            {
                MessageBox.Show("Please enter a valid book ID.");
                return;
            }

            int bookId = Convert.ToInt32(idText);

            string bookName = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(bookName))
            {
                textBox2.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid book name.");
                return;
            }

            string bookAuthor = textBox3.Text.Trim();
            if (string.IsNullOrEmpty(bookAuthor))
            {
                textBox3.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid book author.");
                return;
            }

            string bookType = comboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(bookType))
            {
                comboBox1.BackColor = Color.LightPink;
                MessageBox.Show("Please select a valid book type.");
                return;
            }

            string bookPriceText = textBox4.Text.Trim();
            if (string.IsNullOrEmpty(bookPriceText) || !IsNumeric(bookPriceText))
            {
                textBox4.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid book price.");
                return;
            }


            string bookDescription = textBox5.Text.Trim();
            if (string.IsNullOrEmpty(bookDescription))
            {
                textBox5.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid book description.");
                return;
            }

            string publicationName = textBox6.Text.Trim();
            if (string.IsNullOrEmpty(publicationName))
            {
                textBox6.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid publication name.");
                return;
            }

            string quantityText = textBox7.Text.Trim();
            if (string.IsNullOrEmpty(quantityText) || !IsNumeric(quantityText))
            {
                textBox7.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            int newQuantity = Convert.ToInt32(quantityText);
            decimal bookPrice = Convert.ToDecimal(bookPriceText);

            int currentQuantity = GetCurrentQuantity(bookId);

            // Check if the quantity is changed
            string updatedDescription = bookDescription;
            if (newQuantity != currentQuantity && newQuantity > 0)
            {
                updatedDescription += " Quantity updated to: " + newQuantity;
            }
            else
            {
                MessageBox.Show("Please enter a valid quantity.");

            }

            string updateBooksQuery = "UPDATE Books SET " +
                                   "book_name = '" + bookName + "', " +
                                   "book_author = '" + bookAuthor + "', " +
                                   "book_type = '" + bookType + "', " +
                                   "book_price = " + bookPrice + ", " +
                                   //"supplier_price = " + supplierPrice + ", " +  // Added supplier price
                                   "book_description = '" + bookDescription + "', " +
                                   "publication_name = '" + publicationName + "', " +
                                   "quantity = " + newQuantity +
                                   " WHERE book_id = " + bookId;

            string updateInventoryQuery = "UPDATE Inventory SET " +
                                      "book_name = '" + bookName + "', " +
                                      "description = 'Record/Quantity Updated', " + // Updated description
                                      "current_stock = " + newQuantity + ", " +
                                      "last_updated = GETDATE() " +
                                      "WHERE book_id = " + bookId;

            // Update query for Stock table
            string updateStockQuery = "UPDATE Stock SET " +
                                      "book_name = '" + bookName + "', " +
                                      "price = " + bookPrice + ", " +
                                      //"supplier_price = " + supplierPrice + ", " +
                                      "quantity = " + newQuantity + ", " +
                                      "last_updated = GETDATE() " +
                                      "WHERE book_id = " + bookId;

            using (SqlConnection conn = new SqlConnection("")) // add connection string here
            {
                SqlCommand updateBooksCmd = new SqlCommand(updateBooksQuery, conn);
                SqlCommand updateInventoryCmd = new SqlCommand(updateInventoryQuery, conn);
                SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, conn);

                try
                {
                    conn.Open();

                    int booksRowsAffected = updateBooksCmd.ExecuteNonQuery();
                    int inventoryRowsAffected = updateInventoryCmd.ExecuteNonQuery();
                    int stockRowsAffected = updateStockCmd.ExecuteNonQuery();

                    if (booksRowsAffected > 0 && inventoryRowsAffected > 0 && stockRowsAffected > 0)
                    {
                        MessageBox.Show("Stock and inventory updated successfully.");
                        LoadStockData();
                    }
                    else
                    {
                        MessageBox.Show("Update failed. Please check the Book ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating stock item: " + ex.Message);
                }
            }
        }
        private void LoadStockData()
        {
            string query = "SELECT * FROM Books";

            using (SqlConnection conn = new SqlConnection("")) // add connection string here
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        private bool IsNumeric(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        
         

        private int GetCurrentQuantity(int bookId)
        {
            int currentQuantity = 0;
            string query = "SELECT quantity FROM Books WHERE book_id = @bookId";

            using (SqlConnection conn = new SqlConnection("")) // add connection string here
            {
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@bookId", bookId);

                try
                {
                    conn.Open();
                    currentQuantity = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving current quantity: " + ex.Message);
                }
            }

            return currentQuantity;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate text boxes with values from the selected row
                textBox1.Text = row.Cells["book_id"].Value.ToString();           // Book ID
                textBox2.Text = row.Cells["book_name"].Value.ToString();         // Book Name
                textBox3.Text = row.Cells["book_author"].Value.ToString();       // Author
                comboBox1.SelectedItem = row.Cells["book_type"].Value.ToString(); // Book Type
                textBox4.Text = row.Cells["book_price"].Value.ToString();        // Book Price
                //supplierPriceTextBox.Text = row.Cells["supplier_price"].Value.ToString(); // Supplier Price
                textBox5.Text = row.Cells["book_description"].Value.ToString();  // Description
                textBox6.Text = row.Cells["publication_name"].Value.ToString();  // Publication Name
                textBox7.Text = row.Cells["quantity"].Value.ToString();          // Quantity
            }
        }
    }
}
