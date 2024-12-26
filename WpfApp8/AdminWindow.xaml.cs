using System.Windows;

namespace LoginApp
{
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void AddItemButton_Click(object sender, RoutedEventArgs e)
        {
            string itemName = ItemNameTextBox.Text;
            string itemPrice = ItemPriceTextBox.Text;

            if (string.IsNullOrWhiteSpace(itemName) || string.IsNullOrWhiteSpace(itemPrice))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show($"Предмет \"{itemName}\" с ценой {itemPrice} добавлен.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

            ItemNameTextBox.Clear();
            ItemPriceTextBox.Clear();
        }

        private void RemoveItemButton_Click(object sender, RoutedEventArgs e)
        {
            string itemName = RemoveItemNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(itemName))
            {
                MessageBox.Show("Пожалуйста, укажите название предмета для удаления.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            MessageBox.Show($"Предмет \"{itemName}\" удален.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

            RemoveItemNameTextBox.Clear();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

