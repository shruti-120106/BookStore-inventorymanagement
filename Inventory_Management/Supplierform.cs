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
    public partial class Supplierform : Form
    {
        SqlConnection conn;
        public Supplierform()
        {
            InitializeComponent();
        }

        private void Supplierform_Load(object sender, EventArgs e)
        {
            string connString = ""; // add connection string here
            conn = new SqlConnection(connString);

            // Load supplier data
            LoadSupplierData();
        }
        private void LoadSupplierData()
        {
            //if (conn.State == ConnectionState.Closed)
                conn.Open();

            string query = "SELECT s.supplier_id, s.supplier_name, s.contact_person, s.phone_number, " +
               "s.email, s.address, b.book_id " +
               "FROM Suppliers s " +
               "JOIN Books b ON s.supplier_id = b.supplier_id";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dt;

            conn.Close();
        }
    }
}
