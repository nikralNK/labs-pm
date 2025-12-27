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

namespace Task7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            int maxSpaces = 0;
            int currentSpaces = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    currentSpaces = currentSpaces + 1;
                    if (currentSpaces > maxSpaces)
                    {
                        maxSpaces = currentSpaces;
                    }
                }
                else
                {
                    currentSpaces = 0;
                }
            }

            ResultTextBox.Text = maxSpaces.ToString();
        }
    }
}
