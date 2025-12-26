namespace pm_labs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
            lblMessage.Text = "Начало работы";
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "привет";
        }

        private void btnGoodbye_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "до свидания";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);
                double z = double.Parse(txtZ.Text);

                double t = (2 * Math.Cos(x - Math.PI / 6) / (0.5 + Math.Pow(Math.Sin(y), 2))) *
                           (1 + Math.Pow(z, 2) / (3 - Math.Pow(z, 2) / 5));

                double u = (Math.Pow(8 + Math.Pow(Math.Abs(x - y), 2) + 1, 1.0 / 3.0) /
                           (Math.Pow(x, 2) + Math.Pow(y, 2) + 2)) -
                           Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Pow(Math.Tan(z), 2) + 1, x);

                lblResult1.Text = $"t = {t:F6}";
                lblResult2.Text = $"u = {u:F6}";
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }
    }
}
