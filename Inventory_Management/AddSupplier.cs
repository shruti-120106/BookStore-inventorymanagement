using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management
{

    public partial class AddSupplier : Form
    {
        SqlConnection conn;
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            string str = "";//add connection string here
            conn = new SqlConnection(str);

            GenerateNextSupplierId();
            LoadCategories();
            LoadStockData();
        }

        private void GenerateNextSupplierId()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            conn.Open();
            string sql = "SELECT MAX(supplier_id) FROM Suppliers";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            int nextId = 1;

            if (dr.HasRows)
            {
                dr.Read();
                if (dr[0] != DBNull.Value)
                {
                    int maxId = Convert.ToInt32(dr[0]);
                    nextId = maxId + 1;
                }
            }

            dr.Close();
            conn.Close();

            textBoxID.Text = "S00" + nextId.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoadStockData()
        {
            string query = "SELECT * FROM Suppliers";

            using (SqlConnection conn = new SqlConnection(""))// add connection string here
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }
        private void LoadCategories()
        {
            
            string[] categories = new string[] {
                "Fiction", "Non-Fiction", "Science Fiction", "Biography", "Mystery",
                "Fantasy", "Historical", "Romance", "Educational", "Children"
            };

            comboBox1.Items.AddRange(categories); // Add categories to ComboBox
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private bool IsValidEmail(string email)
        {
            return email.EndsWith("@gmail.com") || email.EndsWith("@yahoo.com");
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string supplierName = textBoxSupplierName.Text;
                string contactPerson = textBoxContactPerson.Text;
                string phoneNumber = textBoxPhoneNumber.Text;
                string email = textBoxEmail.Text;
                string address = textBoxAddress.Text;
                string category = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(supplierName))
                {
                    textBoxSupplierName.BackColor = Color.LightPink;
                    MessageBox.Show("Please enter the Supplier Name.");
                    return;
                }

                if (string.IsNullOrEmpty(contactPerson))
                {
                    textBoxContactPerson.BackColor = Color.LightPink;
                    MessageBox.Show("Please enter the Contact Person's Name.");
                    return;
                }

                if (string.IsNullOrEmpty(phoneNumber))
                {
                    textBoxPhoneNumber.BackColor = Color.LightPink;
                    MessageBox.Show("Please enter a valid Phone Number (10 digits).");
                    return;
                }

                // Email validation using a helper method
                if (!IsValidEmail(email))
                {
                    textBoxEmail.BackColor = Color.LightPink;
                    MessageBox.Show("Please enter a valid email address.");
                    return;
                }

                if (string.IsNullOrEmpty(category))
                {
                    comboBox1.BackColor = Color.LightPink;
                    MessageBox.Show("Please select a category.");
                    comboBox1.BackColor = Color.White;
                    return;
                }

                if (string.IsNullOrEmpty(address))
                {
                    textBoxAddress.BackColor = Color.LightPink;
                    MessageBox.Show("Please enter the Address.");
                    return;
                }

                string query = "INSERT INTO Suppliers (supplier_name, contact_person, phone_number, email, address, category) " +
                        "VALUES ('" + supplierName + "', '" + contactPerson + "', '" + phoneNumber + "', '" + email + "', '" + address + "', '" + category + "')";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Supplier added successfully!");

                textBoxSupplierName.Clear();
                textBoxContactPerson.Clear();
                textBoxPhoneNumber.Clear();
                textBoxEmail.Clear();
                textBoxAddress.Clear();
                comboBox1.SelectedIndex = -1;

                GenerateNextSupplierId();
                LoadStockData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
