using System.Windows;

namespace WpfStylesApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            lblMessage.Text = "Нажата зелёная стилизованная кнопка!";
        }

        private void StandardButton_Click(object sender, RoutedEventArgs e)
        {
            lblMessage.Text = "Нажата стандартная кнопка!";
        }
    }
}
