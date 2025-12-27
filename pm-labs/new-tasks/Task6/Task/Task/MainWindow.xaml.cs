using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            string reversed = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversed = reversed + input[i];
            }

            if (input == reversed)
            {
                ResultTextBox.Text = "Строка является палиндромом";
            }
            else
            {
                ResultTextBox.Text = "Строка не является палиндромом";
            }
        }
    }
}
