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
    public partial class ManageCustomer : Form
    {
        SqlConnection conn;
        public ManageCustomer()
        {
            InitializeComponent();
            this.Controls.Add(this.groupBoxDelete1);
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxUpdate.Visible = true;
            groupBoxDelete1.Visible = false;
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            string str = ""; // add connection string here
            conn = new SqlConnection(str);
            groupBoxUpdate.Visible = false;
            groupBoxDelete1.Visible = false;
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            conn.Open();
            string query = "SELECT customer_id, first_name, phone_number, email, address FROM Customers";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewCustomer.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idText = textBox2.Text.Trim();

            // Validate customer ID
            if (string.IsNullOrWhiteSpace(idText) || !IsNumeric(idText))
            {
                MessageBox.Show("Please enter a valid customer ID.");
                return;
            }

            int customerId = Convert.ToInt32(idText);

            string firstName = textBoxFirstName.Text.Trim();
            string lastName = textBoxLastName.Text.Trim();
            string phoneNumber = textBoxPhoneNumber.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string address = textBoxAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                textBoxFirstName.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid first name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                textBoxLastName.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid last name.");
                return;
            }

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                textBoxPhoneNumber.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid phone number.");
                return;
            }

            if (!IsValidEmail(email))
            {
                textBoxEmail.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                textBoxAddress.BackColor = Color.LightPink;
                MessageBox.Show("Please enter a valid address.");
                return;
            }

            string query = "UPDATE Customers SET first_name = '" + firstName + "', last_name = '" + lastName +
                           "', phone_number = '" + phoneNumber + "', email = '" + email + "', address = '" + address +
                           "' WHERE customer_id = " + customerId;

            conn.Open();

            SqlCommand updateCmd = new SqlCommand(query, conn);

            int rowsAffected = updateCmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Customer updated successfully.");
            }
            else
            {
                MessageBox.Show("Update failed. Please check the Customer ID.");
            }

            conn.Close();

            LoadCustomerData();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private bool IsNumeric(string value)
        {

            return int.TryParse(value, out _);
        }

        private bool IsValidEmail(string email)
        {
            return email.EndsWith("@gmail.com") || email.EndsWith("@yahoo.com");
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idText = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(idText) || !IsNumeric(idText))
            {
                MessageBox.Show("Please enter a valid customer ID.");
                return;
            }

            int customerId = Convert.ToInt32(idText);

            try
            {
                conn.Open();

                string UserQuery = "SELECT user_id FROM Customers WHERE customer_id = " + customerId;
                SqlCommand Cmd = new SqlCommand(UserQuery, conn);
                object userIdResult = Cmd.ExecuteScalar();

                if (userIdResult != null)
                {
                    int userId = Convert.ToInt32(userIdResult);

                    string deleteUser = "DELETE FROM Users WHERE user_id = " + userId;
                    SqlCommand deleteUserCmd = new SqlCommand(deleteUser, conn);
                    deleteUserCmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Customer ID not found.");
                    return;
                }

                string deleteCustomer = "DELETE FROM Customers WHERE customer_id = " + customerId;
                Cmd = new SqlCommand(deleteCustomer, conn);
                int rowsAffected = Cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Customer deleted successfully..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            LoadCustomerData();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            groupBoxUpdate.Visible = false;
            groupBoxDelete1.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxUpdate.Visible = false;
            groupBoxDelete1.Visible = true;
        }
    }
}
