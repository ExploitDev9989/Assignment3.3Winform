namespace Assignment3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "m" && txtpass.Text == "m")
            {
                MessageBox.Show("Welcome Miguel!");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid details, please log in again");
                txtuser.Clear();
                txtpass.Clear();
            }
        }
    }
}
