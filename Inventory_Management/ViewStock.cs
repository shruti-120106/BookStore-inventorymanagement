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

    public partial class ViewStock : Form
    {
        SqlConnection conn;
        public ViewStock()
        {
            InitializeComponent();
        }

        private void ViewStock_Load(object sender, EventArgs e)
        {
            string connString = ""; // add connection string here
            conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                string query = "SELECT * FROM Stock";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridViewStock.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading stock: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

