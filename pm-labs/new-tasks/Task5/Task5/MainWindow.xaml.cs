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

namespace Task5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InsertButton_Click(object sender, RoutedEventArgs e)
        {
            string input = InputTextBox.Text;
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                result = result + input[i];
                if (input[i] == 'a')
                {
                    result = result + 'b';
                }
            }

            ResultTextBox.Text = result;
        }
    }
}
