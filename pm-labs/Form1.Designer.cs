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
            btnClear1D = new Button();
            btnLoad1D = new Button();
            btnSave1D = new Button();
            txtResults1D = new TextBox();
            lblResults1D = new Label();
            btnAnalyze1D = new Button();
            lstArray = new ListBox();
            grpTask1D = new GroupBox();
            rbTask1D_10 = new RadioButton();
            rbTask1D_9 = new RadioButton();
            rbTask1D_8 = new RadioButton();
            rbTask1D_7 = new RadioButton();
            rbTask1D_6 = new RadioButton();
            rbTask1D_5 = new RadioButton();
            rbTask1D_4 = new RadioButton();
            rbTask1D_3 = new RadioButton();
            rbTask1D_2 = new RadioButton();
            rbTask1D_1 = new RadioButton();
            btnGenerate1D = new Button();
            txtN = new TextBox();
            lblN = new Label();
            tabPage2 = new TabPage();
            btnClear2D = new Button();
            btnLoad2D = new Button();
            btnSave2D = new Button();
            txtResults2D = new TextBox();
            lblResults2D = new Label();
            btnAnalyze2D = new Button();
            dgvMatrix = new DataGridView();
            grpTask2D = new GroupBox();
            rbTask2D_10 = new RadioButton();
            rbTask2D_9 = new RadioButton();
            rbTask2D_8 = new RadioButton();
            rbTask2D_7 = new RadioButton();
            rbTask2D_6 = new RadioButton();
            rbTask2D_5 = new RadioButton();
            rbTask2D_4 = new RadioButton();
            rbTask2D_3 = new RadioButton();
            rbTask2D_2 = new RadioButton();
            rbTask2D_1 = new RadioButton();
            btnGenerate2D = new Button();
            txtCols = new TextBox();
            lblCols = new Label();
            txtRows = new TextBox();
            lblRows = new Label();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            grpTask1D.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).BeginInit();
            grpTask2D.SuspendLayout();
            SuspendLayout();

            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 550);
            tabControl1.TabIndex = 0;

            tabPage1.Controls.Add(btnClear1D);
            tabPage1.Controls.Add(btnLoad1D);
            tabPage1.Controls.Add(btnSave1D);
            tabPage1.Controls.Add(txtResults1D);
            tabPage1.Controls.Add(lblResults1D);
            tabPage1.Controls.Add(btnAnalyze1D);
            tabPage1.Controls.Add(lstArray);
            tabPage1.Controls.Add(grpTask1D);
            tabPage1.Controls.Add(btnGenerate1D);
            tabPage1.Controls.Add(txtN);
            tabPage1.Controls.Add(lblN);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 522);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Одномерные массивы";
            tabPage1.UseVisualStyleBackColor = true;

            lblN.AutoSize = true;
            lblN.Location = new Point(20, 20);
            lblN.Name = "lblN";
            lblN.Size = new Size(95, 15);
            lblN.TabIndex = 0;
            lblN.Text = "Размер массива:";

            txtN.Location = new Point(130, 17);
            txtN.Name = "txtN";
            txtN.Size = new Size(100, 23);
            txtN.TabIndex = 1;

            btnGenerate1D.Location = new Point(250, 15);
            btnGenerate1D.Name = "btnGenerate1D";
            btnGenerate1D.Size = new Size(130, 27);
            btnGenerate1D.TabIndex = 2;
            btnGenerate1D.Text = "Сгенерировать";
            btnGenerate1D.UseVisualStyleBackColor = true;
            btnGenerate1D.Click += btnGenerate1D_Click;

            grpTask1D.Controls.Add(rbTask1D_10);
            grpTask1D.Controls.Add(rbTask1D_9);
            grpTask1D.Controls.Add(rbTask1D_8);
            grpTask1D.Controls.Add(rbTask1D_7);
            grpTask1D.Controls.Add(rbTask1D_6);
            grpTask1D.Controls.Add(rbTask1D_5);
            grpTask1D.Controls.Add(rbTask1D_4);
            grpTask1D.Controls.Add(rbTask1D_3);
            grpTask1D.Controls.Add(rbTask1D_2);
            grpTask1D.Controls.Add(rbTask1D_1);
            grpTask1D.Location = new Point(20, 60);
            grpTask1D.Name = "grpTask1D";
            grpTask1D.Size = new Size(750, 180);
            grpTask1D.TabIndex = 3;
            grpTask1D.TabStop = false;
            grpTask1D.Text = "Выберите задание";

            rbTask1D_1.AutoSize = true;
            rbTask1D_1.Checked = true;
            rbTask1D_1.Location = new Point(15, 25);
            rbTask1D_1.Name = "rbTask1D_1";
            rbTask1D_1.Size = new Size(480, 19);
            rbTask1D_1.TabIndex = 0;
            rbTask1D_1.TabStop = true;
            rbTask1D_1.Text = "1. Количество отрицательных, положительных и среднее арифметическое";

            rbTask1D_2.AutoSize = true;
            rbTask1D_2.Location = new Point(15, 45);
            rbTask1D_2.Name = "rbTask1D_2";
            rbTask1D_2.Size = new Size(470, 19);
            rbTask1D_2.TabIndex = 1;
            rbTask1D_2.Text = "2. Разделить на два массива (четные/нечетные индексы) и найти суммы";

            rbTask1D_3.AutoSize = true;
            rbTask1D_3.Location = new Point(15, 65);
            rbTask1D_3.Name = "rbTask1D_3";
            rbTask1D_3.Size = new Size(480, 19);
            rbTask1D_3.TabIndex = 2;
            rbTask1D_3.Text = "3. Среднее арифметическое первого отрицательного и последнего положительного";

            rbTask1D_4.AutoSize = true;
            rbTask1D_4.Location = new Point(15, 85);
            rbTask1D_4.Name = "rbTask1D_4";
            rbTask1D_4.Size = new Size(500, 19);
            rbTask1D_4.TabIndex = 3;
            rbTask1D_4.Text = "4. Количество отрицательных перед наибольшим положительным";

            rbTask1D_5.AutoSize = true;
            rbTask1D_5.Location = new Point(15, 105);
            rbTask1D_5.Name = "rbTask1D_5";
            rbTask1D_5.Size = new Size(410, 19);
            rbTask1D_5.TabIndex = 4;
            rbTask1D_5.Text = "5. Поменять местами первый и последний положительные элементы";

            rbTask1D_6.AutoSize = true;
            rbTask1D_6.Location = new Point(15, 125);
            rbTask1D_6.Name = "rbTask1D_6";
            rbTask1D_6.Size = new Size(340, 19);
            rbTask1D_6.TabIndex = 5;
            rbTask1D_6.Text = "6. Сумма и среднее арифметическое (10 элементов)";

            rbTask1D_7.AutoSize = true;
            rbTask1D_7.Location = new Point(15, 145);
            rbTask1D_7.Name = "rbTask1D_7";
            rbTask1D_7.Size = new Size(320, 19);
            rbTask1D_7.TabIndex = 6;
            rbTask1D_7.Text = "7. Сумма положительных элементов (20 элементов)";

            rbTask1D_8.AutoSize = true;
            rbTask1D_8.Location = new Point(520, 25);
            rbTask1D_8.Name = "rbTask1D_8";
            rbTask1D_8.Size = new Size(220, 19);
            rbTask1D_8.TabIndex = 7;
            rbTask1D_8.Text = "8. Сумма четных элементов (20)";

            rbTask1D_9.AutoSize = true;
            rbTask1D_9.Location = new Point(520, 45);
            rbTask1D_9.Name = "rbTask1D_9";
            rbTask1D_9.Size = new Size(220, 19);
            rbTask1D_9.TabIndex = 8;
            rbTask1D_9.Text = "9. Количество положительных (20)";

            rbTask1D_10.AutoSize = true;
            rbTask1D_10.Location = new Point(520, 65);
            rbTask1D_10.Name = "rbTask1D_10";
            rbTask1D_10.Size = new Size(220, 19);
            rbTask1D_10.TabIndex = 9;
            rbTask1D_10.Text = "10. Индексы положительных (20)";

            lstArray.FormattingEnabled = true;
            lstArray.ItemHeight = 15;
            lstArray.Location = new Point(20, 250);
            lstArray.Name = "lstArray";
            lstArray.Size = new Size(200, 169);
            lstArray.TabIndex = 4;

            btnAnalyze1D.Location = new Point(20, 430);
            btnAnalyze1D.Name = "btnAnalyze1D";
            btnAnalyze1D.Size = new Size(200, 30);
            btnAnalyze1D.TabIndex = 5;
            btnAnalyze1D.Text = "Выполнить задание";
            btnAnalyze1D.UseVisualStyleBackColor = true;
            btnAnalyze1D.Click += btnAnalyze1D_Click;

            lblResults1D.AutoSize = true;
            lblResults1D.Location = new Point(240, 250);
            lblResults1D.Name = "lblResults1D";
            lblResults1D.Size = new Size(70, 15);
            lblResults1D.TabIndex = 6;
            lblResults1D.Text = "Результаты:";

            txtResults1D.Location = new Point(240, 270);
            txtResults1D.Multiline = true;
            txtResults1D.Name = "txtResults1D";
            txtResults1D.ReadOnly = true;
            txtResults1D.ScrollBars = ScrollBars.Vertical;
            txtResults1D.Size = new Size(530, 149);
            txtResults1D.TabIndex = 7;

            btnSave1D.Location = new Point(240, 430);
            btnSave1D.Name = "btnSave1D";
            btnSave1D.Size = new Size(170, 30);
            btnSave1D.TabIndex = 8;
            btnSave1D.Text = "Сохранить в файл";
            btnSave1D.UseVisualStyleBackColor = true;
            btnSave1D.Click += btnSave1D_Click;

            btnLoad1D.Location = new Point(430, 430);
            btnLoad1D.Name = "btnLoad1D";
            btnLoad1D.Size = new Size(170, 30);
            btnLoad1D.TabIndex = 9;
            btnLoad1D.Text = "Загрузить из файла";
            btnLoad1D.UseVisualStyleBackColor = true;
            btnLoad1D.Click += btnLoad1D_Click;

            btnClear1D.Location = new Point(620, 430);
            btnClear1D.Name = "btnClear1D";
            btnClear1D.Size = new Size(150, 30);
            btnClear1D.TabIndex = 10;
            btnClear1D.Text = "Очистить";
            btnClear1D.UseVisualStyleBackColor = true;
            btnClear1D.Click += btnClear1D_Click;

            tabPage2.Controls.Add(btnClear2D);
            tabPage2.Controls.Add(btnLoad2D);
            tabPage2.Controls.Add(btnSave2D);
            tabPage2.Controls.Add(txtResults2D);
            tabPage2.Controls.Add(lblResults2D);
            tabPage2.Controls.Add(btnAnalyze2D);
            tabPage2.Controls.Add(dgvMatrix);
            tabPage2.Controls.Add(grpTask2D);
            tabPage2.Controls.Add(btnGenerate2D);
            tabPage2.Controls.Add(txtCols);
            tabPage2.Controls.Add(lblCols);
            tabPage2.Controls.Add(txtRows);
            tabPage2.Controls.Add(lblRows);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 522);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Двумерные массивы";
            tabPage2.UseVisualStyleBackColor = true;

            lblRows.AutoSize = true;
            lblRows.Location = new Point(20, 20);
            lblRows.Name = "lblRows";
            lblRows.Size = new Size(100, 15);
            lblRows.TabIndex = 0;
            lblRows.Text = "Количество строк:";

            txtRows.Location = new Point(130, 17);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(60, 23);
            txtRows.TabIndex = 1;

            lblCols.AutoSize = true;
            lblCols.Location = new Point(210, 20);
            lblCols.Name = "lblCols";
            lblCols.Size = new Size(120, 15);
            lblCols.TabIndex = 2;
            lblCols.Text = "Количество столбцов:";

            txtCols.Location = new Point(340, 17);
            txtCols.Name = "txtCols";
            txtCols.Size = new Size(60, 23);
            txtCols.TabIndex = 3;

            btnGenerate2D.Location = new Point(420, 15);
            btnGenerate2D.Name = "btnGenerate2D";
            btnGenerate2D.Size = new Size(130, 27);
            btnGenerate2D.TabIndex = 4;
            btnGenerate2D.Text = "Сгенерировать";
            btnGenerate2D.UseVisualStyleBackColor = true;
            btnGenerate2D.Click += btnGenerate2D_Click;

            grpTask2D.Controls.Add(rbTask2D_10);
            grpTask2D.Controls.Add(rbTask2D_9);
            grpTask2D.Controls.Add(rbTask2D_8);
            grpTask2D.Controls.Add(rbTask2D_7);
            grpTask2D.Controls.Add(rbTask2D_6);
            grpTask2D.Controls.Add(rbTask2D_5);
            grpTask2D.Controls.Add(rbTask2D_4);
            grpTask2D.Controls.Add(rbTask2D_3);
            grpTask2D.Controls.Add(rbTask2D_2);
            grpTask2D.Controls.Add(rbTask2D_1);
            grpTask2D.Location = new Point(20, 60);
            grpTask2D.Name = "grpTask2D";
            grpTask2D.Size = new Size(750, 180);
            grpTask2D.TabIndex = 5;
            grpTask2D.TabStop = false;
            grpTask2D.Text = "Выберите задание";

            rbTask2D_1.AutoSize = true;
            rbTask2D_1.Checked = true;
            rbTask2D_1.Location = new Point(15, 25);
            rbTask2D_1.Name = "rbTask2D_1";
            rbTask2D_1.Size = new Size(280, 19);
            rbTask2D_1.TabIndex = 0;
            rbTask2D_1.TabStop = true;
            rbTask2D_1.Text = "1. Сумма элементов в каждом столбце";

            rbTask2D_2.AutoSize = true;
            rbTask2D_2.Location = new Point(15, 45);
            rbTask2D_2.Name = "rbTask2D_2";
            rbTask2D_2.Size = new Size(320, 19);
            rbTask2D_2.TabIndex = 1;
            rbTask2D_2.Text = "2. Произведение элементов в каждом столбце";

            rbTask2D_3.AutoSize = true;
            rbTask2D_3.Location = new Point(15, 65);
            rbTask2D_3.Name = "rbTask2D_3";
            rbTask2D_3.Size = new Size(310, 19);
            rbTask2D_3.TabIndex = 2;
            rbTask2D_3.Text = "3. Произведение элементов в каждой строке";

            rbTask2D_4.AutoSize = true;
            rbTask2D_4.Location = new Point(15, 85);
            rbTask2D_4.Name = "rbTask2D_4";
            rbTask2D_4.Size = new Size(330, 19);
            rbTask2D_4.TabIndex = 3;
            rbTask2D_4.Text = "4. Произведение диагональных элементов";

            rbTask2D_5.AutoSize = true;
            rbTask2D_5.Location = new Point(15, 105);
            rbTask2D_5.Name = "rbTask2D_5";
            rbTask2D_5.Size = new Size(310, 19);
            rbTask2D_5.TabIndex = 4;
            rbTask2D_5.Text = "5. Сумма элементов на побочной диагонали";

            rbTask2D_6.AutoSize = true;
            rbTask2D_6.Location = new Point(15, 125);
            rbTask2D_6.Name = "rbTask2D_6";
            rbTask2D_6.Size = new Size(340, 19);
            rbTask2D_6.TabIndex = 5;
            rbTask2D_6.Text = "6. Столбец с наименьшим количеством положительных";

            rbTask2D_7.AutoSize = true;
            rbTask2D_7.Location = new Point(15, 145);
            rbTask2D_7.Name = "rbTask2D_7";
            rbTask2D_7.Size = new Size(330, 19);
            rbTask2D_7.TabIndex = 6;
            rbTask2D_7.Text = "7. Строка с наименьшим количеством положительных";

            rbTask2D_8.AutoSize = true;
            rbTask2D_8.Location = new Point(380, 25);
            rbTask2D_8.Name = "rbTask2D_8";
            rbTask2D_8.Size = new Size(340, 19);
            rbTask2D_8.TabIndex = 7;
            rbTask2D_8.Text = "8. Строка с наибольшим количеством четных";

            rbTask2D_9.AutoSize = true;
            rbTask2D_9.Location = new Point(380, 45);
            rbTask2D_9.Name = "rbTask2D_9";
            rbTask2D_9.Size = new Size(360, 19);
            rbTask2D_9.TabIndex = 8;
            rbTask2D_9.Text = "9. Столбец с наибольшим количеством кратных 5";

            rbTask2D_10.AutoSize = true;
            rbTask2D_10.Location = new Point(380, 65);
            rbTask2D_10.Name = "rbTask2D_10";
            rbTask2D_10.Size = new Size(290, 19);
            rbTask2D_10.TabIndex = 9;
            rbTask2D_10.Text = "10. Наименьшее четное число в матрице";

            dgvMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrix.Location = new Point(20, 250);
            dgvMatrix.Name = "dgvMatrix";
            dgvMatrix.RowHeadersWidth = 51;
            dgvMatrix.Size = new Size(400, 169);
            dgvMatrix.TabIndex = 6;

            btnAnalyze2D.Location = new Point(20, 430);
            btnAnalyze2D.Name = "btnAnalyze2D";
            btnAnalyze2D.Size = new Size(200, 30);
            btnAnalyze2D.TabIndex = 7;
            btnAnalyze2D.Text = "Выполнить задание";
            btnAnalyze2D.UseVisualStyleBackColor = true;
            btnAnalyze2D.Click += btnAnalyze2D_Click;

            lblResults2D.AutoSize = true;
            lblResults2D.Location = new Point(440, 250);
            lblResults2D.Name = "lblResults2D";
            lblResults2D.Size = new Size(70, 15);
            lblResults2D.TabIndex = 8;
            lblResults2D.Text = "Результаты:";

            txtResults2D.Location = new Point(440, 270);
            txtResults2D.Multiline = true;
            txtResults2D.Name = "txtResults2D";
            txtResults2D.ReadOnly = true;
            txtResults2D.ScrollBars = ScrollBars.Vertical;
            txtResults2D.Size = new Size(330, 149);
            txtResults2D.TabIndex = 9;

            btnSave2D.Location = new Point(240, 430);
            btnSave2D.Name = "btnSave2D";
            btnSave2D.Size = new Size(170, 30);
            btnSave2D.TabIndex = 10;
            btnSave2D.Text = "Сохранить в файл";
            btnSave2D.UseVisualStyleBackColor = true;
            btnSave2D.Click += btnSave2D_Click;

            btnLoad2D.Location = new Point(430, 430);
            btnLoad2D.Name = "btnLoad2D";
            btnLoad2D.Size = new Size(170, 30);
            btnLoad2D.TabIndex = 11;
            btnLoad2D.Text = "Загрузить из файла";
            btnLoad2D.UseVisualStyleBackColor = true;
            btnLoad2D.Click += btnLoad2D_Click;

            btnClear2D.Location = new Point(620, 430);
            btnClear2D.Name = "btnClear2D";
            btnClear2D.Size = new Size(150, 30);
            btnClear2D.TabIndex = 12;
            btnClear2D.Text = "Очистить";
            btnClear2D.UseVisualStyleBackColor = true;
            btnClear2D.Click += btnClear2D_Click;

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Title = "Сохранить массив";

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog1.Title = "Открыть массив";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выполнил студент группы ИСПП-242 Кузнецова В.Б.";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            grpTask1D.ResumeLayout(false);
            grpTask1D.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).EndInit();
            grpTask2D.ResumeLayout(false);
            grpTask2D.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblN;
        private TextBox txtN;
        private Button btnGenerate1D;
        private GroupBox grpTask1D;
        private RadioButton rbTask1D_1;
        private RadioButton rbTask1D_2;
        private RadioButton rbTask1D_3;
        private RadioButton rbTask1D_4;
        private RadioButton rbTask1D_5;
        private RadioButton rbTask1D_6;
        private RadioButton rbTask1D_7;
        private RadioButton rbTask1D_8;
        private RadioButton rbTask1D_9;
        private RadioButton rbTask1D_10;
        private ListBox lstArray;
        private Button btnAnalyze1D;
        private Label lblResults1D;
        private TextBox txtResults1D;
        private Button btnSave1D;
        private Button btnLoad1D;
        private Button btnClear1D;
        private Label lblRows;
        private TextBox txtRows;
        private Label lblCols;
        private TextBox txtCols;
        private Button btnGenerate2D;
        private GroupBox grpTask2D;
        private RadioButton rbTask2D_1;
        private RadioButton rbTask2D_2;
        private RadioButton rbTask2D_3;
        private RadioButton rbTask2D_4;
        private RadioButton rbTask2D_5;
        private RadioButton rbTask2D_6;
        private RadioButton rbTask2D_7;
        private RadioButton rbTask2D_8;
        private RadioButton rbTask2D_9;
        private RadioButton rbTask2D_10;
        private DataGridView dgvMatrix;
        private Button btnAnalyze2D;
        private Label lblResults2D;
        private TextBox txtResults2D;
        private Button btnSave2D;
        private Button btnLoad2D;
        private Button btnClear2D;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
