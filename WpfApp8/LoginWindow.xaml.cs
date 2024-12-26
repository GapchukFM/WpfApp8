using System.Windows;

namespace LoginApp
{
    public partial class LoginWindow : Window
    {
        private string RegisteredUsername { get; }
        private string RegisteredPassword { get; }

        public LoginWindow()
        {
            InitializeComponent();
        }

        public LoginWindow(string username, string password)
        {
            InitializeComponent();
            RegisteredUsername = username;
            RegisteredPassword = password;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordBox.Password;

            // Проверка данных входа
            if (username == RegisteredUsername && password == RegisteredPassword)
            {
                MessageBox.Show("Добро пожаловать!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                // Открытие главного меню
                MainMenuWindow mainMenu = new MainMenuWindow();
                mainMenu.Show();

                // Закрытие окна входа
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // Переход на окно регистрации
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
            this.Close();
        }
    }
}
