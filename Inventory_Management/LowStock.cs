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

namespace Inventory_Management
{
    public partial class LowStock : Form
    {
        SqlConnection conn;
        public LowStock()
        {
            InitializeComponent();

        }
        string str = ""; // add connection string here
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LowStock_Load(object sender, EventArgs e)
        {
            LoadLowStockBooks();
        }
        private void LoadLowStockBooks()
        {
            // SQL query to get books with quantity less than 5
            string query = "SELECT book_id, book_name, book_author, supplier_id ,quantity FROM Books WHERE quantity < 5";

   
            DataTable dt = new DataTable();

            try
            {
                // Open a connection and execute the query
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        // Fill the DataTable with the results
                        da.Fill(dt);
                    }
                }

                // Bind the data to the DataGridView
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading low stock data: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Products Ordered to respective Suppliers");
        }
    }
}
