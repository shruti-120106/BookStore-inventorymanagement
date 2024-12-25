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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomerForm viewCustomerForm = new ViewCustomerForm();
            viewCustomerForm.ShowDialog();
        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomer manageCustomerForm = new ManageCustomer();
            manageCustomerForm.ShowDialog();
        }

        private void viewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOrder viewOrderForm = new ViewOrder();
            viewOrderForm.ShowDialog();
        }

        private void viewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStock viewStockForm = new ViewStock();
            viewStockForm.ShowDialog();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStock addStockForm = new AddStock();
            addStockForm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStock deleteStockForm = new DeleteStock();
            deleteStockForm.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStocks uStockForm = new UpdateStocks();
            uStockForm.ShowDialog();
        }

        private void viewSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSales vform = new ViewSales();
            vform.ShowDialog();
        }

        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewInventory vform = new ViewInventory();
            vform.ShowDialog();
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplierform sform = new Supplierform();
            sform.ShowDialog();
        }

        private void addSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSupplier aform = new AddSupplier();
            aform.ShowDialog();
        }

        private void deleteSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void deleteSupplierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            deletesupplier dform = new deletesupplier();
            dform.ShowDialog();
        }

        private void lowStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LowStock sform=new LowStock();
            sform.ShowDialog();
        }
    }
}
