namespace UberApp.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRegistrationForm userRegistrationForm = new UserRegistrationForm();
            userRegistrationForm.ShowDialog();
        }

        private void carRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarRegistrationForm carRegistrationForm = new CarRegistrationForm();
            carRegistrationForm.ShowDialog();
        }
    }
}
