namespace Inventory_Management
{
    partial class ViewStock
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
            dataGridViewStock = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStock
            // 
            dataGridViewStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStock.Location = new Point(12, 144);
            dataGridViewStock.Name = "dataGridViewStock";
            dataGridViewStock.RowHeadersWidth = 62;
            dataGridViewStock.Size = new Size(1352, 479);
            dataGridViewStock.TabIndex = 1;
            dataGridViewStock.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(633, 55);
            label1.Name = "label1";
            label1.Size = new Size(139, 48);
            label1.TabIndex = 2;
            label1.Text = "Stock ";
            label1.Click += label1_Click;
            // 
            // ViewStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1367, 635);
            Controls.Add(label1);
            Controls.Add(dataGridViewStock);
            Name = "ViewStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStock";
            Load += ViewStock_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewStock;
        private Label label1;
    }
}