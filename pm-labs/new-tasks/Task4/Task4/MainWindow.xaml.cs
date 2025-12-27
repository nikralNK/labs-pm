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

namespace Task4
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MergeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input1 = Array1TextBox.Text;
                string input2 = Array2TextBox.Text;

                string[] parts1 = input1.Split(',');
                string[] parts2 = input2.Split(',');

                int[] array1 = new int[parts1.Length];
                for (int i = 0; i < parts1.Length; i++)
                {
                    array1[i] = int.Parse(parts1[i].Trim());
                }

                int[] array2 = new int[parts2.Length];
                for (int i = 0; i < parts2.Length; i++)
                {
                    array2[i] = int.Parse(parts2[i].Trim());
                }

                int[] mergedArray = new int[array1.Length + array2.Length];
                for (int i = 0; i < array1.Length; i++)
                {
                    mergedArray[i] = array1[i];
                }
                for (int i = 0; i < array2.Length; i++)
                {
                    mergedArray[array1.Length + i] = array2[i];
                }

                string result = "";
                for (int i = 0; i < mergedArray.Length; i++)
                {
                    result = result + mergedArray[i];
                    if (i < mergedArray.Length - 1)
                    {
                        result = result + ", ";
                    }
                }

                ResultTextBox.Text = result;
            }
            catch
            {
                ResultTextBox.Text = "Ошибка ввода";
            }
        }
    }
}
