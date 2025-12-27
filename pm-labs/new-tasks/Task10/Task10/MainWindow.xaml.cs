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

namespace Task10
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
            try
            {
                int size = int.Parse(SizeTextBox.Text);
                Random random = new Random();
                array = new int[size];

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
            catch
            {
                ArrayTextBox.Text = "Ошибка ввода";
            }
        }

        private void AverageButton_Click(object sender, RoutedEventArgs e)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int sum = array[i];
                int count = 1;

                if (i > 0)
                {
                    sum = sum + array[i - 1];
                    count = count + 1;
                }

                if (i < array.Length - 1)
                {
                    sum = sum + array[i + 1];
                    count = count + 1;
                }

                newArray[i] = sum / count;
            }

            array = newArray;

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
    }
}
