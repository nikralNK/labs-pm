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

namespace Task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = InputTextBox.Text;
                string[] parts = input.Split(',');
                int[] numbers = new int[parts.Length];

                for (int i = 0; i < parts.Length; i++)
                {
                    numbers[i] = int.Parse(parts[i].Trim());
                }

                string arrayText = "";
                for (int i = 0; i < numbers.Length; i++)
                {
                    arrayText = arrayText + numbers[i];
                    if (i < numbers.Length - 1)
                    {
                        arrayText = arrayText + ", ";
                    }
                }
                ArrayTextBox.Text = arrayText;

                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 != 0)
                    {
                        sum = sum + numbers[i];
                    }
                }

                ResultTextBox.Text = sum.ToString();
            }
            catch
            {
                ArrayTextBox.Text = "";
                ResultTextBox.Text = "Ошибка ввода";
            }
        }
    }
}
