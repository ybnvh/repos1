namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (rdbAdmin.Checked)
            {
                fAdmin fAdmin = new fAdmin();
                this.Hide();
                fAdmin.ShowDialog();
            }
            if (rdbStaff.Checked)
            {
                fStaff fStaff = new fStaff();
                this.Hide();
                fStaff.ShowDialog();    
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e) { }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure ?", "Notify", MessageBoxButtons.OKCancel)!= DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}