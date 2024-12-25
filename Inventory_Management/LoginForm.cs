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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inventory_Management
{
    public partial class LoginForm : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sql, str;
        SqlDataReader dr;
        Random r = new Random();
        string captchaValue;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            str = ""; // add connection string here
            conn = new SqlConnection(str);
            LoadCaptcha();

        }
        private void LoadCaptcha()
        {
            long d = r.Next(1, 22);
            int d1 = Convert.ToInt32(d);

            sql = "SELECT imgpath, imgval FROM imagee WHERE id = " + d1;
            cmd = new SqlCommand(sql, conn);

            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string imgPath = dr[0].ToString();
                captchaValue = dr[1].ToString();
                pictureBoxCaptcha.Image = Image.FromFile(imgPath);
            }

            dr.Close();
            conn.Close();
            cmd.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string enteredCaptcha = textBoxCaptcha.Text;
            string email = textBoxEmail.Text;


            if (string.IsNullOrEmpty(username))
            {
                textBoxUsername.BackColor = Color.LightPink;
                MessageBox.Show("Please enter username.");
                return;
            }

            if (string.IsNullOrEmpty(email))
            {
                textBoxEmail.BackColor = Color.LightPink;
                MessageBox.Show("Please enter valid email address.");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                textBoxPassword.BackColor = Color.LightPink;
                MessageBox.Show("Please enter password.");
                return;
            }

            if (string.IsNullOrEmpty(enteredCaptcha))
            {
                textBoxCaptcha.BackColor = Color.LightPink;
                MessageBox.Show("Please enter CAPTCHA.");
                return;
            }



            if (enteredCaptcha != captchaValue)
            {
                textBoxCaptcha.BackColor = Color.LightPink;
                MessageBox.Show("Invalid CAPTCHA. Please try again.");
                LoadCaptcha();
                return;
            }

            sql = "SELECT user_id, role_new FROM Users WHERE username='" + username + "' AND password='" + password + "' AND email='" + email + "'";
            cmd = new SqlCommand(sql, conn);

            conn.Open();
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                string role = dr["role_new"].ToString();
                int customerId = dr["user_id"] != DBNull.Value ? Convert.ToInt32(dr["user_id"]) : 0;


                if (role == "admin")
                {
                    AdminDashboard adminForm = new AdminDashboard();
                    adminForm.Show();
                }
                else if (role == "employee")
                {
                    CustDash customerForm = new CustDash();
                    customerForm.Show();
                }


                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password or check your email.");
            }

            conn.Close();
            cmd.Dispose();
            dr.Close();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            LoadCaptcha();
            textBoxCaptcha.Clear();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
