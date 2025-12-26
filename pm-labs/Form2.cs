using System;
using System.Windows.Forms;

namespace pm_labs
{
    public partial class Form2 : Form
    {
        public string SettingType { get; set; }
        private Color selectedColor;

        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            switch (SettingType)
            {
                case "TableForeColor":
                    lblTitle.Text = "Цвет текста таблицы:";
                    selectedColor = Form1.dgvForeColor;
                    break;
                case "TableBackColor":
                    lblTitle.Text = "Цвет фона таблицы:";
                    selectedColor = Form1.dgvBackColor;
                    break;
                case "TableGridColor":
                    lblTitle.Text = "Цвет сетки таблицы:";
                    selectedColor = Form1.dgvGridColor;
                    break;
                case "ChartLineColor":
                    lblTitle.Text = "Цвет линии графика:";
                    selectedColor = Form1.chartLineColor;
                    break;
                case "ChartBackColor":
                    lblTitle.Text = "Цвет фона графика:";
                    selectedColor = Form1.chartBackColor;
                    break;
                default:
                    selectedColor = Color.Black;
                    break;
            }

            panelPreview.BackColor = selectedColor;
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = selectedColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedColor = colorDialog1.Color;
                panelPreview.BackColor = selectedColor;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (SettingType)
            {
                case "TableForeColor":
                    Form1.dgvForeColor = selectedColor;
                    break;
                case "TableBackColor":
                    Form1.dgvBackColor = selectedColor;
                    break;
                case "TableGridColor":
                    Form1.dgvGridColor = selectedColor;
                    break;
                case "ChartLineColor":
                    Form1.chartLineColor = selectedColor;
                    break;
                case "ChartBackColor":
                    Form1.chartBackColor = selectedColor;
                    break;
            }
        }
    }
}
