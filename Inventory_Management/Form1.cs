namespace Inventory_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            progressBar1.Minimum = 0; 
            progressBar1.Maximum = 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerFlashing.Interval = 500;
            timerFlashing.Start(); 
            
            timerProgressBar.Interval = 200; 
            timerProgressBar.Start();
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10; 
            }
            else
            {
                
                timerProgressBar.Stop();
                timerFlashing.Stop();
                LoginForm loginForm = new LoginForm();
                loginForm.Show(); 
                this.Hide();
            }
        }

        private void labelProjectName_Click(object sender, EventArgs e)
        {

        }

        private void timerFlashing_Tick(object sender, EventArgs e)
        {
            labelProjectName.Visible = !labelProjectName.Visible;
        }
    }
}
