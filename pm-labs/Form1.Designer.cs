namespace pm_labs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblN = new Label();
            txtN = new TextBox();
            btnGenerate = new Button();
            lstArray = new ListBox();
            btnAnalyze = new Button();
            txtResults = new TextBox();
            lblResults = new Label();
            btnSave = new Button();
            btnLoad = new Button();
            btnClear = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            grpTask = new GroupBox();
            rbTask1 = new RadioButton();
            rbTask2 = new RadioButton();
            rbTask3 = new RadioButton();
            rbTask4 = new RadioButton();
            rbTask5 = new RadioButton();
            rbTask6 = new RadioButton();
            rbTask7 = new RadioButton();
            rbTask8 = new RadioButton();
            rbTask9 = new RadioButton();
            rbTask10 = new RadioButton();
            grpTask.SuspendLayout();
            SuspendLayout();

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

            btnGenerate.Location = new Point(250, 15);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(130, 27);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Сгенерировать";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;

            grpTask.Controls.Add(rbTask10);
            grpTask.Controls.Add(rbTask9);
            grpTask.Controls.Add(rbTask8);
            grpTask.Controls.Add(rbTask7);
            grpTask.Controls.Add(rbTask6);
            grpTask.Controls.Add(rbTask5);
            grpTask.Controls.Add(rbTask4);
            grpTask.Controls.Add(rbTask3);
            grpTask.Controls.Add(rbTask2);
            grpTask.Controls.Add(rbTask1);
            grpTask.Location = new Point(20, 60);
            grpTask.Name = "grpTask";
            grpTask.Size = new Size(560, 180);
            grpTask.TabIndex = 3;
            grpTask.TabStop = false;
            grpTask.Text = "Выберите задание";

            rbTask1.AutoSize = true;
            rbTask1.Checked = true;
            rbTask1.Location = new Point(15, 25);
            rbTask1.Name = "rbTask1";
            rbTask1.Size = new Size(480, 19);
            rbTask1.TabIndex = 0;
            rbTask1.TabStop = true;
            rbTask1.Text = "1. Количество отрицательных, положительных и среднее арифметическое";

            rbTask2.AutoSize = true;
            rbTask2.Location = new Point(15, 45);
            rbTask2.Name = "rbTask2";
            rbTask2.Size = new Size(470, 19);
            rbTask2.TabIndex = 1;
            rbTask2.Text = "2. Разделить на два массива (четные/нечетные индексы) и найти суммы";

            rbTask3.AutoSize = true;
            rbTask3.Location = new Point(15, 65);
            rbTask3.Name = "rbTask3";
            rbTask3.Size = new Size(480, 19);
            rbTask3.TabIndex = 2;
            rbTask3.Text = "3. Среднее арифметическое первого отрицательного и последнего положительного";

            rbTask4.AutoSize = true;
            rbTask4.Location = new Point(15, 85);
            rbTask4.Name = "rbTask4";
            rbTask4.Size = new Size(500, 19);
            rbTask4.TabIndex = 3;
            rbTask4.Text = "4. Количество отрицательных перед наибольшим положительным";

            rbTask5.AutoSize = true;
            rbTask5.Location = new Point(15, 105);
            rbTask5.Name = "rbTask5";
            rbTask5.Size = new Size(410, 19);
            rbTask5.TabIndex = 4;
            rbTask5.Text = "5. Поменять местами первый и последний положительные элементы";

            rbTask6.AutoSize = true;
            rbTask6.Location = new Point(15, 125);
            rbTask6.Name = "rbTask6";
            rbTask6.Size = new Size(340, 19);
            rbTask6.TabIndex = 5;
            rbTask6.Text = "6. Сумма и среднее арифметическое (10 элементов)";

            rbTask7.AutoSize = true;
            rbTask7.Location = new Point(15, 145);
            rbTask7.Name = "rbTask7";
            rbTask7.Size = new Size(320, 19);
            rbTask7.TabIndex = 6;
            rbTask7.Text = "7. Сумма положительных элементов (20 элементов)";

            rbTask8.AutoSize = true;
            rbTask8.Location = new Point(290, 25);
            rbTask8.Name = "rbTask8";
            rbTask8.Size = new Size(260, 19);
            rbTask8.TabIndex = 7;
            rbTask8.Text = "8. Сумма четных элементов (20 элементов)";

            rbTask9.AutoSize = true;
            rbTask9.Location = new Point(290, 45);
            rbTask9.Name = "rbTask9";
            rbTask9.Size = new Size(270, 19);
            rbTask9.TabIndex = 8;
            rbTask9.Text = "9. Количество положительных (20 элементов)";

            rbTask10.AutoSize = true;
            rbTask10.Location = new Point(290, 65);
            rbTask10.Name = "rbTask10";
            rbTask10.Size = new Size(260, 19);
            rbTask10.TabIndex = 9;
            rbTask10.Text = "10. Индексы положительных (20 элементов)";

            lstArray.FormattingEnabled = true;
            lstArray.ItemHeight = 15;
            lstArray.Location = new Point(20, 250);
            lstArray.Name = "lstArray";
            lstArray.Size = new Size(200, 139);
            lstArray.TabIndex = 4;

            btnAnalyze.Location = new Point(20, 400);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(200, 30);
            btnAnalyze.TabIndex = 5;
            btnAnalyze.Text = "Выполнить задание";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;

            lblResults.AutoSize = true;
            lblResults.Location = new Point(240, 250);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(70, 15);
            lblResults.TabIndex = 6;
            lblResults.Text = "Результаты:";

            txtResults.Location = new Point(240, 270);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(340, 119);
            txtResults.TabIndex = 7;

            btnSave.Location = new Point(240, 400);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Сохранить в файл";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;

            btnLoad.Location = new Point(420, 400);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(160, 30);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Загрузить из файла";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;

            btnClear.Location = new Point(240, 440);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(340, 30);
            btnClear.TabIndex = 10;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Title = "Сохранить массив";

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog1.Title = "Открыть массив";

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 485);
            Controls.Add(btnClear);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(txtResults);
            Controls.Add(lblResults);
            Controls.Add(btnAnalyze);
            Controls.Add(lstArray);
            Controls.Add(grpTask);
            Controls.Add(btnGenerate);
            Controls.Add(txtN);
            Controls.Add(lblN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выполнил студент группы ИСПП-242 Кузнецова В.Б.";
            grpTask.ResumeLayout(false);
            grpTask.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblN;
        private TextBox txtN;
        private Button btnGenerate;
        private ListBox lstArray;
        private Button btnAnalyze;
        private TextBox txtResults;
        private Label lblResults;
        private Button btnSave;
        private Button btnLoad;
        private Button btnClear;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private GroupBox grpTask;
        private RadioButton rbTask1;
        private RadioButton rbTask2;
        private RadioButton rbTask3;
        private RadioButton rbTask4;
        private RadioButton rbTask5;
        private RadioButton rbTask6;
        private RadioButton rbTask7;
        private RadioButton rbTask8;
        private RadioButton rbTask9;
        private RadioButton rbTask10;
    }
}
