namespace pm_labs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double x = double.Parse(txtX.Text);
                double y;

                if (chkSelectFunction.Checked)
                {
                    if (rbFunction1.Checked)
                    {
                        y = x * Math.Sin(x - 1);
                    }
                    else if (rbFunction2.Checked)
                    {
                        y = Math.Pow(x - 1, 3) + Math.Cos(Math.Pow(x, 3));
                    }
                    else
                    {
                        y = Math.Sqrt(Math.Pow(Math.Abs(x), 3)) * Math.Sin(Math.Pow(x, 3));
                    }
                }
                else
                {
                    if (x <= 0)
                    {
                        y = x * Math.Sin(x - 1);
                    }
                    else if (x > 0 && x <= a)
                    {
                        y = Math.Pow(x - 1, 3) + Math.Cos(Math.Pow(x, 3));
                    }
                    else
                    {
                        y = Math.Sqrt(Math.Pow(Math.Abs(x), 3)) * Math.Sin(Math.Pow(x, 3));
                    }
                }

                txtY.Text = y.ToString("F6");
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkSelectFunction_CheckedChanged(object sender, EventArgs e)
        {
            grpFunctions.Enabled = chkSelectFunction.Checked;
        }
    }
}
