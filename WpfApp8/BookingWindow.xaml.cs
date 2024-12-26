using System;
using System.Windows;

namespace LoginApp
{
    public partial class BookingWindow : Window
    {
        public BookingWindow()
        {
            InitializeComponent();
        }

        private void PayButton_Click(object sender, RoutedEventArgs e)
        {
            if (BookingDatePicker.SelectedDate == null)
            {
                MessageBox.Show("Пожалуйста, выберите дату для бронирования.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Генерация случайного кода для оплаты
            Random random = new Random();
            int paymentCode = random.Next(100000, 999999);

            MessageBox.Show($"Для оплаты подойдите к инструктору, покажите код: {paymentCode}", "Оплата", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Close();
        }
    }
}
