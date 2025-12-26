namespace pm_labs
{
    public partial class Form1 : Form
    {
        private int[] array;
        private int[,] matrix;
        private int rows, cols;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate1D_Click(object sender, EventArgs e)
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

            txtResults1D.Clear();
        }

        private void btnAnalyze1D_Click(object sender, EventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtResults1D.Clear();

            if (rbTask1D_1.Checked)
                Task1D_1();
            else if (rbTask1D_2.Checked)
                Task1D_2();
            else if (rbTask1D_3.Checked)
                Task1D_3();
            else if (rbTask1D_4.Checked)
                Task1D_4();
            else if (rbTask1D_5.Checked)
                Task1D_5();
            else if (rbTask1D_6.Checked)
                Task1D_6();
            else if (rbTask1D_7.Checked)
                Task1D_7();
            else if (rbTask1D_8.Checked)
                Task1D_8();
            else if (rbTask1D_9.Checked)
                Task1D_9();
            else if (rbTask1D_10.Checked)
                Task1D_10();
        }

        private void Task1D_1()
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

            txtResults1D.Text = $"Количество отрицательных чисел: {negativeCount}\r\n";
            txtResults1D.Text += $"Количество положительных чисел: {positiveCount}\r\n";
            txtResults1D.Text += $"Среднее арифметическое всех чисел: {average:F2}";
        }

        private void Task1D_2()
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

            txtResults1D.Text = "Массив с четными индексами: ";
            txtResults1D.Text += string.Join(", ", evenIndices) + "\r\n";
            txtResults1D.Text += $"Сумма элементов с четными индексами: {evenSum}\r\n\r\n";
            txtResults1D.Text += "Массив с нечетными индексами: ";
            txtResults1D.Text += string.Join(", ", oddIndices) + "\r\n";
            txtResults1D.Text += $"Сумма элементов с нечетными индексами: {oddSum}";
        }

        private void Task1D_3()
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
                txtResults1D.Text = "В массиве нет отрицательных или положительных элементов";
                return;
            }

            double average = (firstNegative + lastPositive) / 2.0;
            txtResults1D.Text = $"Первый отрицательный элемент: {firstNegative}\r\n";
            txtResults1D.Text += $"Последний положительный элемент: {lastPositive}\r\n";
            txtResults1D.Text += $"Среднее арифметическое: {average:F2}";
        }

        private void Task1D_4()
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
                txtResults1D.Text = "В массиве нет положительных элементов";
                return;
            }

            int negativeCount = 0;
            for (int i = 0; i < maxPositiveIndex; i++)
            {
                if (array[i] < 0)
                    negativeCount++;
            }

            txtResults1D.Text = $"Наибольший положительный элемент: {maxPositive}\r\n";
            txtResults1D.Text += $"Его индекс: {maxPositiveIndex}\r\n";
            txtResults1D.Text += $"Количество отрицательных элементов перед ним: {negativeCount}";
        }

        private void Task1D_5()
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
                txtResults1D.Text = "Недостаточно положительных элементов для обмена";
                return;
            }

            int temp = array[firstPositiveIndex];
            array[firstPositiveIndex] = array[lastPositiveIndex];
            array[lastPositiveIndex] = temp;

            lstArray.Items.Clear();
            foreach (int num in array)
                lstArray.Items.Add(num);

            txtResults1D.Text = $"Поменяны местами элементы:\r\n";
            txtResults1D.Text += $"Индекс {firstPositiveIndex} (было {array[lastPositiveIndex]}, стало {array[firstPositiveIndex]})\r\n";
            txtResults1D.Text += $"Индекс {lastPositiveIndex} (было {temp}, стало {array[lastPositiveIndex]})";
        }

        private void Task1D_6()
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

            txtResults1D.Text = $"Сумма элементов: {sum}\r\n";
            txtResults1D.Text += $"Среднее арифметическое: {average:F2}";
        }

        private void Task1D_7()
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

            txtResults1D.Text = $"Сумма положительных элементов: {sum}";
        }

        private void Task1D_8()
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

            txtResults1D.Text = $"Сумма четных элементов: {sum}";
        }

        private void Task1D_9()
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

            txtResults1D.Text = $"Количество положительных элементов: {count}";
        }

        private void Task1D_10()
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
                txtResults1D.Text = "В массиве нет положительных элементов";
                return;
            }

            txtResults1D.Text = "Индексы положительных элементов:\r\n";
            txtResults1D.Text += string.Join(", ", indices);
        }

        private void btnSave1D_Click(object sender, EventArgs e)
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

        private void btnLoad1D_Click(object sender, EventArgs e)
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
                        txtResults1D.Clear();
                        MessageBox.Show("Массив успешно загружен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear1D_Click(object sender, EventArgs e)
        {
            array = null;
            lstArray.Items.Clear();
            txtResults1D.Clear();
            txtN.Clear();
        }

        private void btnGenerate2D_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRows.Text) || string.IsNullOrWhiteSpace(txtCols.Text))
            {
                MessageBox.Show("Введите количество строк и столбцов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtRows.Text, out rows) || rows <= 0 || rows > 20 ||
                !int.TryParse(txtCols.Text, out cols) || cols <= 0 || cols > 20)
            {
                MessageBox.Show("Размеры должны быть числами от 1 до 20", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            matrix = new int[rows, cols];
            Random rand = new Random();

            dgvMatrix.Rows.Clear();
            dgvMatrix.Columns.Clear();

            for (int j = 0; j < cols; j++)
            {
                dgvMatrix.Columns.Add($"col{j}", $"{j}");
                dgvMatrix.Columns[j].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                dgvMatrix.Rows.Add();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(-100, 101);
                    dgvMatrix.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            txtResults2D.Clear();
        }

        private void btnAnalyze2D_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала сгенерируйте матрицу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtResults2D.Clear();

            if (rbTask2D_1.Checked)
                Task2D_1();
            else if (rbTask2D_2.Checked)
                Task2D_2();
            else if (rbTask2D_3.Checked)
                Task2D_3();
            else if (rbTask2D_4.Checked)
                Task2D_4();
            else if (rbTask2D_5.Checked)
                Task2D_5();
            else if (rbTask2D_6.Checked)
                Task2D_6();
            else if (rbTask2D_7.Checked)
                Task2D_7();
            else if (rbTask2D_8.Checked)
                Task2D_8();
            else if (rbTask2D_9.Checked)
                Task2D_9();
            else if (rbTask2D_10.Checked)
                Task2D_10();
        }

        private void Task2D_1()
        {
            txtResults2D.Text = "Сумма элементов в каждом столбце:\r\n";
            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    sum += matrix[i, j];
                }
                txtResults2D.Text += $"Столбец {j}: {sum}\r\n";
            }
        }

        private void Task2D_2()
        {
            txtResults2D.Text = "Произведение элементов в каждом столбце:\r\n";
            for (int j = 0; j < cols; j++)
            {
                long product = 1;
                for (int i = 0; i < rows; i++)
                {
                    product *= matrix[i, j];
                }
                txtResults2D.Text += $"Столбец {j}: {product}\r\n";
            }
        }

        private void Task2D_3()
        {
            txtResults2D.Text = "Произведение элементов в каждой строке:\r\n";
            for (int i = 0; i < rows; i++)
            {
                long product = 1;
                for (int j = 0; j < cols; j++)
                {
                    product *= matrix[i, j];
                }
                txtResults2D.Text += $"Строка {i}: {product}\r\n";
            }
        }

        private void Task2D_4()
        {
            int minSize = Math.Min(rows, cols);
            long product = 1;

            for (int i = 0; i < minSize; i++)
            {
                product *= matrix[i, i];
            }

            txtResults2D.Text = $"Произведение диагональных элементов: {product}";
        }

        private void Task2D_5()
        {
            int minSize = Math.Min(rows, cols);
            int sum = 0;

            for (int i = 0; i < minSize; i++)
            {
                sum += matrix[i, cols - 1 - i];
            }

            txtResults2D.Text = $"Сумма элементов на побочной диагонали: {sum}";
        }

        private void Task2D_6()
        {
            int minColumn = 0;
            int minCount = int.MaxValue;

            for (int j = 0; j < cols; j++)
            {
                int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] > 0)
                        count++;
                }
                if (count < minCount)
                {
                    minCount = count;
                    minColumn = j;
                }
            }

            txtResults2D.Text = $"Столбец с наименьшим количеством положительных: {minColumn}\r\n";
            txtResults2D.Text += $"Количество положительных элементов: {minCount}";
        }

        private void Task2D_7()
        {
            int minRow = 0;
            int minCount = int.MaxValue;

            for (int i = 0; i < rows; i++)
            {
                int count = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                        count++;
                }
                if (count < minCount)
                {
                    minCount = count;
                    minRow = i;
                }
            }

            txtResults2D.Text = $"Строка с наименьшим количеством положительных: {minRow}\r\n";
            txtResults2D.Text += $"Количество положительных элементов: {minCount}";
        }

        private void Task2D_8()
        {
            int maxRow = 0;
            int maxCount = int.MinValue;

            for (int i = 0; i < rows; i++)
            {
                int count = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxRow = i;
                }
            }

            txtResults2D.Text = $"Строка с наибольшим количеством четных: {maxRow}\r\n";
            txtResults2D.Text += $"Количество четных элементов: {maxCount}";
        }

        private void Task2D_9()
        {
            int maxColumn = 0;
            int maxCount = int.MinValue;

            for (int j = 0; j < cols; j++)
            {
                int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] % 5 == 0 && matrix[i, j] != 0)
                        count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxColumn = j;
                }
            }

            txtResults2D.Text = $"Столбец с наибольшим количеством кратных 5: {maxColumn}\r\n";
            txtResults2D.Text += $"Количество элементов кратных 5: {maxCount}";
        }

        private void Task2D_10()
        {
            int minEven = int.MaxValue;
            bool found = false;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0 && matrix[i, j] < minEven)
                    {
                        minEven = matrix[i, j];
                        found = true;
                    }
                }
            }

            if (!found)
            {
                txtResults2D.Text = "В матрице нет четных чисел";
                return;
            }

            txtResults2D.Text = $"Наименьшее четное число в матрице: {minEven}";
        }

        private void btnSave2D_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Нет данных для сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine($"{rows} {cols}");
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            sw.Write(matrix[i, j]);
                            if (j < cols - 1)
                                sw.Write(" ");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("Матрица успешно сохранена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLoad2D_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName))
                    {
                        string line = sr.ReadLine();
                        string[] dims = line.Split(' ');

                        if (dims.Length != 2 || !int.TryParse(dims[0], out rows) || !int.TryParse(dims[1], out cols) ||
                            rows <= 0 || rows > 20 || cols <= 0 || cols > 20)
                        {
                            MessageBox.Show("Некорректный формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        matrix = new int[rows, cols];
                        dgvMatrix.Rows.Clear();
                        dgvMatrix.Columns.Clear();

                        for (int j = 0; j < cols; j++)
                        {
                            dgvMatrix.Columns.Add($"col{j}", $"{j}");
                            dgvMatrix.Columns[j].Width = 50;
                        }

                        for (int i = 0; i < rows; i++)
                        {
                            line = sr.ReadLine();
                            string[] values = line.Split(' ');

                            if (values.Length != cols)
                            {
                                MessageBox.Show("Некорректные данные в файле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                matrix = null;
                                dgvMatrix.Rows.Clear();
                                dgvMatrix.Columns.Clear();
                                return;
                            }

                            dgvMatrix.Rows.Add();
                            for (int j = 0; j < cols; j++)
                            {
                                if (int.TryParse(values[j], out int value))
                                {
                                    matrix[i, j] = value;
                                    dgvMatrix.Rows[i].Cells[j].Value = value;
                                }
                                else
                                {
                                    MessageBox.Show("Некорректные данные в файле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    matrix = null;
                                    dgvMatrix.Rows.Clear();
                                    dgvMatrix.Columns.Clear();
                                    return;
                                }
                            }
                        }

                        txtRows.Text = rows.ToString();
                        txtCols.Text = cols.ToString();
                        txtResults2D.Clear();
                        MessageBox.Show("Матрица успешно загружена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при чтении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear2D_Click(object sender, EventArgs e)
        {
            matrix = null;
            dgvMatrix.Rows.Clear();
            dgvMatrix.Columns.Clear();
            txtResults2D.Clear();
            txtRows.Clear();
            txtCols.Clear();
        }
    }
}
