using System.Windows;

namespace WpfHelloApp
{
    public partial class MainWindowGrid : Window
    {
        public MainWindowGrid()
        {
            InitializeComponent();
        }

        private void HelloButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Привет, мир!");
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("WpfHelloApp (Grid версия)\nВерсия 1.0\nЛабораторная работа 27", "О программе");
        }
    }
}
