namespace Inventory_Management
{
    partial class ViewCustomerForm
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
            dataGridViewCustomers = new DataGridView();
            buttonRefresh = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(12, 149);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 62;
            dataGridViewCustomers.Size = new Size(1343, 474);
            dataGridViewCustomers.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.SandyBrown;
            buttonRefresh.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRefresh.ForeColor = SystemColors.ButtonHighlight;
            buttonRefresh.Location = new Point(1243, 109);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(112, 34);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(578, 57);
            label1.Name = "label1";
            label1.Size = new Size(228, 48);
            label1.TabIndex = 2;
            label1.Text = "Customers";
            // 
            // ViewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1367, 635);
            Controls.Add(label1);
            Controls.Add(buttonRefresh);
            Controls.Add(dataGridViewCustomers);
            Name = "ViewCustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewCustomerForm";
            Load += ViewCustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCustomers;
        private Button buttonRefresh;
        private Label label1;
    }
}