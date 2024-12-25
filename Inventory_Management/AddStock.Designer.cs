namespace Inventory_Management
{
    partial class AddStock
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
            groupBox1 = new GroupBox();
            label10 = new Label();
            textBox1 = new TextBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            comboBoxBookType = new ComboBox();
            label8 = new Label();
            textBoxDescription = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBoxQuantity = new TextBox();
            textBoxPrice = new TextBox();
            textBoxPublicationName = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxBookName = new TextBox();
            textBoxid = new TextBox();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(comboBoxBookType);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxDescription);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxQuantity);
            groupBox1.Controls.Add(textBoxPrice);
            groupBox1.Controls.Add(textBoxPublicationName);
            groupBox1.Controls.Add(textBoxAuthor);
            groupBox1.Controls.Add(textBoxBookName);
            groupBox1.Controls.Add(textBoxid);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(25, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 527);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "__";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 271);
            label10.Name = "label10";
            label10.Size = new Size(119, 25);
            label10.TabIndex = 21;
            label10.Text = "Supplier Price";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 232);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 20;
            label9.Text = "Supplier";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(121, 232);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 19;
            // 
            // comboBoxBookType
            // 
            comboBoxBookType.FormattingEnabled = true;
            comboBoxBookType.Location = new Point(121, 190);
            comboBoxBookType.Name = "comboBoxBookType";
            comboBoxBookType.Size = new Size(182, 33);
            comboBoxBookType.TabIndex = 18;
            comboBoxBookType.SelectedIndexChanged += comboBoxBookType_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 385);
            label8.Name = "label8";
            label8.Size = new Size(102, 25);
            label8.TabIndex = 17;
            label8.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(121, 382);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(150, 31);
            textBoxDescription.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 348);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 15;
            label7.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 193);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 14;
            label6.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 308);
            label5.Name = "label5";
            label5.Size = new Size(49, 25);
            label5.TabIndex = 13;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 153);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 12;
            label4.Text = "Publication";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 116);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 11;
            label3.Text = "Book Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 10;
            label2.Text = "Book Name";
            // 
            // textBoxQuantity
            // 
            textBoxQuantity.Location = new Point(121, 345);
            textBoxQuantity.Name = "textBoxQuantity";
            textBoxQuantity.Size = new Size(150, 31);
            textBoxQuantity.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(121, 308);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(150, 31);
            textBoxPrice.TabIndex = 6;
            // 
            // textBoxPublicationName
            // 
            textBoxPublicationName.Location = new Point(121, 153);
            textBoxPublicationName.Name = "textBoxPublicationName";
            textBoxPublicationName.Size = new Size(150, 31);
            textBoxPublicationName.TabIndex = 5;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(121, 116);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(150, 31);
            textBoxAuthor.TabIndex = 4;
            // 
            // textBoxBookName
            // 
            textBoxBookName.Location = new Point(121, 79);
            textBoxBookName.Name = "textBoxBookName";
            textBoxBookName.Size = new Size(150, 31);
            textBoxBookName.TabIndex = 3;
            // 
            // textBoxid
            // 
            textBoxid.Location = new Point(121, 42);
            textBoxid.Name = "textBoxid";
            textBoxid.Size = new Size(150, 31);
            textBoxid.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 42);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 1;
            label1.Text = "Id";
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(140, 428);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(982, 527);
            dataGridView1.TabIndex = 17;
            // 
            // AddStock
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1367, 635);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "AddStock";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStock";
            Load += AddStock_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label10;
        private TextBox textBox1;
        private Label label9;
        private ComboBox comboBox1;
        private ComboBox comboBoxBookType;
        private Label label8;
        private TextBox textBoxDescription;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxQuantity;
        private TextBox textBoxPrice;
        private TextBox textBoxPublicationName;
        private TextBox textBoxAuthor;
        private TextBox textBoxBookName;
        private TextBox textBoxid;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
    }
}