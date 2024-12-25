using Azure;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Inventory_Management
{
    public partial class RegistrationForm : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql;
        public RegistrationForm()
        {
            InitializeComponent();
        }


        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            string str = ""; // add connection string here
            conn = new SqlConnection(str);
            conn.Open();  // Keep the connection open for further use throughout the form lifecycle

            sql = "SELECT MAX(customer_id) FROM Customers";
            cmd = new SqlCommand(sql, conn);
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

            dr.Close();  // Close the reader, but keep the connection open
            textBoxID.Text = "C00" + nextId.ToString();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string username = firstName + lastName;
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string role = "Employee";
            string phoneNumber = textBoxContact.Text;
            string address = textBoxAddress.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill out all fields.");
                return;
            }
            if (IsEmailDuplicate(email))
            {
                MessageBox.Show("A user already exists with this email address.");
                return;
            }

            // Check for duplicate phone number
            if (IsPhoneNumberDuplicate(phoneNumber))
            {
                MessageBox.Show("A user already exists with this phone number.");
                return;
            }

            if (AddRecord(username, firstName, lastName, phoneNumber, email, address, password, role))
            {
                MessageBox.Show("Registration successful.");
            }
            else
            {
                MessageBox.Show("User already exists or cannot register.");
            }//
        }

        private bool AddRecord(string username, string firstName, string lastName, string phoneNumber, string email, string address, string password, string role)
        {
            string userQuery = "INSERT INTO Users (username, password, email, role_new) VALUES ('"
                       + username + "', '" + password + "', '" + email + "', '"
                       + role + "');";

            SqlCommand userCmd = new SqlCommand(userQuery, conn);
            userCmd.ExecuteNonQuery();

            string maxIdQuery = "SELECT MAX(user_id) FROM Users;";
            SqlCommand maxIdCmd = new SqlCommand(maxIdQuery, conn);
            int user_id = Convert.ToInt32(maxIdCmd.ExecuteScalar()); // This will work now because the connection is open

            string customerQuery = "INSERT INTO Customers (user_id, first_name, last_name, phone_number, email, address) VALUES ("
                                   + user_id + ", '" + firstName + "', '" + lastName + "', '"
                                   + phoneNumber + "', '" + email + "', '" + address + "')";

            SqlCommand customerCmd = new SqlCommand(customerQuery, conn);
            int customerResult = customerCmd.ExecuteNonQuery();

            return customerResult > 0;
        }
        private bool IsValidEmail(string email)
        {
            return email.EndsWith("@gmail.com") || email.EndsWith("@yahoo.com");
        }

        private bool IsEmailDuplicate(string email)
        {
            string query = "SELECT COUNT(*) FROM Customers WHERE email = '" + email + "';";
            cmd = new SqlCommand(query, conn);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0; 
        }

        // Method to check if the phone number already exists in the database
        private bool IsPhoneNumberDuplicate(string phoneNumber)
        {
            string query = "SELECT COUNT(*) FROM Customers WHERE phone_number = '" + phoneNumber + "';";
            cmd = new SqlCommand(query, conn);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
