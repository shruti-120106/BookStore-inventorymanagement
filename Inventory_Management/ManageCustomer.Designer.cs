namespace Inventory_Management
{
    partial class ManageCustomer
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
            updateCustomerToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            groupBoxUpdate = new GroupBox();
            groupBoxDelete1 = new GroupBox();
            button3 = new Button();
            label8 = new Label();
            textBox2 = new TextBox();
            groupBoxDelete = new GroupBox();
            label7 = new Label();
            button2 = new Button();
            textBox7 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            textBoxAddress = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            textBox1 = new TextBox();
            dataGridViewCustomer = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBoxUpdate.SuspendLayout();
            groupBoxDelete1.SuspendLayout();
            groupBoxDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.PapayaWhip;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { updateCustomerToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem4 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1367, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // updateCustomerToolStripMenuItem
            // 
            updateCustomerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            updateCustomerToolStripMenuItem.Name = "updateCustomerToolStripMenuItem";
            updateCustomerToolStripMenuItem.Size = new Size(168, 29);
            updateCustomerToolStripMenuItem.Text = "Update Customer";
            updateCustomerToolStripMenuItem.Click += updateCustomerToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(164, 34);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(16, 29);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(16, 29);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(160, 29);
            toolStripMenuItem4.Text = "Delete Customer";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // groupBoxUpdate
            // 
            groupBoxUpdate.Controls.Add(groupBoxDelete1);
            groupBoxUpdate.Controls.Add(groupBoxDelete);
            groupBoxUpdate.Controls.Add(label6);
            groupBoxUpdate.Controls.Add(label5);
            groupBoxUpdate.Controls.Add(label4);
            groupBoxUpdate.Controls.Add(label3);
            groupBoxUpdate.Controls.Add(label2);
            groupBoxUpdate.Controls.Add(label1);
            groupBoxUpdate.Controls.Add(button1);
            groupBoxUpdate.Controls.Add(textBoxAddress);
            groupBoxUpdate.Controls.Add(textBoxEmail);
            groupBoxUpdate.Controls.Add(textBoxPhoneNumber);
            groupBoxUpdate.Controls.Add(textBoxLastName);
            groupBoxUpdate.Controls.Add(textBoxFirstName);
            groupBoxUpdate.Controls.Add(textBox1);
            groupBoxUpdate.Location = new Point(12, 47);
            groupBoxUpdate.Name = "groupBoxUpdate";
            groupBoxUpdate.Size = new Size(274, 402);
            groupBoxUpdate.TabIndex = 1;
            groupBoxUpdate.TabStop = false;
            groupBoxUpdate.Text = "groupBox1";
            // 
            // groupBoxDelete1
            // 
            groupBoxDelete1.Controls.Add(button3);
            groupBoxDelete1.Controls.Add(label8);
            groupBoxDelete1.Controls.Add(textBox2);
            groupBoxDelete1.Location = new Point(3, 30);
            groupBoxDelete1.Name = "groupBoxDelete1";
            groupBoxDelete1.Size = new Size(265, 402);
            groupBoxDelete1.TabIndex = 3;
            groupBoxDelete1.TabStop = false;
            groupBoxDelete1.Text = "groupBoxDelete1";
            // 
            // button3
            // 
            button3.BackColor = Color.SandyBrown;
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(84, 106);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 10;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 61);
            label8.Name = "label8";
            label8.Size = new Size(28, 25);
            label8.TabIndex = 9;
            label8.Text = "Id";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // groupBoxDelete
            // 
            groupBoxDelete.Controls.Add(label7);
            groupBoxDelete.Controls.Add(button2);
            groupBoxDelete.Controls.Add(textBox7);
            groupBoxDelete.Location = new Point(265, 67);
            groupBoxDelete.Name = "groupBoxDelete";
            groupBoxDelete.Size = new Size(270, 391);
            groupBoxDelete.TabIndex = 3;
            groupBoxDelete.TabStop = false;
            groupBoxDelete.Text = "groupBox2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 65);
            label7.Name = "label7";
            label7.Size = new Size(28, 25);
            label7.TabIndex = 9;
            label7.Text = "Id";
            // 
            // button2
            // 
            button2.Location = new Point(77, 105);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 7;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(59, 62);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 218);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 13;
            label6.Text = "address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 184);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 12;
            label5.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 147);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 11;
            label4.Text = "phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 110);
            label3.Name = "label3";
            label3.Size = new Size(88, 25);
            label3.TabIndex = 10;
            label3.Text = "last name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 73);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 9;
            label2.Text = "first name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 33);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 8;
            label1.Text = "Id";
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(127, 266);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(109, 215);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(150, 31);
            textBoxAddress.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(109, 178);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(150, 31);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(109, 141);
            textBoxPhoneNumber.MaxLength = 10;
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(150, 31);
            textBoxPhoneNumber.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(109, 104);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(150, 31);
            textBoxLastName.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(109, 67);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(150, 31);
            textBoxFirstName.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Location = new Point(302, 47);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowHeadersWidth = 62;
            dataGridViewCustomer.Size = new Size(1053, 576);
            dataGridViewCustomer.TabIndex = 2;
            dataGridViewCustomer.CellContentClick += dataGridViewCustomer_CellContentClick;
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1367, 635);
            Controls.Add(dataGridViewCustomer);
            Controls.Add(groupBoxUpdate);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ManageCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomer";
            Load += ManageCustomer_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBoxUpdate.ResumeLayout(false);
            groupBoxUpdate.PerformLayout();
            groupBoxDelete1.ResumeLayout(false);
            groupBoxDelete1.PerformLayout();
            groupBoxDelete.ResumeLayout(false);
            groupBoxDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem updateCustomerToolStripMenuItem;
        private ToolStripMenuItem deleteCustomerToolStripMenuItem;
        private GroupBox groupBoxUpdate;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox textBoxAddress;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private TextBox textBox1;
        private DataGridView dataGridViewCustomer;
        private GroupBox groupBoxDelete;
        private Button button2;
        private TextBox textBox7;
        private Label label7;
        private GroupBox groupBoxDelete1;
        private Button button3;
        private Label label8;
        private TextBox textBox2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}