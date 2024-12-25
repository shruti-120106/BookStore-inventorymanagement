namespace Inventory_Management
{
    partial class managedash
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
            viewCustomerToolStripMenuItem = new ToolStripMenuItem();
            viewOrderToolStripMenuItem = new ToolStripMenuItem();
            viewStockToolStripMenuItem = new ToolStripMenuItem();
            viewSalesToolStripMenuItem = new ToolStripMenuItem();
            viewInventoryToolStripMenuItem = new ToolStripMenuItem();
            viewSuppliersToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.NavajoWhite;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewCustomerToolStripMenuItem, viewOrderToolStripMenuItem, viewStockToolStripMenuItem, viewSalesToolStripMenuItem, viewInventoryToolStripMenuItem, viewSuppliersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1366, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewCustomerToolStripMenuItem
            // 
            viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            viewCustomerToolStripMenuItem.Size = new Size(147, 29);
            viewCustomerToolStripMenuItem.Text = "View Customer";
            viewCustomerToolStripMenuItem.Click += viewCustomerToolStripMenuItem_Click;
            // 
            // viewOrderToolStripMenuItem
            // 
            viewOrderToolStripMenuItem.Name = "viewOrderToolStripMenuItem";
            viewOrderToolStripMenuItem.Size = new Size(116, 29);
            viewOrderToolStripMenuItem.Text = "View Order";
            viewOrderToolStripMenuItem.Click += viewOrderToolStripMenuItem_Click;
            // 
            // viewStockToolStripMenuItem
            // 
            viewStockToolStripMenuItem.Name = "viewStockToolStripMenuItem";
            viewStockToolStripMenuItem.Size = new Size(113, 29);
            viewStockToolStripMenuItem.Text = "View Stock";
            viewStockToolStripMenuItem.Click += viewStockToolStripMenuItem_Click;
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
            // viewSuppliersToolStripMenuItem
            // 
            viewSuppliersToolStripMenuItem.Name = "viewSuppliersToolStripMenuItem";
            viewSuppliersToolStripMenuItem.Size = new Size(143, 29);
            viewSuppliersToolStripMenuItem.Text = "View Suppliers";
            viewSuppliersToolStripMenuItem.Click += viewSuppliersToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1175, 36);
            button1.Name = "button1";
            button1.Size = new Size(191, 44);
            button1.TabIndex = 2;
            button1.Text = "Back to Login Page";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // managedash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1366, 603);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "managedash";
            Text = "managedash";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewCustomerToolStripMenuItem;
        private ToolStripMenuItem viewOrderToolStripMenuItem;
        private ToolStripMenuItem viewStockToolStripMenuItem;
        private ToolStripMenuItem viewSalesToolStripMenuItem;
        private ToolStripMenuItem viewInventoryToolStripMenuItem;
        private ToolStripMenuItem viewSuppliersToolStripMenuItem;
        private Button button1;
    }
}