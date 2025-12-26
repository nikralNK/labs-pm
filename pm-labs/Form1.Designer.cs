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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьДанныеТаблицыВФайлToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            таблицаToolStripMenuItem = new ToolStripMenuItem();
            цветТекстаToolStripMenuItem = new ToolStripMenuItem();
            цветФонаToolStripMenuItem = new ToolStripMenuItem();
            цветСеткиToolStripMenuItem = new ToolStripMenuItem();
            графикToolStripMenuItem = new ToolStripMenuItem();
            цветЛинииГрафикаToolStripMenuItem = new ToolStripMenuItem();
            цветФонаГрафикаToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem1 = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtA = new TextBox();
            txtXh = new TextBox();
            txtXk = new TextBox();
            txtXn = new TextBox();
            tabPage2 = new TabPage();
            dgvResults = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            txtYmin = new TextBox();
            txtYmax = new TextBox();
            label7 = new Label();
            label6 = new Label();
            tabPage3 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            btnExit = new Button();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();

            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, видToolStripMenuItem, выходToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(684, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";

            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьДанныеТаблицыВФайлToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";

            сохранитьДанныеТаблицыВФайлToolStripMenuItem.Name = "сохранитьДанныеТаблицыВФайлToolStripMenuItem";
            сохранитьДанныеТаблицыВФайлToolStripMenuItem.Size = new Size(260, 22);
            сохранитьДанныеТаблицыВФайлToolStripMenuItem.Text = "Сохранить данные таблицы в файл";
            сохранитьДанныеТаблицыВФайлToolStripMenuItem.Click += сохранитьДанныеТаблицыВФайлToolStripMenuItem_Click;

            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(260, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;

            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { таблицаToolStripMenuItem, графикToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(39, 20);
            видToolStripMenuItem.Text = "Вид";

            таблицаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { цветТекстаToolStripMenuItem, цветФонаToolStripMenuItem, цветСеткиToolStripMenuItem });
            таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            таблицаToolStripMenuItem.Size = new Size(180, 22);
            таблицаToolStripMenuItem.Text = "Таблица";

            цветТекстаToolStripMenuItem.Name = "цветТекстаToolStripMenuItem";
            цветТекстаToolStripMenuItem.Size = new Size(180, 22);
            цветТекстаToolStripMenuItem.Text = "Цвет текста";
            цветТекстаToolStripMenuItem.Click += цветТекстаToolStripMenuItem_Click;

            цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            цветФонаToolStripMenuItem.Size = new Size(180, 22);
            цветФонаToolStripMenuItem.Text = "Цвет фона";
            цветФонаToolStripMenuItem.Click += цветФонаToolStripMenuItem_Click;

            цветСеткиToolStripMenuItem.Name = "цветСеткиToolStripMenuItem";
            цветСеткиToolStripMenuItem.Size = new Size(180, 22);
            цветСеткиToolStripMenuItem.Text = "Цвет сетки";
            цветСеткиToolStripMenuItem.Click += цветСеткиToolStripMenuItem_Click;

            графикToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { цветЛинииГрафикаToolStripMenuItem, цветФонаГрафикаToolStripMenuItem });
            графикToolStripMenuItem.Name = "графикToolStripMenuItem";
            графикToolStripMenuItem.Size = new Size(180, 22);
            графикToolStripMenuItem.Text = "График";

            цветЛинииГрафикаToolStripMenuItem.Name = "цветЛинииГрафикаToolStripMenuItem";
            цветЛинииГрафикаToolStripMenuItem.Size = new Size(191, 22);
            цветЛинииГрафикаToolStripMenuItem.Text = "Цвет линии графика";
            цветЛинииГрафикаToolStripMenuItem.Click += цветЛинииГрафикаToolStripMenuItem_Click;

            цветФонаГрафикаToolStripMenuItem.Name = "цветФонаГрафикаToolStripMenuItem";
            цветФонаГрафикаToolStripMenuItem.Size = new Size(191, 22);
            цветФонаГрафикаToolStripMenuItem.Text = "Цвет фона графика";
            цветФонаГрафикаToolStripMenuItem.Click += цветФонаГрафикаToolStripMenuItem_Click;

            выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            выходToolStripMenuItem1.Size = new Size(53, 20);
            выходToolStripMenuItem1.Text = "Выход";
            выходToolStripMenuItem1.Click += выходToolStripMenuItem1_Click;

            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(660, 370);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;

            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtA);
            tabPage1.Controls.Add(txtXh);
            tabPage1.Controls.Add(txtXk);
            tabPage1.Controls.Add(txtXn);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(652, 342);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ввод данных";
            tabPage1.UseVisualStyleBackColor = true;

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(30, 30);
            label1.Name = "label1";
            label1.Size = new Size(247, 19);
            label1.TabIndex = 0;
            label1.Text = "Начальное значение интервала (Xn):";

            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(238, 19);
            label2.TabIndex = 1;
            label2.Text = "Конечное значение интервала (Xk):";

            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(30, 130);
            label3.Name = "label3";
            label3.Size = new Size(233, 19);
            label3.TabIndex = 2;
            label3.Text = "Шаг изменения на интервале (Xh):";

            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(30, 180);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 3;
            label4.Text = "Параметр a:";

            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(30, 240);
            label5.Name = "label5";
            label5.Size = new Size(400, 75);
            label5.TabIndex = 4;
            label5.Text = "Функция:\r\nЕсли x <= 0: y = x^5 * ctg(2*x^3)\r\nЕсли 0 < x <= 5: y = 5 / (tan(2*x + 3) + 1)\r\nЕсли x > 5: y = x^2 * exp(-x)";

            txtXn.Font = new Font("Segoe UI", 10F);
            txtXn.Location = new Point(300, 27);
            txtXn.Name = "txtXn";
            txtXn.Size = new Size(150, 25);
            txtXn.TabIndex = 5;
            txtXn.Text = "-1,6";
            txtXn.KeyPress += ValidateNumberInput;

            txtXk.Font = new Font("Segoe UI", 10F);
            txtXk.Location = new Point(300, 77);
            txtXk.Name = "txtXk";
            txtXk.Size = new Size(150, 25);
            txtXk.TabIndex = 6;
            txtXk.Text = "3,7";
            txtXk.KeyPress += ValidateNumberInput;

            txtXh.Font = new Font("Segoe UI", 10F);
            txtXh.Location = new Point(300, 127);
            txtXh.Name = "txtXh";
            txtXh.Size = new Size(150, 25);
            txtXh.TabIndex = 7;
            txtXh.Text = "0,7";
            txtXh.KeyPress += ValidateNumberInput;

            txtA.Font = new Font("Segoe UI", 10F);
            txtA.Location = new Point(300, 177);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 25);
            txtA.TabIndex = 8;
            txtA.Text = "1";
            txtA.KeyPress += ValidateNumberInput;

            tabPage2.Controls.Add(dgvResults);
            tabPage2.Controls.Add(txtYmin);
            tabPage2.Controls.Add(txtYmax);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(652, 342);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Таблица данных";
            tabPage2.UseVisualStyleBackColor = true;

            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(420, 20);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 0;
            label6.Text = "Ymax:";

            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(420, 60);
            label7.Name = "label7";
            label7.Size = new Size(42, 19);
            label7.TabIndex = 1;
            label7.Text = "Ymin:";

            txtYmax.Font = new Font("Segoe UI", 10F);
            txtYmax.Location = new Point(480, 17);
            txtYmax.Name = "txtYmax";
            txtYmax.ReadOnly = true;
            txtYmax.Size = new Size(150, 25);
            txtYmax.TabIndex = 2;

            txtYmin.Font = new Font("Segoe UI", 10F);
            txtYmin.Location = new Point(480, 57);
            txtYmin.Name = "txtYmin";
            txtYmin.ReadOnly = true;
            txtYmin.Size = new Size(150, 25);
            txtYmin.TabIndex = 3;

            dgvResults.AllowUserToAddRows = false;
            dgvResults.AllowUserToDeleteRows = false;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvResults.Location = new Point(20, 20);
            dgvResults.Name = "dgvResults";
            dgvResults.ReadOnly = true;
            dgvResults.Size = new Size(380, 300);
            dgvResults.TabIndex = 4;

            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 150;

            Column2.HeaderText = "Y";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 180;

            tabPage3.Controls.Add(chart1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(652, 342);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "График функции";
            tabPage3.UseVisualStyleBackColor = true;

            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(20, 20);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(610, 300);
            chart1.TabIndex = 0;

            btnExit.Location = new Point(572, 410);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 30);
            btnExit.TabIndex = 2;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 451);
            Controls.Add(btnExit);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выполнил студент группы ИСПП-242 Кузнецова В.Б.";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьДанныеТаблицыВФайлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem таблицаToolStripMenuItem;
        private ToolStripMenuItem цветТекстаToolStripMenuItem;
        private ToolStripMenuItem цветФонаToolStripMenuItem;
        private ToolStripMenuItem цветСеткиToolStripMenuItem;
        private ToolStripMenuItem графикToolStripMenuItem;
        private ToolStripMenuItem цветЛинииГрафикаToolStripMenuItem;
        private ToolStripMenuItem цветФонаГрафикаToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtXn;
        private TextBox txtXk;
        private TextBox txtXh;
        private TextBox txtA;
        private DataGridView dgvResults;
        private TextBox txtYmax;
        private TextBox txtYmin;
        private Label label6;
        private Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button btnExit;
        private SaveFileDialog saveFileDialog1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
