namespace Exam
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        UsersController usersController = new UsersController();
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
        }
        private void GoToRegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;
            
            MainForm mainForm = new MainForm();
            try
            {
                if (usersController.LoginUser(email, password))
                {
                    this.Hide();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден. Неверный логин или пароль!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
            }
        }
    }
}
