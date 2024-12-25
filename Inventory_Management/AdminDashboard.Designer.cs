namespace Inventory_Management
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            customerToolStripMenuItem = new ToolStripMenuItem();
            viewCustomerToolStripMenuItem = new ToolStripMenuItem();
            manageCustomerToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            viewOrderToolStripMenuItem = new ToolStripMenuItem();
            stockManagementToolStripMenuItem = new ToolStripMenuItem();
            viewStockToolStripMenuItem = new ToolStripMenuItem();
            addStockToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            viewSalesToolStripMenuItem = new ToolStripMenuItem();
            viewInventoryToolStripMenuItem = new ToolStripMenuItem();
            suppliersToolStripMenuItem = new ToolStripMenuItem();
            viewSupplierToolStripMenuItem = new ToolStripMenuItem();
            addSupplierToolStripMenuItem = new ToolStripMenuItem();
            deleteSupplierToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            lowStockToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PapayaWhip;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { customerToolStripMenuItem, orderToolStripMenuItem, stockManagementToolStripMenuItem, viewSalesToolStripMenuItem, viewInventoryToolStripMenuItem, suppliersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1367, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewCustomerToolStripMenuItem, manageCustomerToolStripMenuItem });
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(105, 29);
            customerToolStripMenuItem.Text = "Customer";
            // 
            // viewCustomerToolStripMenuItem
            // 
            viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            viewCustomerToolStripMenuItem.Size = new Size(257, 34);
            viewCustomerToolStripMenuItem.Text = "view customer";
            viewCustomerToolStripMenuItem.Click += viewCustomerToolStripMenuItem_Click;
            // 
            // manageCustomerToolStripMenuItem
            // 
            manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            manageCustomerToolStripMenuItem.Size = new Size(257, 34);
            manageCustomerToolStripMenuItem.Text = "manage customer";
            manageCustomerToolStripMenuItem.Click += manageCustomerToolStripMenuItem_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewOrderToolStripMenuItem });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(74, 29);
            orderToolStripMenuItem.Text = "Order";
            // 
            // viewOrderToolStripMenuItem
            // 
            viewOrderToolStripMenuItem.Name = "viewOrderToolStripMenuItem";
            viewOrderToolStripMenuItem.Size = new Size(202, 34);
            viewOrderToolStripMenuItem.Text = "View Order";
            viewOrderToolStripMenuItem.Click += viewOrderToolStripMenuItem_Click;
            // 
            // stockManagementToolStripMenuItem
            // 
            stockManagementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewStockToolStripMenuItem, addStockToolStripMenuItem, deleteToolStripMenuItem, updateToolStripMenuItem, lowStockToolStripMenuItem });
            stockManagementToolStripMenuItem.Name = "stockManagementToolStripMenuItem";
            stockManagementToolStripMenuItem.Size = new Size(181, 29);
            stockManagementToolStripMenuItem.Text = "Stock Management";
            // 
            // viewStockToolStripMenuItem
            // 
            viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            viewStockToolStripMenuItem.Size = new Size(270, 34);
            viewStockToolStripMenuItem.Text = "View Stock";
            viewStockToolStripMenuItem.Click += viewStockToolStripMenuItem_Click;
            // 
            // addStockToolStripMenuItem
            // 
            addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            addStockToolStripMenuItem.Size = new Size(270, 34);
            addStockToolStripMenuItem.Text = "Add Stock";
            addStockToolStripMenuItem.Click += addStockToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(270, 34);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(270, 34);
            updateToolStripMenuItem.Text = "Update";
            updateToolStripMenuItem.Click += updateToolStripMenuItem_Click;
            // 
            // viewSalesToolStripMenuItem
            // 
            viewSalesToolStripMenuItem.Name = "viewSalesToolStripMenuItem";
            viewSalesToolStripMenuItem.Size = new Size(110, 29);
            viewSalesToolStripMenuItem.Text = "View Sales";
            viewSalesToolStripMenuItem.Click += viewSalesToolStripMenuItem_Click;
            // 
            // viewInventoryToolStripMenuItem
            // 
            viewInventoryToolStripMenuItem.Name = "viewInventoryToolStripMenuItem";
            viewInventoryToolStripMenuItem.Size = new Size(145, 29);
            viewInventoryToolStripMenuItem.Text = "View Inventory";
            viewInventoryToolStripMenuItem.Click += viewInventoryToolStripMenuItem_Click;
            // 
            // suppliersToolStripMenuItem
            // 
            suppliersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewSupplierToolStripMenuItem, addSupplierToolStripMenuItem, deleteSupplierToolStripMenuItem });
            suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            suppliersToolStripMenuItem.Size = new Size(101, 29);
            suppliersToolStripMenuItem.Text = "Suppliers";
            suppliersToolStripMenuItem.Click += suppliersToolStripMenuItem_Click;
            // 
            // viewSupplierToolStripMenuItem
            // 
            viewSupplierToolStripMenuItem.Name = "viewSupplierToolStripMenuItem";
            viewSupplierToolStripMenuItem.Size = new Size(230, 34);
            viewSupplierToolStripMenuItem.Text = "View Supplier";
            viewSupplierToolStripMenuItem.Click += viewSupplierToolStripMenuItem_Click;
            // 
            // addSupplierToolStripMenuItem
            // 
            addSupplierToolStripMenuItem.Name = "addSupplierToolStripMenuItem";
            addSupplierToolStripMenuItem.Size = new Size(230, 34);
            addSupplierToolStripMenuItem.Text = "Add Supplier";
            addSupplierToolStripMenuItem.Click += addSupplierToolStripMenuItem_Click;
            // 
            // deleteSupplierToolStripMenuItem
            // 
            deleteSupplierToolStripMenuItem.Name = "deleteSupplierToolStripMenuItem";
            deleteSupplierToolStripMenuItem.Size = new Size(230, 34);
            deleteSupplierToolStripMenuItem.Text = "delete supplier";
            deleteSupplierToolStripMenuItem.Click += deleteSupplierToolStripMenuItem_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Linen;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.bgg44;
            pictureBox1.Location = new Point(9, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1346, 588);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1189, 36);
            button1.Name = "button1";
            button1.Size = new Size(166, 39);
            button1.TabIndex = 17;
            button1.Text = "Back to Login Page";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // lowStockToolStripMenuItem
            // 
            lowStockToolStripMenuItem.Name = "lowStockToolStripMenuItem";
            lowStockToolStripMenuItem.Size = new Size(270, 34);
            lowStockToolStripMenuItem.Text = "Low Stock";
            lowStockToolStripMenuItem.Click += lowStockToolStripMenuItem_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 635);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem viewCustomerToolStripMenuItem;
        private ToolStripMenuItem manageCustomerToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem viewOrderToolStripMenuItem;
        private ToolStripMenuItem stockManagementToolStripMenuItem;
        private ToolStripMenuItem viewStockToolStripMenuItem;
        private ToolStripMenuItem addStockToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem viewSalesToolStripMenuItem;
        private ToolStripMenuItem viewInventoryToolStripMenuItem;
        private ToolStripMenuItem suppliersToolStripMenuItem;
        private ToolStripMenuItem viewSupplierToolStripMenuItem;
        private ToolStripMenuItem addSupplierToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button button1;
        private ToolStripMenuItem deleteSupplierToolStripMenuItem;
        private ToolStripMenuItem lowStockToolStripMenuItem;
    }
}