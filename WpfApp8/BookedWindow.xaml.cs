using System.Windows.Controls;
using System.Windows;
using LoginApp;
using System.Data.SQLite;

namespace WpfApp8
{
    public partial class BookedWindow : Window
    {
        public BookedWindow()
        {
            InitializeComponent();
            LoadBookedItems();
        }

        private void LoadBookedItems()
        {
            AddBookedItem("Сноуборд", "01.01.2024");
            AddBookedItem("Лыжи", "05.01.2024");
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Кнопка 'Отменить' была нажата.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void AddBookedItem(string name, string date)
        {
            StackPanel itemPanel = new StackPanel
            {
                Orientation = Orientation.Horizontal,
                Margin = new Thickness(10),
                Background = System.Windows.Media.Brushes.LightYellow
            };

            TextBlock nameBlock = new TextBlock
            {
                Text = $"Название: {name}",
                Width = 200,
                Margin = new Thickness(5)
            };

            TextBlock dateBlock = new TextBlock
            {
                Text = $"Дата: {date}",
                Width = 150,
                Margin = new Thickness(5)
            };

            Button cancelButton = new Button
            {
                Content = "Отменить",
                Width = 100,
                Margin = new Thickness(5)
            };

            cancelButton.Click += (s, e) =>
            {
                MessageBox.Show($"Бронирование \"{name}\" на {date} отменено.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                BookedList.Children.Remove(itemPanel);
            };

            itemPanel.Children.Add(nameBlock);
            itemPanel.Children.Add(dateBlock);
            itemPanel.Children.Add(cancelButton);

            BookedList.Children.Add(itemPanel);
        }
    }
}
