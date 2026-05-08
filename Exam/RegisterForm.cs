using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.PasswordChar = '*';
        }

        private void GoToLoginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string role = RolesListBox.SelectedItem.ToString();
            string name = NameTextBox.Text;
            string lastname = LastnameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;
            UsersController registerController = new UsersController();
            try
            {            
                registerController.AddUser(role, name, lastname, surname, login, password);
                MessageBox.Show($"Пользователь{name + lastname + surname} успешно зарегестрирован!");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка регистрации пользователя: " + ex.Message );
            }
        }
    }
}
