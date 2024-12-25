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
    public partial class deletesupplier : Form
    {
        SqlConnection conn;
        public deletesupplier()
        {
            InitializeComponent();
            // Provide the correct connection string here
            string connectionString = "";
            conn = new SqlConnection(connectionString);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deletesupplier_Load(object sender, EventArgs e)
        {
            LoadSuppliersData();
        }

        private bool IsNumeric(string input)
        {
            return int.TryParse(input, out _);
        }

        private void LoadSuppliers()
        {
            // Load suppliers into a DataGridView or ComboBox for selection
            string sql = "SELECT supplier_id, supplier_name, book_id, book_name " +
             "FROM Suppliers " +
             "JOIN Books ON Suppliers.supplier_id = Books.supplier_id " +
             "WHERE Suppliers.supplier_id = @SupplierID AND Books.book_id = @BookID";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string supplierIdText = textBox1.Text.Trim();

            // Validate the Supplier ID
            if (string.IsNullOrWhiteSpace(supplierIdText) || !int.TryParse(supplierIdText, out int supplierId))
            {
                MessageBox.Show("Please enter a valid supplier ID.");
                return;
            }

            // Call the method to delete supplier and related records
            DeleteSupplierAndBooks(supplierId);
        }

        private void LoadSuppliersData()
        {
            try
            {
                string query = "SELECT * FROM Suppliers"; // Example query to load suppliers (you may change it)
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();

                conn.Open();
                da.Fill(dt);
                conn.Close();

                // Bind the data to a DataGridView (assuming it's named dataGridViewSuppliers)
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading supplier data: " + ex.Message);
            }
        }

        private void DeleteSupplierAndBooks(int supplierId)
        {
            try
            {
                conn.Open();

                // Step 1: Delete Inventory records that reference the books supplied by this supplier
                string deleteInventoryQuery = "DELETE FROM Inventory WHERE book_id IN (SELECT book_id FROM Books WHERE supplier_id = @SupplierId)";
                SqlCommand deleteInventoryCmd = new SqlCommand(deleteInventoryQuery, conn);
                deleteInventoryCmd.Parameters.AddWithValue("@SupplierId", supplierId);
                deleteInventoryCmd.ExecuteNonQuery();

                // Step 2: Delete Books supplied by this supplier
                string deleteBooksQuery = "DELETE FROM Books WHERE supplier_id = @SupplierId";
                SqlCommand deleteBooksCmd = new SqlCommand(deleteBooksQuery, conn);
                deleteBooksCmd.Parameters.AddWithValue("@SupplierId", supplierId);
                deleteBooksCmd.ExecuteNonQuery();

                // Step 3: Finally, delete the Supplier record
                string deleteSupplierQuery = "DELETE FROM Suppliers WHERE supplier_id = @SupplierId";
                SqlCommand deleteSupplierCmd = new SqlCommand(deleteSupplierQuery, conn);
                deleteSupplierCmd.Parameters.AddWithValue("@SupplierId", supplierId);
                deleteSupplierCmd.ExecuteNonQuery();

                MessageBox.Show("Supplier and associated books and inventory deleted successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

    }
}
