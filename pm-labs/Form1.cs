using System;
using System.Drawing;
using System.Windows.Forms;

namespace pm_labs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ComboBox SelectedIndexChanged event
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = CreatePlaceholderImage("Изображение 1", Color.LightBlue);
                    break;
                case 1:
                    pictureBox1.Image = CreatePlaceholderImage("Изображение 2", Color.LightGreen);
                    break;
                case 2:
                    pictureBox1.Image = CreatePlaceholderImage("Изображение 3", Color.LightCoral);
                    break;
            }
        }

        // Navigation: Tab 1 -> Tab 2
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        // ListBox SelectedIndexChanged event
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    pictureBox2.Image = CreatePlaceholderImage("Изображение 1", Color.LightBlue);
                    break;
                case 1:
                    pictureBox2.Image = CreatePlaceholderImage("Изображение 2", Color.LightGreen);
                    break;
                case 2:
                    pictureBox2.Image = CreatePlaceholderImage("Изображение 3", Color.LightCoral);
                    break;
            }
        }

        // Navigation: Tab 2 -> Tab 1
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        // Navigation: Tab 2 -> Tab 3
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        // RadioButton1 CheckedChanged event
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox3.Image = CreatePlaceholderImage("Изображение 1", Color.LightBlue);
            }
        }

        // RadioButton2 CheckedChanged event
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBox3.Image = CreatePlaceholderImage("Изображение 2", Color.LightGreen);
            }
        }

        // RadioButton3 CheckedChanged event
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                pictureBox3.Image = CreatePlaceholderImage("Изображение 3", Color.LightCoral);
            }
        }

        // Navigation: Tab 3 -> Tab 2
        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        // Navigation: Tab 3 -> Tab 4
        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        // NumericUpDown ValueChanged event
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            switch ((int)numericUpDown1.Value)
            {
                case 0:
                    pictureBox4.Image = CreatePlaceholderImage("Изображение 1", Color.LightBlue);
                    break;
                case 1:
                    pictureBox4.Image = CreatePlaceholderImage("Изображение 2", Color.LightGreen);
                    break;
                case 2:
                    pictureBox4.Image = CreatePlaceholderImage("Изображение 3", Color.LightCoral);
                    break;
            }
        }

        // Navigation: Tab 4 -> Tab 3
        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        // Exit program
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Helper method to create placeholder images
        private Image CreatePlaceholderImage(string text, Color backgroundColor)
        {
            int width = 310;
            int height = 160;
            Bitmap bitmap = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Fill background
                g.Clear(backgroundColor);

                // Draw border
                using (Pen pen = new Pen(Color.Black, 2))
                {
                    g.DrawRectangle(pen, 1, 1, width - 2, height - 2);
                }

                // Draw text
                using (Font font = new Font("Arial", 16, FontStyle.Bold))
                using (SolidBrush brush = new SolidBrush(Color.Black))
                {
                    SizeF textSize = g.MeasureString(text, font);
                    float x = (width - textSize.Width) / 2;
                    float y = (height - textSize.Height) / 2;
                    g.DrawString(text, font, brush, x, y);
                }
            }

            return bitmap;
        }
    }
}
