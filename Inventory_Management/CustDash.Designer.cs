namespace Inventory_Management
{
    partial class CustDash
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
            button3 = new Button();
            groupBox1 = new GroupBox();
            label9 = new Label();
            button7 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            button6 = new Button();
            button5 = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            button4 = new Button();
            textBox3 = new TextBox();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            viewYourOrdersToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Linen;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.bgg3;
            pictureBox1.Location = new Point(6, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1590, 824);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SandyBrown;
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(1386, 482);
            button3.Name = "button3";
            button3.Size = new Size(175, 35);
            button3.TabIndex = 17;
            button3.Text = "Back to Login Page";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Linen;
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox7);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(dataGridView2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(22, 331);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1567, 517);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "--";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(746, 402);
            label9.Name = "label9";
            label9.Size = new Size(220, 21);
            label9.TabIndex = 37;
            label9.Text = "Select Item to Delete from cart";
            // 
            // button7
            // 
            button7.BackColor = Color.SandyBrown;
            button7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(746, 426);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 36;
            button7.Text = "Delete";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(876, 231);
            label8.Name = "label8";
            label8.Size = new Size(77, 25);
            label8.TabIndex = 35;
            label8.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(841, 175);
            label7.Name = "label7";
            label7.Size = new Size(136, 25);
            label7.TabIndex = 34;
            label7.Text = "Customer Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(827, 118);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 33;
            label6.Text = "Customer Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(841, 69);
            label5.Name = "label5";
            label5.Size = new Size(141, 25);
            label5.TabIndex = 32;
            label5.Text = "Customer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 84);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 31;
            label4.Text = "Item Selected";
            // 
            // button6
            // 
            button6.BackColor = Color.SandyBrown;
            button6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(1011, 316);
            button6.Name = "button6";
            button6.Size = new Size(155, 34);
            button6.TabIndex = 30;
            button6.Text = "Bill Generate";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SandyBrown;
            button5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(1011, 276);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 29;
            button5.Text = "Order";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(1011, 228);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(279, 31);
            textBox7.TabIndex = 28;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1011, 169);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(279, 31);
            textBox6.TabIndex = 27;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1011, 112);
            textBox5.MaxLength = 10;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(279, 31);
            textBox5.TabIndex = 26;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1011, 63);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(279, 31);
            textBox4.TabIndex = 25;
            // 
            // button4
            // 
            button4.BackColor = Color.SandyBrown;
            button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(281, 188);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 24;
            button4.Text = "Add to Cart";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 81);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(182, 31);
            textBox3.TabIndex = 23;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(49, 228);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(672, 283);
            dataGridView2.TabIndex = 22;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 8;
            label1.Text = "Search the genre";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(366, 27);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 140);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 9;
            label2.Text = "Quantity";
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(746, 477);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Order";
            button2.UseVisualStyleBackColor = false;
            button2.Visible = false;
            button2.Click += button2_Click_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 188);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(78, 31);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 194);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 10;
            label3.Text = "Total Price";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 134);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(78, 31);
            textBox1.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1567, 279);
            dataGridView1.TabIndex = 21;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Moccasin;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewYourOrdersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1608, 24);
            menuStrip1.TabIndex = 22;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewYourOrdersToolStripMenuItem
            // 
            viewYourOrdersToolStripMenuItem.Name = "viewYourOrdersToolStripMenuItem";
            viewYourOrdersToolStripMenuItem.Size = new Size(164, 29);
            viewYourOrdersToolStripMenuItem.Text = "View Your Orders";
            viewYourOrdersToolStripMenuItem.Visible = false;
            viewYourOrdersToolStripMenuItem.Click += viewYourOrdersToolStripMenuItem_Click;
            // 
            // CustDash
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1608, 860);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CustDash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustDash";
            Load += CustDash_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button3;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewYourOrdersToolStripMenuItem;
        private Label label1;
        private DataGridView dataGridView2;
        private TextBox textBox3;
        private Button button4;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Button button5;
        private TextBox textBox7;
        private Button button6;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label9;
        private Button button7;
    }
}