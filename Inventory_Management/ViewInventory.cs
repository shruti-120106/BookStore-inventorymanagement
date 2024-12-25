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
    public partial class ViewInventory : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public ViewInventory()
        {
            InitializeComponent();
            string connectionString = ""; // add connection string here
            conn = new SqlConnection(connectionString);
        }

        private void ViewInventory_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void LoadInventory()
        {
            string sql = "SELECT i.inventory_id, " +
                 "b.book_name, " +
                 "i.initial_stock, " +
                 "i.current_stock, " +
                 "i.description, " +
                 "s.supplier_price " +
                 "FROM Inventory i " +
                 "JOIN Books b ON i.book_id = b.book_id " +
                 "JOIN Stock s ON s.book_id = b.book_id " +
                 "ORDER BY i.book_id";
          

            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();

            conn.Open();
            da.Fill(dt);
            conn.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
