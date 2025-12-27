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

namespace Task2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateElement_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxRadio.IsChecked == true)
            {
                TextBox textBox = new TextBox();
                textBox.Width = 100;
                textBox.Height = 25;
                textBox.Margin = new Thickness(5);
                ElementsPanel.Children.Add(textBox);
            }
            else if (ButtonRadio.IsChecked == true)
            {
                Button button = new Button();
                button.Content = "Кнопка";
                button.Width = 100;
                button.Height = 25;
                button.Margin = new Thickness(5);
                ElementsPanel.Children.Add(button);
            }
            else if (LabelRadio.IsChecked == true)
            {
                Label label = new Label();
                label.Content = "Текст";
                label.Width = 100;
                label.Height = 25;
                label.Margin = new Thickness(5);
                ElementsPanel.Children.Add(label);
            }
        }
    }
}
