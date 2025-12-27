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

namespace Task12
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
            array = new int[15];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
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

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            int[] counts = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i]] = counts[array[i]] + 1;
            }

            int newSize = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (counts[array[i]] <= 2)
                {
                    newSize = newSize + 1;
                }
            }

            int[] newArray = new int[newSize];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (counts[array[i]] <= 2)
                {
                    newArray[index] = array[i];
                    index = index + 1;
                }
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
