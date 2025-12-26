using System;
using System.Windows.Forms;
using System.Globalization;

namespace pm_labs
{
    public partial class Form1 : Form
    {
        public static double xn, xk, xh, a;
        public static Color dgvForeColor = Color.Black;
        public static Color dgvBackColor = Color.White;
        public static Color dgvGridColor = Color.Black;
        public static Color chartLineColor = Color.Blue;
        public static Color chartBackColor = Color.White;

        public Form1()
        {
            InitializeComponent();
        }

        private double CalculateFunction(double x)
        {
            if (x <= 0)
            {
                return Math.Pow(x, 5) * (1 / Math.Tan(2 * Math.Pow(x, 3)));
            }
            else if (x > 0 && x <= 5)
            {
                return 5 / (Math.Tan(2 * x + 3) + 1);
            }
            else
            {
                return Math.Pow(x, 2) * Math.Exp(-x);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                GenerateTable();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                GenerateChart();
            }
        }

        private void GenerateTable()
        {
            if (!ValidateInputs())
                return;

            dgvResults.Rows.Clear();

            double x = xn;
            double ymax = double.MinValue;
            double ymin = double.MaxValue;

            while (x <= xk)
            {
                double y = CalculateFunction(x);

                dgvResults.Rows.Add(x.ToString("F4"), y.ToString("F6"));

                if (y > ymax) ymax = y;
                if (y < ymin) ymin = y;

                x += xh;
            }

            txtYmax.Text = ymax.ToString("F6");
            txtYmin.Text = ymin.ToString("F6");

            ApplyTableColors();
        }

        private void GenerateChart()
        {
            if (!ValidateInputs())
                return;

            chart1.Series[0].Points.Clear();

            double x = xn;

            while (x <= xk)
            {
                double y = CalculateFunction(x);
                chart1.Series[0].Points.AddXY(x, y);
                x += xh;
            }

            ApplyChartColors();
        }

        private bool ValidateInputs()
        {
            if (!TryParseDouble(txtXn.Text, out xn))
            {
                MessageBox.Show("Некорректное значение Xn", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 0;
                return false;
            }

            if (!TryParseDouble(txtXk.Text, out xk))
            {
                MessageBox.Show("Некорректное значение Xk", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 0;
                return false;
            }

            if (!TryParseDouble(txtXh.Text, out xh) || xh <= 0)
            {
                MessageBox.Show("Шаг должен быть положительным числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 0;
                return false;
            }

            if (!TryParseDouble(txtA.Text, out a))
            {
                MessageBox.Show("Некорректное значение параметра a", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 0;
                return false;
            }

            if (xn >= xk)
            {
                MessageBox.Show("Начальное значение должно быть меньше конечного", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedIndex = 0;
                return false;
            }

            return true;
        }

        private bool TryParseDouble(string text, out double result)
        {
            text = text.Replace(',', '.');
            return double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out result);
        }

        private void ValidateNumberInput(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            if (char.IsControl(e.KeyChar))
                return;

            if (e.KeyChar == '+' || e.KeyChar == '-')
            {
                if (textBox.SelectionStart != 0 || textBox.Text.Contains("+") || textBox.Text.Contains("-"))
                {
                    e.Handled = true;
                }
                return;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (textBox.Text.Contains(",") || textBox.Text.Contains(".") || textBox.Text.Length == 0)
                {
                    e.Handled = true;
                }
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ApplyTableColors()
        {
            dgvResults.DefaultCellStyle.ForeColor = dgvForeColor;
            dgvResults.DefaultCellStyle.BackColor = dgvBackColor;
            dgvResults.GridColor = dgvGridColor;
        }

        private void ApplyChartColors()
        {
            chart1.Series[0].Color = chartLineColor;
            chart1.ChartAreas[0].BackColor = chartBackColor;
        }

        private void цветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.SettingType = "TableForeColor";
            if (form2.ShowDialog() == DialogResult.OK)
            {
                ApplyTableColors();
            }
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.SettingType = "TableBackColor";
            if (form2.ShowDialog() == DialogResult.OK)
            {
                ApplyTableColors();
            }
        }

        private void цветСеткиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.SettingType = "TableGridColor";
            if (form2.ShowDialog() == DialogResult.OK)
            {
                ApplyTableColors();
            }
        }

        private void цветЛинииГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.SettingType = "ChartLineColor";
            if (form2.ShowDialog() == DialogResult.OK)
            {
                ApplyChartColors();
            }
        }

        private void цветФонаГрафикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.SettingType = "ChartBackColor";
            if (form2.ShowDialog() == DialogResult.OK)
            {
                ApplyChartColors();
            }
        }

        private void сохранитьДанныеТаблицыВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvResults.Rows.Count == 0)
            {
                MessageBox.Show("Таблица пуста. Сначала перейдите на вкладку 'Таблица данных'", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Title = "Сохранить данные таблицы";
            saveFileDialog1.DefaultExt = "txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine("X\t\tY");
                    sw.WriteLine(new string('-', 50));

                    foreach (DataGridViewRow row in dgvResults.Rows)
                    {
                        if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                        {
                            sw.WriteLine($"{row.Cells[0].Value}\t\t{row.Cells[1].Value}");
                        }
                    }

                    sw.WriteLine(new string('-', 50));
                    sw.WriteLine($"Ymax: {txtYmax.Text}");
                    sw.WriteLine($"Ymin: {txtYmin.Text}");
                }

                MessageBox.Show("Данные успешно сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
