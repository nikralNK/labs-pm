using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace pm_labs
{
    public partial class Form1 : Form
    {
        private int rows, cols;
        private bool isProcessingCellChange = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateMatrix_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtRows.Text, out rows) || rows <= 0 || rows > 20)
            {
                MessageBox.Show("Введите количество строк от 1 до 20", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCols.Text, out cols) || cols <= 0 || cols > 20)
            {
                MessageBox.Show("Введите количество столбцов от 1 до 20", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvMatrix.Rows.Clear();
            dgvMatrix.Columns.Clear();

            for (int j = 0; j < cols; j++)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = $"col{j}";
                column.HeaderText = $"Столбец {j}";
                column.Width = 80;

                if ((j + 1) % 3 == 0)
                {
                    column.ReadOnly = true;
                    column.DefaultCellStyle.BackColor = Color.LightGray;
                }

                dgvMatrix.Columns.Add(column);
            }

            for (int i = 0; i < rows; i++)
            {
                dgvMatrix.Rows.Add();
                dgvMatrix.Rows[i].HeaderCell.Value = $"Строка {i}";
            }

            if (rbAuto.Checked)
            {
                FillMatrixAutomatically();
            }

            lstResult.Items.Clear();
        }

        private void FillMatrixAutomatically()
        {
            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if ((j + 1) % 3 != 0)
                    {
                        dgvMatrix.Rows[i].Cells[j].Value = rand.Next(-50, 51);
                    }
                }
            }

            CalculateThirdColumns();
        }

        private void dgvMatrix_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (isProcessingCellChange)
                return;

            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;

            if (rowIndex < 0 || colIndex < 0)
                return;

            if ((colIndex + 1) % 3 == 2)
            {
                CalculateThirdColumnForRow(rowIndex, colIndex);
            }
        }

        private void CalculateThirdColumnForRow(int rowIndex, int colIndex)
        {
            isProcessingCellChange = true;

            int thirdColIndex = colIndex + 1;
            if (thirdColIndex >= cols)
            {
                isProcessingCellChange = false;
                return;
            }

            int firstColIndex = colIndex - 1;
            int secondColIndex = colIndex;

            if (firstColIndex >= 0 &&
                dgvMatrix.Rows[rowIndex].Cells[firstColIndex].Value != null &&
                dgvMatrix.Rows[rowIndex].Cells[secondColIndex].Value != null)
            {
                if (int.TryParse(dgvMatrix.Rows[rowIndex].Cells[firstColIndex].Value.ToString(), out int val1) &&
                    int.TryParse(dgvMatrix.Rows[rowIndex].Cells[secondColIndex].Value.ToString(), out int val2))
                {
                    dgvMatrix.Rows[rowIndex].Cells[thirdColIndex].Value = val2 - val1;
                }
            }
            else
            {
                dgvMatrix.Rows[rowIndex].Cells[thirdColIndex].Value = null;
            }

            isProcessingCellChange = false;
        }

        private void CalculateThirdColumns()
        {
            isProcessingCellChange = true;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j < cols; j += 3)
                {
                    int firstColIndex = j - 1;
                    int secondColIndex = j;
                    int thirdColIndex = j + 1;

                    if (thirdColIndex < cols &&
                        dgvMatrix.Rows[i].Cells[firstColIndex].Value != null &&
                        dgvMatrix.Rows[i].Cells[secondColIndex].Value != null)
                    {
                        if (int.TryParse(dgvMatrix.Rows[i].Cells[firstColIndex].Value.ToString(), out int val1) &&
                            int.TryParse(dgvMatrix.Rows[i].Cells[secondColIndex].Value.ToString(), out int val2))
                        {
                            dgvMatrix.Rows[i].Cells[thirdColIndex].Value = val2 - val1;
                        }
                    }
                }
            }

            isProcessingCellChange = false;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (dgvMatrix.Rows.Count == 0 || dgvMatrix.Columns.Count == 0)
            {
                MessageBox.Show("Сначала создайте матрицу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (dgvMatrix.Rows[i].Cells[j].Value == null || string.IsNullOrWhiteSpace(dgvMatrix.Rows[i].Cells[j].Value.ToString()))
                    {
                        MessageBox.Show($"Заполните все ячейки матрицы. Пустая ячейка в строке {i}, столбце {j}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            List<ArrayInfo> arrays = new List<ArrayInfo>();

            if (rbByRows.Checked)
            {
                for (int i = 0; i < rows; i++)
                {
                    List<int> rowData = new List<int>();
                    int positiveSum = 0;

                    for (int j = 0; j < cols; j++)
                    {
                        if (int.TryParse(dgvMatrix.Rows[i].Cells[j].Value.ToString(), out int val))
                        {
                            rowData.Add(val);
                            if (val > 0)
                                positiveSum += val;
                        }
                    }

                    arrays.Add(new ArrayInfo
                    {
                        Data = rowData.ToArray(),
                        PositiveSum = positiveSum,
                        Index = i
                    });
                }
            }
            else
            {
                for (int j = 0; j < cols; j++)
                {
                    List<int> colData = new List<int>();
                    int positiveSum = 0;

                    for (int i = 0; i < rows; i++)
                    {
                        if (int.TryParse(dgvMatrix.Rows[i].Cells[j].Value.ToString(), out int val))
                        {
                            colData.Add(val);
                            if (val > 0)
                                positiveSum += val;
                        }
                    }

                    arrays.Add(new ArrayInfo
                    {
                        Data = colData.ToArray(),
                        PositiveSum = positiveSum,
                        Index = j
                    });
                }
            }

            BubbleSort(arrays);

            lstResult.Items.Clear();

            foreach (var array in arrays)
            {
                string type = rbByRows.Checked ? "Строка" : "Столбец";
                string dataStr = string.Join(", ", array.Data);
                lstResult.Items.Add($"{type} {array.Index}: [{dataStr}] - Сумма положительных: {array.PositiveSum}");
            }
        }

        private void BubbleSort(List<ArrayInfo> arrays)
        {
            int n = arrays.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arrays[j].PositiveSum > arrays[j + 1].PositiveSum)
                    {
                        ArrayInfo temp = arrays[j];
                        arrays[j] = arrays[j + 1];
                        arrays[j + 1] = temp;
                    }
                }
            }
        }

        private class ArrayInfo
        {
            public int[] Data { get; set; }
            public int PositiveSum { get; set; }
            public int Index { get; set; }
        }
    }
}
