namespace pm_labs
{
    public partial class Form1 : Form
    {
        private int[,] matrix;
        private int rows, cols;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRows.Text) || string.IsNullOrWhiteSpace(txtCols.Text))
            {
                MessageBox.Show("Введите количество строк и столбцов");
                return;
            }

            if (!int.TryParse(txtRows.Text, out rows) || !int.TryParse(txtCols.Text, out cols))
            {
                MessageBox.Show("Введите корректные числа");
                return;
            }

            if (rows <= 0 || cols <= 0 || rows > 20 || cols > 20)
            {
                MessageBox.Show("Размеры матрицы должны быть от 1 до 20");
                return;
            }

            matrix = new int[rows, cols];
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            txtResult.Clear();

            dataGridView1.ColumnCount = cols;
            dataGridView1.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridView1.Columns[i].Width = 50;
            }

            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(-50, 51);
                    dataGridView1.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

            btnTaskA.Enabled = true;
            btnTaskB.Enabled = true;
            btnTaskC.Enabled = (rows == 4 && cols == 4);
        }

        private void btnTaskA_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала создайте матрицу");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtC.Text))
            {
                MessageBox.Show("Введите число C");
                return;
            }

            if (!int.TryParse(txtC.Text, out int c))
            {
                MessageBox.Show("Введите корректное число C");
                return;
            }

            int count = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > c)
                    {
                        count++;
                    }
                }
            }

            txtResult.Text = $"Количество элементов больших {c}: {count}";
        }

        private void btnTaskB_Click(object sender, EventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала создайте матрицу");
                return;
            }

            int sum = 0;

            for (int j = 0; j < cols; j++)
            {
                sum += matrix[0, j];
            }

            for (int j = 0; j < cols; j++)
            {
                sum += matrix[rows - 1, j];
            }

            for (int i = 1; i < rows - 1; i++)
            {
                sum += matrix[i, 0];
            }

            for (int i = 1; i < rows - 1; i++)
            {
                sum += matrix[i, cols - 1];
            }

            txtResult.Text = $"Сумма элементов по периметру: {sum}";
        }

        private void btnTaskC_Click(object sender, EventArgs e)
        {
            if (matrix == null || rows != 4 || cols != 4)
            {
                MessageBox.Show("Задание доступно только для матрицы 4x4");
                return;
            }

            int productEvenRow1 = 1;
            bool hasEvenRow1 = false;

            for (int j = 0; j < 4; j++)
            {
                if (matrix[0, j] % 2 == 0)
                {
                    productEvenRow1 *= matrix[0, j];
                    hasEvenRow1 = true;
                }
            }

            int productPositiveCol3 = 1;
            bool hasPositiveCol3 = false;

            for (int i = 0; i < 4; i++)
            {
                if (matrix[i, 2] > 0)
                {
                    productPositiveCol3 *= matrix[i, 2];
                    hasPositiveCol3 = true;
                }
            }

            if (!hasEvenRow1)
            {
                productEvenRow1 = 0;
            }

            if (!hasPositiveCol3)
            {
                productPositiveCol3 = 0;
            }

            int result = productEvenRow1 + productPositiveCol3;

            txtResult.Text = $"Произведение четных в 1-й строке: {productEvenRow1}\r\n";
            txtResult.Text += $"Произведение положительных в 3-м столбце: {productPositiveCol3}\r\n";
            txtResult.Text += $"Сумма: {result}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            txtRows.Clear();
            txtCols.Clear();
            txtC.Clear();
            txtResult.Clear();
            matrix = null;
            btnTaskA.Enabled = false;
            btnTaskB.Enabled = false;
            btnTaskC.Enabled = false;
        }
    }
}
