using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management
{
    public partial class CustDash : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string str;
        SqlDataAdapter da;
        DataTable dt;
        int userId;
        decimal price;
        string name_book;
        public CustDash()
        {
            InitializeComponent();
            //this.userId = customerId;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            textBox1.TextChanged += textBoxQuantity_TextChanged;
        }

        private void CustDash_Load(object sender, EventArgs e)
        {
            str = ""; // add connection string here
            conn = new SqlConnection(str);
            LoadBooks();
            LoadBookTypes();
            ClearCart2();
            //label5.Text = Convert.ToString(this.userId);
        }

        private void LoadBooks()
        {
            string sql = "SELECT book_id, book_name, book_author, book_type, book_price, book_description , quantity FROM Books where quantity>1";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void LoadBookTypes()
        {

            string sql = "SELECT DISTINCT book_type FROM Books";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["book_type"].ToString());
            }

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                textBox1.Text = "1";  // Default quantity is set to 1
                price = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["book_price"].Value);
                name_book = dataGridView1.SelectedRows[0].Cells["book_name"].Value?.ToString();
                textBox2.Text = price.ToString("0.00");
                textBox3.Text = name_book.ToString();
            }

        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int quantity) && price > 0)
            {

                decimal totalAmount = price * quantity;

                textBox2.Text = totalAmount.ToString("0.00");
            }
            else
            {
                textBox2.Clear();
            }
        }

        private void UpdateInventoryTable(int bookId, int initialStock, int newStock)
        {
            string description = "Sale Occured";

            string updateInventorySql = "UPDATE Inventory SET current_stock = " + newStock +
                                        ", last_updated = GETDATE(), description = '" + description + "'" +
                                        " WHERE inventory_book_id = " + bookId;

            cmd = new SqlCommand(updateInventorySql, conn);

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating inventory: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{

            // }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string selectedType = comboBox1.SelectedItem?.ToString();
            string sql;

            if (string.IsNullOrEmpty(selectedType))
            {
                sql = "SELECT book_id, book_name, book_author, book_type, book_price, book_description, quantity FROM Books";
            }
            else
            {
                sql = "SELECT book_id, book_name, book_author, book_type, book_price, book_description, quantity FROM Books WHERE book_type='" + selectedType + "'";
            }

            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                

                int bookId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["book_id"].Value);
                string bookName = dataGridView1.SelectedRows[0].Cells["book_name"].Value.ToString();
                int quantityToPurchase = Convert.ToInt32(textBox1.Text);
                decimal price = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["book_price"].Value);
                int availableQuantity = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["quantity"].Value);
              

                if (quantityToPurchase > availableQuantity)
                {
                    MessageBox.Show("Quantity exceeds available stock.");
                    return;
                }

                decimal totalAmount = price * quantityToPurchase;

               
                conn.Open();
            

                string salesSql = "INSERT INTO Sales ( sales_book_id, sales_quantity, sales_amount) " +
                                  "VALUES ( " + bookId + ", " + quantityToPurchase + ", " + totalAmount + ")";
                cmd = new SqlCommand(salesSql, conn);
                cmd.ExecuteNonQuery();

                string ordersSql = "INSERT INTO Orders ( book_id, quantity, total_amount, order_date, status) " +
                                   "VALUES ( " + bookId + ", " + quantityToPurchase + ", " + totalAmount + ", GETDATE(), 'Process')";
                cmd = new SqlCommand(ordersSql, conn);
                cmd.ExecuteNonQuery();

                int newStock = availableQuantity - quantityToPurchase;
                //string description = "Sale occurred";
                string inventorySql = "UPDATE Inventory SET current_stock = " + newStock +
                      " WHERE book_id = " + bookId;
                cmd = new SqlCommand(inventorySql, conn);
                cmd.ExecuteNonQuery();

                string updateBook = "UPDATE Books SET quantity = " + newStock + " WHERE book_id = " + bookId;
                cmd = new SqlCommand(updateBook, conn);
                cmd.ExecuteNonQuery();

                string stockSql = "UPDATE Stock SET quantity = " + newStock +
                  " WHERE book_id = " + bookId;
                cmd = new SqlCommand(stockSql, conn);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Order successful! Total Amount: " + totalAmount);

                conn.Close();
                LoadBooks();
            }
            else
            {
                MessageBox.Show("Please select a book to purchase.");
            }
        }

        private void viewYourOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                int bookId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["book_id"].Value);
                string bookName = dataGridView1.SelectedRows[0].Cells["book_name"].Value.ToString();
                int quantityToPurchase = Convert.ToInt32(textBox1.Text);
                decimal price = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells["book_price"].Value);

                
                decimal totalAmount = price * quantityToPurchase;

                
                string connStr = ""; // add connection string here

                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();

                        
                        string addToCartSql = "INSERT INTO Cart (book_id, book_name, quantity, total_price) " +
                                              "VALUES (@bookId, @bookName, @quantity, @totalPrice)";
                        using (SqlCommand cmd = new SqlCommand(addToCartSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@bookId", bookId);
                            cmd.Parameters.AddWithValue("@bookName", bookName);
                            cmd.Parameters.AddWithValue("@quantity", quantityToPurchase);
                            cmd.Parameters.AddWithValue("@totalPrice", totalAmount);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Item added to cart successfully!");

                        LoadCart();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding item to cart: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to add to cart.");
            }
        }

        private void LoadCart()
        {
            string sql = "SELECT book_id, book_name, quantity, total_price FROM Cart";  
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                
                string customerName = textBox4.Text.Trim();  // Name
                string contact = textBox5.Text.Trim();       // Contact
                string email = textBox6.Text.Trim();         // Email
                string address = textBox7.Text.Trim();       // Address

                if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(contact) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(address))
                {
                    MessageBox.Show("Please fill all the required fields.");
                    return;
                }

                
                string customerInsertSql = "INSERT INTO Customers (first_name, phone_number, email, address) " +
                                           "VALUES (@customerName, @contact, @email, @address); SELECT SCOPE_IDENTITY();";
                int customerId;

                using (SqlCommand cmdCustomer = new SqlCommand(customerInsertSql, conn))
                {
                    cmdCustomer.Parameters.AddWithValue("@customerName", customerName);
                    cmdCustomer.Parameters.AddWithValue("@contact", contact);
                    cmdCustomer.Parameters.AddWithValue("@email", email);
                    cmdCustomer.Parameters.AddWithValue("@address", address);

                    conn.Open();
                    customerId = Convert.ToInt32(cmdCustomer.ExecuteScalar());
                    conn.Close();
                }

                if (customerId <= 0)
                {
                    MessageBox.Show("Error adding customer.");
                    return; 
                }

                ProcessCartItems(customerId);

                
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.IsNewRow) continue; 

                    int bookId = Convert.ToInt32(row.Cells["book_id"].Value);
                    int quantityToPurchase = Convert.ToInt32(row.Cells["quantity"].Value);

                    // Check available quantity
                    int availableQuantity;
                    string getAvailableQuantitySql = "SELECT quantity FROM Books WHERE book_id = @bookId";

                    using (SqlCommand cmdQuantity = new SqlCommand(getAvailableQuantitySql, conn))
                    {
                        cmdQuantity.Parameters.AddWithValue("@bookId", bookId);

                        conn.Open();
                        availableQuantity = Convert.ToInt32(cmdQuantity.ExecuteScalar());
                        conn.Close();
                    }

                    if (availableQuantity < quantityToPurchase)
                    {
                        MessageBox.Show($"Insufficient stock for book ID {bookId}. Available: {availableQuantity}, Requested: {quantityToPurchase}");
                        continue; 
                    }

                    // Update stock
                    int newStock = availableQuantity - quantityToPurchase;

                    string updateBookSql = "UPDATE Books SET quantity = @newStock WHERE book_id = @bookId";
                    using (SqlCommand cmdUpdateBook = new SqlCommand(updateBookSql, conn))
                    {
                        cmdUpdateBook.Parameters.AddWithValue("@newStock", newStock);
                        cmdUpdateBook.Parameters.AddWithValue("@bookId", bookId);

                        conn.Open();
                        cmdUpdateBook.ExecuteNonQuery();
                        conn.Close();
                    }

                    string updateStockSql = "UPDATE Stock SET quantity = @newStock WHERE book_id = @bookId";
                    using (SqlCommand cmdUpdateStock = new SqlCommand(updateStockSql, conn))
                    {
                        cmdUpdateStock.Parameters.AddWithValue("@newStock", newStock);
                        cmdUpdateStock.Parameters.AddWithValue("@bookId", bookId);

                        conn.Open();
                        cmdUpdateStock.ExecuteNonQuery();
                        conn.Close();
                    }

                    string updateInventorySql = "UPDATE Inventory SET current_stock = @newStock WHERE book_id = @bookId";
                    using (SqlCommand cmdUpdateInventory = new SqlCommand(updateInventorySql, conn))
                    {
                        cmdUpdateInventory.Parameters.AddWithValue("@newStock", newStock);
                        cmdUpdateInventory.Parameters.AddWithValue("@bookId", bookId);

                        conn.Open();
                        cmdUpdateInventory.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                MessageBox.Show("Stock updated successfully for all items.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while processing: " + ex.Message);
            }
        }

        private void ProcessCartItems(int customerId)
        {
            
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;

                int bookId = Convert.ToInt32(row.Cells["book_id"].Value);
                string bookName = row.Cells["book_name"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                decimal totalPrice = Convert.ToDecimal(row.Cells["total_price"].Value);
                string customerName = textBox4.Text; 
                string contact = textBox5.Text;

                try
                {
                    
                    string orderInsertSql = "INSERT INTO Orders (book_id, quantity, total_amount, order_date, customer_name, phone_number) " +
                        "VALUES (@bookId, @quantity, @totalPrice, GETDATE(), @customerName, @contact)";

                    
                    cmd = new SqlCommand(orderInsertSql, conn);

                    // Add parameters to the SqlCommand
                    cmd.Parameters.AddWithValue("@bookId", bookId);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@totalPrice", totalPrice);
                    cmd.Parameters.AddWithValue("@customerName", customerName); 
                    cmd.Parameters.AddWithValue("@contact", contact);            

                    
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while processing cart items: " + ex.Message);
                }
            }

            
            MessageBox.Show("Order placed successfully!");
            ClearCart();
            LoadBooks();
        }

        private void ClearCart()
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string customerName = textBox4.Text; 
            string contact = textBox5.Text;          
            string address = textBox7.Text;           

          
            Billingform bform = new Billingform(customerName, contact, address);

            bform.Show();

        }
        private void ClearCart2()
        {
            try
            {
                
                string clearCartSql = "DELETE FROM Cart";
                cmd = new SqlCommand(clearCartSql, conn);

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error clearing cart: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                
                int bookId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["book_id"].Value);

                string deleteSql = "DELETE FROM Cart WHERE book_id = @bookId";

                try
                {
                    
                    using (SqlConnection conn = new SqlConnection(str))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(deleteSql, conn))
                        {
                            cmd.Parameters.AddWithValue("@bookId", bookId);
                            cmd.ExecuteNonQuery();
                        }

                        
                        LoadCart();
                        MessageBox.Show("Item removed from cart.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error removing item from cart: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }
    }
}
