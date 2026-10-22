using System;
using System.Windows.Forms;

namespace MyProject23123
{
    public partial class Form1 : Form
    {
        // Пока хардкод. Позже заменим на проверку из БД.
        private const string ValidLogin = "admin";
        private const string ValidPassword = "12345";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Введите имя пользователя и пароль.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (login == ValidLogin && password == ValidPassword)
            {
                // Скрываем окно авторизации
                this.Hide();

                // Открываем главную форму (создадим её на следующем шаге)
                MainForm mainForm = new MainForm();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.",
                    "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Обратитесь к администратору для восстановления пароля.",
                "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}