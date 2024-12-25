using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management
{
    public partial class managedash : Form
    {
        public managedash()
        {
            InitializeComponent();
        }

        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewCustomerForm viewCustomerForm = new ViewCustomerForm();
            viewCustomerForm.ShowDialog();
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

        private void viewSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplierform sform = new Supplierform();
            sform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
