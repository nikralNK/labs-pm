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
                MessageBox.Show("Введите размер массива");
                return;
            }

            if (!int.TryParse(txtN.Text, out int n) || n <= 0 || n > 100)
            {
                MessageBox.Show("Размер массива должен быть числом от 1 до 100");
                return;
            }

            array = new int[n];
            lstArray.Items.Clear();
            txtResult.Clear();

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 51);
                lstArray.Items.Add(array[i].ToString());
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив");
                return;
            }

            if (rbCountNegative.Checked)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        count++;
                    }
                }
                txtResult.Text = $"Количество отрицательных элементов: {count}";
            }
            else if (rbSumNegative.Checked)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        sum += array[i];
                    }
                }
                txtResult.Text = $"Сумма отрицательных элементов: {sum}";
            }
            else if (rbMinDivisible5.Checked)
            {
                int? min = null;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 5 == 0)
                    {
                        if (min == null || array[i] < min)
                        {
                            min = array[i];
                        }
                    }
                }

                if (min != null)
                {
                    txtResult.Text = $"Минимальный элемент, кратный 5: {min}";
                }
                else
                {
                    txtResult.Text = "Элементов, кратных 5, не найдено";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstArray.Items.Clear();
            txtResult.Clear();
            txtN.Clear();
            array = null;
        }
    }
}
