namespace Inventory_Management
{
    partial class AddSupplier
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
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            label6 = new Label();
            button1 = new Button();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            textBoxAddress = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhoneNumber = new TextBox();
            textBoxContactPerson = new TextBox();
            textBoxSupplierName = new TextBox();
            textBoxID = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Linen;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.bgg3;
            pictureBox1.Location = new Point(9, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1349, 613);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(300, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1044, 534);
            dataGridView1.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxAddress);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxPhoneNumber);
            groupBox1.Controls.Add(textBoxContactPerson);
            groupBox1.Controls.Add(textBoxSupplierName);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(272, 534);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "__";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-5, 336);
            label6.Name = "label6";
            label6.Size = new Size(77, 25);
            label6.TabIndex = 4;
            label6.Text = "Address";
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(97, 397);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 145);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 4;
            label3.Text = "Person";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 292);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-1, 193);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 4;
            label4.Text = "Contact";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 96);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(78, 336);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(150, 31);
            textBoxAddress.TabIndex = 4;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(78, 289);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(150, 31);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(78, 190);
            textBoxPhoneNumber.MaxLength = 10;
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(150, 31);
            textBoxPhoneNumber.TabIndex = 4;
            // 
            // textBoxContactPerson
            // 
            textBoxContactPerson.Location = new Point(78, 139);
            textBoxContactPerson.Name = "textBoxContactPerson";
            textBoxContactPerson.Size = new Size(150, 31);
            textBoxContactPerson.TabIndex = 4;
            // 
            // textBoxSupplierName
            // 
            textBoxSupplierName.Location = new Point(78, 90);
            textBoxSupplierName.Name = "textBoxSupplierName";
            textBoxSupplierName.Size = new Size(150, 31);
            textBoxSupplierName.TabIndex = 4;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(78, 41);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(150, 31);
            textBoxID.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(78, 241);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 33);
            comboBox1.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-5, 244);
            label7.Name = "label7";
            label7.Size = new Size(84, 25);
            label7.TabIndex = 7;
            label7.Text = "Category";
            // 
            // AddSupplier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 635);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "AddSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSupplier";
            Load += AddSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label label6;
        private Button button1;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label2;
        private TextBox textBoxAddress;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private TextBox textBoxContactPerson;
        private TextBox textBoxSupplierName;
        private TextBox textBoxID;
        private Label label1;
        private Label label7;
        private ComboBox comboBox1;
    }
}