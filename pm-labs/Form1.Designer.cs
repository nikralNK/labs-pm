namespace pm_labs
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            tabPage2 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            listBox1 = new ListBox();
            tabPage3 = new TabPage();
            button5 = new Button();
            button4 = new Button();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tabPage4 = new TabPage();
            button6 = new Button();
            button7 = new Button();
            pictureBox4 = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            //
            // tabControl1
            //
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(497, 261);
            tabControl1.TabIndex = 0;
            //
            // tabPage1
            //
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(489, 233);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Работа с ComboBox";
            tabPage1.UseVisualStyleBackColor = true;
            //
            // button1
            //
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(340, 190);
            button1.Name = "button1";
            button1.Size = new Size(140, 30);
            button1.TabIndex = 2;
            button1.Text = "Следующая страница";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            //
            // pictureBox1
            //
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(170, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            //
            // comboBox1
            //
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 10F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Изображение 1", "Изображение 2", "Изображение 3" });
            comboBox1.Location = new Point(15, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 25);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            //
            // tabPage2
            //
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(listBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(489, 233);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Работа с ListBox";
            tabPage2.UseVisualStyleBackColor = true;
            //
            // button3
            //
            button3.Font = new Font("Segoe UI", 10F);
            button3.Location = new Point(340, 190);
            button3.Name = "button3";
            button3.Size = new Size(140, 30);
            button3.TabIndex = 3;
            button3.Text = "Следующая страница";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            //
            // button2
            //
            button2.Font = new Font("Segoe UI", 10F);
            button2.Location = new Point(15, 190);
            button2.Name = "button2";
            button2.Size = new Size(140, 30);
            button2.TabIndex = 2;
            button2.Text = "Предыдущая страница";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            //
            // pictureBox2
            //
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(170, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(310, 160);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            //
            // listBox1
            //
            listBox1.Font = new Font("Segoe UI", 10F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Items.AddRange(new object[] { "Изображение 1", "Изображение 2", "Изображение 3" });
            listBox1.Location = new Point(15, 20);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(140, 106);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            //
            // tabPage3
            //
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(pictureBox3);
            tabPage3.Controls.Add(panel1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(489, 233);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Работа с RadioButton";
            tabPage3.UseVisualStyleBackColor = true;
            //
            // button5
            //
            button5.Font = new Font("Segoe UI", 10F);
            button5.Location = new Point(340, 190);
            button5.Name = "button5";
            button5.Size = new Size(140, 30);
            button5.TabIndex = 3;
            button5.Text = "Следующая страница";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            //
            // button4
            //
            button4.Font = new Font("Segoe UI", 10F);
            button4.Location = new Point(15, 190);
            button4.Name = "button4";
            button4.Size = new Size(140, 30);
            button4.TabIndex = 2;
            button4.Text = "Предыдущая страница";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            //
            // pictureBox3
            //
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(170, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(310, 160);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            //
            // panel1
            //
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(15, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 120);
            panel1.TabIndex = 0;
            //
            // radioButton3
            //
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 10F);
            radioButton3.Location = new Point(10, 75);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(129, 23);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Изображение 3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            //
            // radioButton2
            //
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 10F);
            radioButton2.Location = new Point(10, 45);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(129, 23);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Изображение 2";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            //
            // radioButton1
            //
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 10F);
            radioButton1.Location = new Point(10, 15);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(129, 23);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Изображение 1";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            //
            // tabPage4
            //
            tabPage4.Controls.Add(button6);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(pictureBox4);
            tabPage4.Controls.Add(numericUpDown1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(489, 233);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Работа с NumericUpDown";
            tabPage4.UseVisualStyleBackColor = true;
            //
            // button6
            //
            button6.Font = new Font("Segoe UI", 10F);
            button6.Location = new Point(340, 190);
            button6.Name = "button6";
            button6.Size = new Size(140, 30);
            button6.TabIndex = 3;
            button6.Text = "Выход из программы";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            //
            // button7
            //
            button7.Font = new Font("Segoe UI", 10F);
            button7.Location = new Point(15, 190);
            button7.Name = "button7";
            button7.Size = new Size(140, 30);
            button7.TabIndex = 2;
            button7.Text = "Предыдущая страница";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            //
            // pictureBox4
            //
            pictureBox4.BorderStyle = BorderStyle.FixedSingle;
            pictureBox4.Location = new Point(170, 20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(310, 160);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            //
            // numericUpDown1
            //
            numericUpDown1.Font = new Font("Segoe UI", 10F);
            numericUpDown1.Location = new Point(15, 20);
            numericUpDown1.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(140, 25);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 285);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Использование нескольких компонентов";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private PictureBox pictureBox3;
        private Button button4;
        private Button button5;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox4;
        private Button button7;
        private Button button6;
    }
}
