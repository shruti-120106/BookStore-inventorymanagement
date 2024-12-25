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
    public partial class ViewOrder : Form
    {
        SqlConnection conn;
        public ViewOrder()
        {
            InitializeComponent();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            
            string str = ""; // add connection string here
            conn = new SqlConnection(str);
            LoadOrderData();
            button1.Text = "Completed";
        }
        private void LoadOrderData()
        {
            conn.Open();
            string query = "SELECT order_id,  order_date, total_amount, book_id, quantity, status FROM Orders";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewOrders.DataSource = dt;

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                
                int orderId = Convert.ToInt32(dataGridViewOrders.SelectedRows[0].Cells["order_id"].Value);
                UpdateOrderStatus(orderId, "Completed");
                LoadOrderData(); 
            }
            else
            {
                MessageBox.Show("Please select an order to mark as completed.");
            }
        }

        private void UpdateOrderStatus(int orderId, string newStatus)
        {
            conn.Open();
            string query = string.Concat("UPDATE Orders SET status = '", newStatus, "' WHERE order_id = ", orderId);
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

    }
}
