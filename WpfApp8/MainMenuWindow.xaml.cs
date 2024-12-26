using System.Windows;
using WpfApp8;
using System.Data.SQLite;

namespace LoginApp
{
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        // Обработчик кнопки "Гл.Меню"
        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы уже находитесь в главном меню.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Обработчик кнопки "Забронированное"
        private void BookedButton_Click(object sender, RoutedEventArgs e)
        {
            // Открытие окна с забронированными предметами
            BookedWindow bookedWindow = new BookedWindow();
            bookedWindow.ShowDialog();
        }


        // Обработчик кнопки "Выход"
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        // Обработчик кнопки "Забронировать"
        private void BookButton_Click(object sender, RoutedEventArgs e)
        {
            BookingWindow bookingWindow = new BookingWindow();
            bookingWindow.ShowDialog();
        }

    }
}
