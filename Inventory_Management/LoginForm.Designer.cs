namespace Inventory_Management
{
    partial class LoginForm
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
            label7 = new Label();
            label6 = new Label();
            textBoxEmail = new TextBox();
            label5 = new Label();
            textBoxCaptcha = new TextBox();
            pictureBox2 = new PictureBox();
            btnRegister = new Button();
            label4 = new Label();
            textBoxPassword = new TextBox();
            label1 = new Label();
            btnLogin = new Button();
            pictureBoxCaptcha = new PictureBox();
            label3 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.bgg3;
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1355, 619);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.WhiteSmoke;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxCaptcha);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(pictureBoxCaptcha);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(label2);
            groupBox1.Cursor = Cursors.Hand;
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(334, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(704, 431);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "__";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(432, 33);
            label7.Name = "label7";
            label7.Size = new Size(269, 21);
            label7.TabIndex = 11;
            label7.Text = "(firstname + lastname without space)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 70);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 9;
            label6.Text = "Email";
            label6.Click += label6_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(207, 67);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(219, 31);
            textBoxEmail.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 298);
            label5.Name = "label5";
            label5.Size = new Size(121, 25);
            label5.TabIndex = 9;
            label5.Text = "Enter Captcha";
            // 
            // textBoxCaptcha
            // 
            textBoxCaptcha.Location = new Point(207, 298);
            textBoxCaptcha.Name = "textBoxCaptcha";
            textBoxCaptcha.Size = new Size(219, 31);
            textBoxCaptcha.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.reload;
            pictureBox2.Location = new Point(450, 194);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 28);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SandyBrown;
            btnRegister.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.ButtonHighlight;
            btnRegister.Location = new Point(264, 384);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(112, 34);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 384);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 7;
            label4.Text = "New User?";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(207, 104);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(219, 31);
            textBoxPassword.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 33);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SandyBrown;
            btnLogin.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(264, 335);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // pictureBoxCaptcha
            // 
            pictureBoxCaptcha.Location = new Point(207, 148);
            pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            pictureBoxCaptcha.Size = new Size(219, 131);
            pictureBoxCaptcha.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCaptcha.TabIndex = 3;
            pictureBoxCaptcha.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 194);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 5;
            label3.Text = "Captcha";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(207, 30);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(219, 31);
            textBoxUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 107);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 635);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCaptcha).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label5;
        private TextBox textBoxCaptcha;
        private PictureBox pictureBox2;
        private Button btnRegister;
        private Label label4;
        private TextBox textBoxPassword;
        private Label label1;
        private Button btnLogin;
        private PictureBox pictureBoxCaptcha;
        private Label label3;
        private TextBox textBoxUsername;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label6;
        private Label label7;
    }
}