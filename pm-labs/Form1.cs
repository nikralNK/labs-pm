namespace pm_labs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CalculateFunction(double x, double a)
        {
            double f;

            if (x <= 0)
            {
                f = Math.Pow(Math.Abs(x), 5) * (1 / Math.Tan(x + 2));
            }
            else if (x > 0 && x <= a)
            {
                f = (5 * x + Math.Pow(x, 2)) / Math.Pow(Math.Pow(x, 2) + 3, 3);
            }
            else
            {
                f = Math.Pow(Math.Sin(x + 3), 2) / (Math.Pow(x, 5) - (1 / Math.Tan(Math.PI * Math.Pow(x, 3))));
            }

            return f;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double xn = double.Parse(txtXn.Text);
                double xk = double.Parse(txtXk.Text);
                double xh = double.Parse(txtXh.Text);

                lstResults.Items.Clear();
                txtMin.Clear();
                txtMax.Clear();

                double x = xn;
                double fMin = double.MaxValue;
                double fMax = double.MinValue;
                double xMin = xn;
                double xMax = xn;

                lstResults.Items.Add("     x          |        f(x)");
                lstResults.Items.Add("----------------|-----------------");

                while (x <= xk)
                {
                    double f = CalculateFunction(x, a);

                    lstResults.Items.Add($"{x,15:F2} | {f,15:F6}");

                    if (f < fMin)
                    {
                        fMin = f;
                        xMin = x;
                    }

                    if (f > fMax)
                    {
                        fMax = f;
                        xMax = x;
                    }

                    x += xh;
                }

                txtMin.Text = $"f({xMin:F2}) = {fMin:F6}";
                txtMax.Text = $"f({xMax:F2}) = {fMax:F6}";
            }
            catch
            {
                MessageBox.Show("Ошибка вычисления");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            txtMin.Clear();
            txtMax.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
