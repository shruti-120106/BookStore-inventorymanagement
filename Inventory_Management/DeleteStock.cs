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
    public partial class DeleteStock : Form
    {
        public DeleteStock()
        {
            InitializeComponent();
        }

        private void DeleteStock_Load(object sender, EventArgs e)
        {
            LoadStockData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idText = textBox1.Text.Trim();
            if (string.IsNullOrWhiteSpace(idText) || !IsNumeric(idText))
            {
                MessageBox.Show("Please enter a valid book ID.");
                return;
            }

            int bookId = Convert.ToInt32(idText);

           
            if (!CheckIfBookExists(bookId))
            {
                MessageBox.Show("Book not found in Stock or Inventory.");
                return;
            }

            using (SqlConnection conn = new SqlConnection("")) // add connection string here
            {
                conn.Open();

                string deleteInventoryQuery = "DELETE FROM Inventory WHERE book_id = " + bookId;
                string deleteStockQuery = "DELETE FROM Stock WHERE book_id = " + bookId;

                SqlCommand deleteInventoryCmd = new SqlCommand(deleteInventoryQuery, conn);
                SqlCommand deleteStockCmd = new SqlCommand(deleteStockQuery, conn);

                deleteInventoryCmd.ExecuteNonQuery();
                deleteStockCmd.ExecuteNonQuery();

                string deleteBooksQuery = "DELETE FROM Books WHERE book_id = " + bookId;
                SqlCommand deleteBooksCmd = new SqlCommand(deleteBooksQuery, conn);

                int rowsAffected = deleteBooksCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Stock item deleted successfully.");
                    LoadStockData(); 
                }
                else
                {
                    MessageBox.Show("Deletion failed. Please check the Book ID.");
                }
            }
        }

        private void LoadStockData()
        {
            string query = "SELECT * FROM Books";

            using (SqlConnection conn = new SqlConnection("")) // add connection string here
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                conn.Open();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt; 
            }
        }

        private bool IsNumeric(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckIfBookExists(int bookId)
        {
            string checkQuery = "SELECT COUNT(*) FROM Stock WHERE book_id = " + bookId;
            using (SqlConnection conn = new SqlConnection("")) // add connection string here
            {
                SqlCommand cmd = new SqlCommand(checkQuery, conn);
                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
    }
}
