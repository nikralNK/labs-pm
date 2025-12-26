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
