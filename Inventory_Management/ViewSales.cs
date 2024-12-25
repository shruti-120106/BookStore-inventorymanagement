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
    public partial class ViewSales : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public ViewSales()
        {
            InitializeComponent();
            string connectionString = ""; // add connection string here
            conn = new SqlConnection(connectionString);
        }

        private void ViewSales_Load(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void LoadSales()
        {
            string sql = "SELECT   b.book_name,  SUM(s.sales_quantity) AS total_quantity,    SUM(s.sales_quantity * b.book_price) AS total_sales_price FROM Sales s INNER JOIN Books b ON s.sales_book_id = b.book_id GROUP BY b.book_name"; 
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt; 
        }
    }
}
