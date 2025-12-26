using System;
using System.Windows;
using System.Windows.Media;

namespace WpfLab28
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Colors.LightGray);
            lblMessage.Text = "Начало работы";
        }

        private void BtnRed_Click(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Colors.Red);
        }

        private void BtnGreen_Click(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Colors.Green);
        }

        private void BtnBlue_Click(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Colors.Blue);
        }

        private void BtnYellow_Click(object sender, RoutedEventArgs e)
        {
            Background = new SolidColorBrush(Colors.Yellow);
        }

        private void BtnHello_Click(object sender, RoutedEventArgs e)
        {
            lblMessage.Text = "привет";
        }

        private void BtnGoodbye_Click(object sender, RoutedEventArgs e)
        {
            lblMessage.Text = "до свидания";
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lblError.Text = "";

                if (!double.TryParse(txtX.Text, out double x))
                {
                    lblError.Text = "Ошибка: некорректное значение X";
                    return;
                }

                if (!double.TryParse(txtY.Text, out double y))
                {
                    lblError.Text = "Ошибка: некорректное значение Y";
                    return;
                }

                if (!double.TryParse(txtZ.Text, out double z))
                {
                    lblError.Text = "Ошибка: некорректное значение Z";
                    return;
                }

                double sinXPlusY = Math.Sin(x + y);
                double numeratorV = 1 + Math.Pow(sinXPlusY, 2);

                double denominatorV = Math.Abs(x - (2 * y) / (1 + x * x * y * y));

                if (denominatorV == 0)
                {
                    lblError.Text = "Ошибка: деление на ноль в формуле v";
                    return;
                }

                double v = (numeratorV / denominatorV) * Math.Pow(Math.Abs(x), Math.Abs(y)) + Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);

                double cosX = Math.Cos(x);
                double cosY = Math.Cos(y);
                double baseW = Math.Abs(cosX - cosY);
                double exponentW = 1 + 2 * Math.Pow(Math.Sin(y), 2);

                double sumW = 1 + z + (z * z / 2) + (z * z * z / 3) + (z * z * z * z / 4);

                double w = Math.Pow(baseW, exponentW) * sumW;

                lblResult1.Text = $"v = {v:F6}";
                lblResult2.Text = $"w = {w:F6}";
            }
            catch (Exception ex)
            {
                lblError.Text = $"Ошибка вычисления: {ex.Message}";
            }
        }
    }
}
