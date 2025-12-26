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
            lblA = new Label();
            lblXn = new Label();
            lblXk = new Label();
            lblXh = new Label();
            txtA = new TextBox();
            txtXn = new TextBox();
            txtXk = new TextBox();
            txtXh = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lstResults = new ListBox();
            lblResults = new Label();
            lblMin = new Label();
            lblMax = new Label();
            txtMin = new TextBox();
            txtMax = new TextBox();
            SuspendLayout();

            lblA.AutoSize = true;
            lblA.Location = new Point(20, 20);
            lblA.Name = "lblA";
            lblA.Size = new Size(80, 15);
            lblA.TabIndex = 0;
            lblA.Text = "Параметр a:";

            txtA.Location = new Point(120, 17);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 1;

            lblXn.AutoSize = true;
            lblXn.Location = new Point(20, 55);
            lblXn.Name = "lblXn";
            lblXn.Size = new Size(95, 15);
            lblXn.TabIndex = 2;
            lblXn.Text = "Начало (xn):";

            txtXn.Location = new Point(120, 52);
            txtXn.Name = "txtXn";
            txtXn.Size = new Size(100, 23);
            txtXn.TabIndex = 3;
            txtXn.Text = "3,35";

            lblXk.AutoSize = true;
            lblXk.Location = new Point(20, 90);
            lblXk.Name = "lblXk";
            lblXk.Size = new Size(85, 15);
            lblXk.TabIndex = 4;
            lblXk.Text = "Конец (xk):";

            txtXk.Location = new Point(120, 87);
            txtXk.Name = "txtXk";
            txtXk.Size = new Size(100, 23);
            txtXk.TabIndex = 5;
            txtXk.Text = "36,26";

            lblXh.AutoSize = true;
            lblXh.Location = new Point(20, 125);
            lblXh.Name = "lblXh";
            lblXh.Size = new Size(70, 15);
            lblXh.TabIndex = 6;
            lblXh.Text = "Шаг (xh):";

            txtXh.Location = new Point(120, 122);
            txtXh.Name = "txtXh";
            txtXh.Size = new Size(100, 23);
            txtXh.TabIndex = 7;
            txtXh.Text = "0,2";

            btnCalculate.Location = new Point(20, 165);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 30);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;

            btnClear.Location = new Point(130, 165);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 30);
            btnClear.TabIndex = 9;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            btnExit.Location = new Point(240, 165);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 30);
            btnExit.TabIndex = 10;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;

            lblResults.AutoSize = true;
            lblResults.Location = new Point(370, 20);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(120, 15);
            lblResults.TabIndex = 11;
            lblResults.Text = "Результаты:";

            lstResults.FormattingEnabled = true;
            lstResults.ItemHeight = 15;
            lstResults.Location = new Point(370, 45);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(400, 289);
            lstResults.TabIndex = 12;

            lblMin.AutoSize = true;
            lblMin.Location = new Point(370, 350);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(120, 15);
            lblMin.TabIndex = 13;
            lblMin.Text = "Минимум (f_min):";

            txtMin.Location = new Point(500, 347);
            txtMin.Name = "txtMin";
            txtMin.ReadOnly = true;
            txtMin.Size = new Size(270, 23);
            txtMin.TabIndex = 14;

            lblMax.AutoSize = true;
            lblMax.Location = new Point(370, 385);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(125, 15);
            lblMax.TabIndex = 15;
            lblMax.Text = "Максимум (f_max):";

            txtMax.Location = new Point(500, 382);
            txtMax.Name = "txtMax";
            txtMax.ReadOnly = true;
            txtMax.Size = new Size(270, 23);
            txtMax.TabIndex = 16;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Controls.Add(txtMax);
            Controls.Add(lblMax);
            Controls.Add(txtMin);
            Controls.Add(lblMin);
            Controls.Add(lstResults);
            Controls.Add(lblResults);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtXh);
            Controls.Add(lblXh);
            Controls.Add(txtXk);
            Controls.Add(lblXk);
            Controls.Add(txtXn);
            Controls.Add(lblXn);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Name = "Form1";
            Text = "Вычисление функции с экстремумами";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblXn;
        private Label lblXk;
        private Label lblXh;
        private TextBox txtA;
        private TextBox txtXn;
        private TextBox txtXk;
        private TextBox txtXh;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private ListBox lstResults;
        private Label lblResults;
        private Label lblMin;
        private Label lblMax;
        private TextBox txtMin;
        private TextBox txtMax;
    }
}
