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

namespace Task8
{
    public partial class MainWindow : Window
    {
        int[] array;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            string arrayText = "";
            for (int i = 0; i < array.Length; i++)
            {
                arrayText = arrayText + array[i];
                if (i < array.Length - 1)
                {
                    arrayText = arrayText + ", ";
                }
            }

            ArrayTextBox.Text = arrayText;
            ResultTextBox.Text = "";
        }

        private void ReplaceButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(NTextBox.Text);

                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum = sum + array[i];
                }
                double average = (double)sum / array.Length;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > n)
                    {
                        array[i] = (int)average;
                    }
                }

                string resultText = "";
                for (int i = 0; i < array.Length; i++)
                {
                    resultText = resultText + array[i];
                    if (i < array.Length - 1)
                    {
                        resultText = resultText + ", ";
                    }
                }

                ResultTextBox.Text = resultText;
            }
            catch
            {
                ResultTextBox.Text = "Ошибка ввода";
            }
        }
    }
}
