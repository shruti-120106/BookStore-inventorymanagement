using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class OrderHistoryForm : Form
    {
        private int customerId; // Customer ID passed from the calling form
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        public OrderHistoryForm(int customerId)
        {
            InitializeComponent();
            this.customerId = customerId;  // Use the passed customerId directly
            Console.WriteLine("Customer ID: " + customerId);  // Debugging: Output the customerId
            conn = new SqlConnection(""); // add connection string here
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Check if customerId is valid
                if (customerId != 0)
                {
                    Console.WriteLine("Valid Customer ID found: " + customerId);  // Debugging: Check if customerId is valid
                    LoadOrderHistory();  // Load the order history for the passed customer_id
                }
                else
                {
                    MessageBox.Show("Invalid Customer ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching customer data: " + ex.Message);
            }
        }

        private void LoadOrderHistory()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sql = string.Format(
                    "SELECT o.order_id, b.book_name, o.quantity, o.total_amount, o.order_date, o.status " +
                    "FROM Orders o " +
                    "INNER JOIN Books b ON o.book_id = b.book_id " +
                    "WHERE o.customer_id = {0}", customerId);

                Console.WriteLine("SQL Query: " + sql);  

                cmd = new SqlCommand(sql, conn);

                
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                Console.WriteLine("Rows retrieved: " + dt.Rows.Count);  
                
                dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No orders found for this customer.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order history: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

    }
}

