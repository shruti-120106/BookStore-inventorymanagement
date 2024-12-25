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
    public partial class ViewCustomerForm : Form
    {
        SqlConnection conn;
        public ViewCustomerForm()
        {
            InitializeComponent();
        }

        private void ViewCustomerForm_Load(object sender, EventArgs e)
        {
            string str = ""; // add connection string here
            conn = new SqlConnection(str);
            LoadCustomerData();
        }
        private void LoadCustomerData()
        {
            conn.Open();
            string query = "SELECT customer_id, first_name,  phone_number, email, address FROM Customers";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewCustomers.DataSource = dt;
            conn.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomerData(); 
        }
    }
}
