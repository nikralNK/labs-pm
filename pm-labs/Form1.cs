namespace pm_labs
{
    public partial class Form1 : Form
    {
        private int[] array;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtN.Text))
            {
                MessageBox.Show("Введите размер массива", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtN.Text, out int n) || n <= 0 || n > 1000)
            {
                MessageBox.Show("Размер массива должен быть числом от 1 до 1000", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            array = new int[n];
            Random rand = new Random();
            lstArray.Items.Clear();

            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-100, 101);
                lstArray.Items.Add(array[i]);
            }

            txtResults.Clear();
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtResults.Clear();

            if (rbTask1.Checked)
                Task1();
            else if (rbTask2.Checked)
                Task2();
            else if (rbTask3.Checked)
                Task3();
            else if (rbTask4.Checked)
                Task4();
            else if (rbTask5.Checked)
                Task5();
            else if (rbTask6.Checked)
                Task6();
            else if (rbTask7.Checked)
                Task7();
            else if (rbTask8.Checked)
                Task8();
            else if (rbTask9.Checked)
                Task9();
            else if (rbTask10.Checked)
                Task10();
        }

        private void Task1()
        {
            int negativeCount = 0;
            int positiveCount = 0;
            int sum = 0;

            foreach (int num in array)
            {
                if (num < 0)
                    negativeCount++;
                else if (num > 0)
                    positiveCount++;
                sum += num;
            }

            double average = (double)sum / array.Length;

            txtResults.Text = $"Количество отрицательных чисел: {negativeCount}\r\n";
            txtResults.Text += $"Количество положительных чисел: {positiveCount}\r\n";
            txtResults.Text += $"Среднее арифметическое всех чисел: {average:F2}";
        }

        private void Task2()
        {
            int[] evenIndices = new int[array.Length / 2 + array.Length % 2];
            int[] oddIndices = new int[array.Length / 2];

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenIndices[i / 2] = array[i];
                    evenSum += array[i];
                }
                else
                {
                    oddIndices[i / 2] = array[i];
                    oddSum += array[i];
                }
            }

            txtResults.Text = "Массив с четными индексами: ";
            txtResults.Text += string.Join(", ", evenIndices) + "\r\n";
            txtResults.Text += $"Сумма элементов с четными индексами: {evenSum}\r\n\r\n";
            txtResults.Text += "Массив с нечетными индексами: ";
            txtResults.Text += string.Join(", ", oddIndices) + "\r\n";
            txtResults.Text += $"Сумма элементов с нечетными индексами: {oddSum}";
        }

        private void Task3()
        {
            int firstNegative = int.MaxValue;
            int lastPositive = int.MinValue;
            bool foundNegative = false;
            bool foundPositive = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && !foundNegative)
                {
                    firstNegative = array[i];
                    foundNegative = true;
                }
                if (array[i] > 0)
                {
                    lastPositive = array[i];
                    foundPositive = true;
                }
            }

            if (!foundNegative || !foundPositive)
            {
                txtResults.Text = "В массиве нет отрицательных или положительных элементов";
                return;
            }

            double average = (firstNegative + lastPositive) / 2.0;
            txtResults.Text = $"Первый отрицательный элемент: {firstNegative}\r\n";
            txtResults.Text += $"Последний положительный элемент: {lastPositive}\r\n";
            txtResults.Text += $"Среднее арифметическое: {average:F2}";
        }

        private void Task4()
        {
            int maxPositive = int.MinValue;
            int maxPositiveIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] > maxPositive)
                {
                    maxPositive = array[i];
                    maxPositiveIndex = i;
                }
            }

            if (maxPositiveIndex == -1)
            {
                txtResults.Text = "В массиве нет положительных элементов";
                return;
            }

            int negativeCount = 0;
            for (int i = 0; i < maxPositiveIndex; i++)
            {
                if (array[i] < 0)
                    negativeCount++;
            }

            txtResults.Text = $"Наибольший положительный элемент: {maxPositive}\r\n";
            txtResults.Text += $"Его индекс: {maxPositiveIndex}\r\n";
            txtResults.Text += $"Количество отрицательных элементов перед ним: {negativeCount}";
        }

        private void Task5()
        {
            int firstPositiveIndex = -1;
            int lastPositiveIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (firstPositiveIndex == -1)
                        firstPositiveIndex = i;
                    lastPositiveIndex = i;
                }
            }

            if (firstPositiveIndex == -1 || firstPositiveIndex == lastPositiveIndex)
            {
                txtResults.Text = "Недостаточно положительных элементов для обмена";
                return;
            }

            int temp = array[firstPositiveIndex];
            array[firstPositiveIndex] = array[lastPositiveIndex];
            array[lastPositiveIndex] = temp;

            lstArray.Items.Clear();
            foreach (int num in array)
                lstArray.Items.Add(num);

            txtResults.Text = $"Поменяны местами элементы:\r\n";
            txtResults.Text += $"Индекс {firstPositiveIndex} (было {array[lastPositiveIndex]}, стало {array[firstPositiveIndex]})\r\n";
            txtResults.Text += $"Индекс {lastPositiveIndex} (было {temp}, стало {array[lastPositiveIndex]})";
        }

        private void Task6()
        {
            if (array.Length != 10)
            {
                MessageBox.Show("Для этого задания массив должен содержать 10 элементов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sum = 0;
            foreach (int num in array)
                sum += num;

            double average = sum / 10.0;

            txtResults.Text = $"Сумма элементов: {sum}\r\n";
            txtResults.Text += $"Среднее арифметическое: {average:F2}";
        }

        private void Task7()
        {
            if (array.Length != 20)
            {
                MessageBox.Show("Для этого задания массив должен содержать 20 элементов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sum = 0;
            foreach (int num in array)
            {
                if (num > 0)
                    sum += num;
            }

            txtResults.Text = $"Сумма положительных элементов: {sum}";
        }

        private void Task8()
        {
            if (array.Length != 20)
            {
                MessageBox.Show("Для этого задания массив должен содержать 20 элементов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sum = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                    sum += num;
            }

            txtResults.Text = $"Сумма четных элементов: {sum}";
        }

        private void Task9()
        {
            if (array.Length != 20)
            {
                MessageBox.Show("Для этого задания массив должен содержать 20 элементов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int count = 0;
            foreach (int num in array)
            {
                if (num > 0)
                    count++;
            }

            txtResults.Text = $"Количество положительных элементов: {count}";
        }

        private void Task10()
        {
            if (array.Length != 20)
            {
                MessageBox.Show("Для этого задания массив должен содержать 20 элементов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<int> indices = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    indices.Add(i);
            }

            if (indices.Count == 0)
            {
                txtResults.Text = "В массиве нет положительных элементов";
                return;
            }

            txtResults.Text = "Индексы положительных элементов:\r\n";
            txtResults.Text += string.Join(", ", indices);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Нет данных для сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(array.Length);
                    for (int i = 0; i < array.Length; i++)
                    {
                        sw.WriteLine(array[i]);
                    }
                }

                MessageBox.Show("Массив успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName))
                    {
                        string line = sr.ReadLine();
                        if (!int.TryParse(line, out int n) || n <= 0)
                        {
                            MessageBox.Show("Некорректный формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        array = new int[n];
                        lstArray.Items.Clear();

                        for (int i = 0; i < n; i++)
                        {
                            line = sr.ReadLine();
                            if (int.TryParse(line, out int value))
                            {
                                array[i] = value;
                                lstArray.Items.Add(value);
                            }
                            else
                            {
                                MessageBox.Show("Некорректные данные в файле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                array = null;
                                lstArray.Items.Clear();
                                return;
                            }
                        }

                        txtN.Text = n.ToString();
                        txtResults.Clear();
                        MessageBox.Show("Массив успешно загружен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            array = null;
            lstArray.Items.Clear();
            txtResults.Clear();
            txtN.Clear();
        }
    }
}
