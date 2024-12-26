using System.Windows;
using System.Windows.Controls;

namespace LoginApp
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;
            string confirmPassword = ConfirmPasswordBox.Password;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Пароли не совпадают.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Сообщение о регистрации
            MessageBox.Show("Регистрация успешна!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

            // Переход на окно входа, передаем данные пользователя
            LoginWindow loginWindow = new LoginWindow(username, password);
            loginWindow.Show();

            // Закрываем текущее окно
            this.Close();
        }

        private void LoginHyperlink_Click(object sender, RoutedEventArgs e)
        {
            // Переход на окно входа без регистрации
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

        private void AdminLoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Открытие окна администратора
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            this.Close();
        }
    }
}

