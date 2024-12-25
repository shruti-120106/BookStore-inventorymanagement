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
    public partial class Billingform : Form
    {
        private string customerName;
        private string customerAddress;
        private string customerPhone;
        DataTable cartTable;
        public Billingform(string name, string address, string phone)
        {
            InitializeComponent();
            customerName = name;
            customerAddress = address;
            customerPhone = phone;

            label1.Text = customerName;
            label2.Text = customerAddress;
            label3.Text = customerPhone;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Billingform_Load(object sender, EventArgs e)
        {
            LoadCartData();
        }
        private void LoadCartData()
        {
            DataTable cartTable = new DataTable();
            try
            {

                string query = "SELECT * FROM Cart ";


                using (SqlConnection connection = new SqlConnection("")) // add connection string here
                {
                    
                    using (SqlConnection conn = new SqlConnection("")) // add connection string here
                    {
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            connection.Open();

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            cartTable = new DataTable();
                            da.Fill(cartTable);

                            dataGridView1.DataSource = cartTable;

                            connection.Close();
                        }
                    }
                }

                UpdateTotalPrice(cartTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void UpdateTotalPrice(DataTable cartTable)
        {
            double totalPrice = 0;

    
            foreach (DataRow row in cartTable.Rows)
            {
                double price = Convert.ToDouble(row["Total_Price"]);
                totalPrice += price;
            }

            label8.Text = totalPrice.ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustDash customerForm = new CustDash();
            customerForm.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
