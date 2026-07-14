using UberApp.Busineses;
using UberApp.Domain;
using UberApp.Forms;

namespace UberApp
{
    public partial class LoginForm : Form
    {
        List<User> users = null;
        public LoginForm()
        {
            InitializeComponent();
            users = new UserService().GetUsers();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            bool successLogin = false;

            if (users is null || users.Count == 0)
            {
                MessageBox.Show("لطفا ابتدا فایل کانفیگ ورود ادمین ها را ایجاد نمایید.");
                return;
            }

            //Loop over
            for (int i = 0; i < users.Count; i++)
                if (users[i].UserName.Trim().ToLower() == username.Trim().ToLower() && users[i].PasswordHash.Trim() == password.Trim())
                    successLogin = true;

            if (successLogin)
            {
                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();
                return;
            }
            else
            {
                MessageBox.Show("لطفا نام کاربری یا رمز عبور را درست وارد نمایید.");
            }
        }
    }
}
