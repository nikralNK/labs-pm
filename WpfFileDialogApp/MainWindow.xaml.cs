using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace WpfFileDialogApp
{
    public partial class MainWindow : Window
    {
        private string? currentFilePath = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {
            OpenFile();
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                DefaultExt = ".txt",
                Title = "Открыть текстовый файл"
            };

            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    string content = File.ReadAllText(filePath);

                    txtContent.Text = content;
                    currentFilePath = filePath;
                    lblFileName.Text = $"Открыт файл: {Path.GetFileName(filePath)}";
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Ошибка: нет прав доступа к файлу", "Ошибка доступа",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Ошибка: файл не найден", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Ошибка ввода-вывода: {ex.Message}", "Ошибка I/O",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неожиданная ошибка: {ex.Message}", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }

        private void MenuSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                DefaultExt = ".txt",
                Title = "Сохранить текстовый файл",
                FileName = currentFilePath != null ? Path.GetFileName(currentFilePath) : "document.txt"
            };

            bool? result = saveFileDialog.ShowDialog();

            if (result == true)
            {
                try
                {
                    string filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, txtContent.Text);

                    currentFilePath = filePath;
                    lblFileName.Text = $"Сохранён файл: {Path.GetFileName(filePath)}";

                    MessageBox.Show("Файл успешно сохранён!", "Успех",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Ошибка: нет прав доступа для сохранения файла", "Ошибка доступа",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (PathTooLongException)
                {
                    MessageBox.Show("Ошибка: путь к файлу слишком длинный", "Ошибка пути",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Ошибка ввода-вывода: {ex.Message}", "Ошибка I/O",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Неожиданная ошибка: {ex.Message}", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Лабораторная работа 30\nРабота с файловыми диалогами в WPF\n\nФункции:\n- Открытие текстовых файлов\n- Сохранение файлов\n- Обработка исключений",
                "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
