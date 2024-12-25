namespace Inventory_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timerProgressBar = new System.Windows.Forms.Timer(components);
            timerFlashing = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            labelProjectName = new Label();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // timerProgressBar
            // 
            timerProgressBar.Tick += timerProgressBar_Tick;
            // 
            // timerFlashing
            // 
            timerFlashing.Tick += timerFlashing_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.bgg1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1343, 611);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelProjectName);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(220, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(926, 380);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "__";
            // 
            // labelProjectName
            // 
            labelProjectName.AutoSize = true;
            labelProjectName.Font = new Font("Stencil", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelProjectName.Location = new Point(89, 90);
            labelProjectName.Name = "labelProjectName";
            labelProjectName.Size = new Size(768, 67);
            labelProjectName.TabIndex = 0;
            labelProjectName.Text = "BOOK STORE MANAGEMENT";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(168, 292);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(616, 13);
            progressBar1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(406, 329);
            label2.Name = "label2";
            label2.Size = new Size(121, 31);
            label2.TabIndex = 2;
            label2.Text = "Loading...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 635);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BOOKSTORE";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timerProgressBar;
        private System.Windows.Forms.Timer timerFlashing;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label labelProjectName;
        private ProgressBar progressBar1;
        private Label label2;
    }
}
