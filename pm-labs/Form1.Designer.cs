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

            lstArray.FormattingEnabled = true;
            lstArray.ItemHeight = 15;
            lstArray.Location = new Point(20, 60);
            lstArray.Name = "lstArray";
            lstArray.Size = new Size(200, 289);
            lstArray.TabIndex = 3;

            btnAnalyze.Location = new Point(20, 365);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(200, 30);
            btnAnalyze.TabIndex = 4;
            btnAnalyze.Text = "Анализ массива";
            btnAnalyze.UseVisualStyleBackColor = true;
            btnAnalyze.Click += btnAnalyze_Click;

            lblResults.AutoSize = true;
            lblResults.Location = new Point(240, 60);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(70, 15);
            lblResults.TabIndex = 5;
            lblResults.Text = "Результаты:";

            txtResults.Location = new Point(240, 85);
            txtResults.Multiline = true;
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.ScrollBars = ScrollBars.Vertical;
            txtResults.Size = new Size(340, 180);
            txtResults.TabIndex = 6;

            btnSave.Location = new Point(240, 285);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 30);
            btnSave.TabIndex = 7;
            btnSave.Text = "Сохранить в файл";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;

            btnLoad.Location = new Point(420, 285);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(160, 30);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Загрузить из файла";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;

            btnClear.Location = new Point(240, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(340, 30);
            btnClear.TabIndex = 9;
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
            ClientSize = new Size(600, 410);
            Controls.Add(btnClear);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(txtResults);
            Controls.Add(lblResults);
            Controls.Add(btnAnalyze);
            Controls.Add(lstArray);
            Controls.Add(btnGenerate);
            Controls.Add(txtN);
            Controls.Add(lblN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выполнил студент группы ИСПП-242 Кузнецова В.Б.";
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
    }
}
