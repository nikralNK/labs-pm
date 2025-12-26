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
            grpOperations = new GroupBox();
            rbCountNegative = new RadioButton();
            rbSumNegative = new RadioButton();
            rbMinDivisible5 = new RadioButton();
            btnCalculate = new Button();
            lblResult = new Label();
            txtResult = new TextBox();
            btnClear = new Button();
            grpOperations.SuspendLayout();
            SuspendLayout();

            lblN.AutoSize = true;
            lblN.Location = new Point(20, 20);
            lblN.Name = "lblN";
            lblN.Size = new Size(140, 15);
            lblN.TabIndex = 0;
            lblN.Text = "Размер массива (N):";

            txtN.Location = new Point(170, 17);
            txtN.Name = "txtN";
            txtN.Size = new Size(100, 23);
            txtN.TabIndex = 1;

            btnGenerate.Location = new Point(290, 15);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(120, 27);
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

            grpOperations.Controls.Add(rbMinDivisible5);
            grpOperations.Controls.Add(rbSumNegative);
            grpOperations.Controls.Add(rbCountNegative);
            grpOperations.Location = new Point(240, 60);
            grpOperations.Name = "grpOperations";
            grpOperations.Size = new Size(300, 120);
            grpOperations.TabIndex = 4;
            grpOperations.TabStop = false;
            grpOperations.Text = "Выберите операцию";

            rbCountNegative.AutoSize = true;
            rbCountNegative.Checked = true;
            rbCountNegative.Location = new Point(15, 25);
            rbCountNegative.Name = "rbCountNegative";
            rbCountNegative.Size = new Size(265, 19);
            rbCountNegative.TabIndex = 0;
            rbCountNegative.TabStop = true;
            rbCountNegative.Text = "Количество отрицательных элементов";
            rbCountNegative.UseVisualStyleBackColor = true;

            rbSumNegative.AutoSize = true;
            rbSumNegative.Location = new Point(15, 55);
            rbSumNegative.Name = "rbSumNegative";
            rbSumNegative.Size = new Size(240, 19);
            rbSumNegative.TabIndex = 1;
            rbSumNegative.Text = "Сумма отрицательных элементов";
            rbSumNegative.UseVisualStyleBackColor = true;

            rbMinDivisible5.AutoSize = true;
            rbMinDivisible5.Location = new Point(15, 85);
            rbMinDivisible5.Name = "rbMinDivisible5";
            rbMinDivisible5.Size = new Size(270, 19);
            rbMinDivisible5.TabIndex = 2;
            rbMinDivisible5.Text = "Минимальный элемент, кратный 5";
            rbMinDivisible5.UseVisualStyleBackColor = true;

            btnCalculate.Location = new Point(240, 195);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(140, 30);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;

            lblResult.AutoSize = true;
            lblResult.Location = new Point(240, 240);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(70, 15);
            lblResult.TabIndex = 6;
            lblResult.Text = "Результат:";

            txtResult.Location = new Point(240, 260);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(300, 23);
            txtResult.TabIndex = 7;

            btnClear.Location = new Point(400, 195);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 30);
            btnClear.TabIndex = 8;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 371);
            Controls.Add(btnClear);
            Controls.Add(txtResult);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(grpOperations);
            Controls.Add(lstArray);
            Controls.Add(btnGenerate);
            Controls.Add(txtN);
            Controls.Add(lblN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Работа с массивом - Студент ИСПП-242";
            grpOperations.ResumeLayout(false);
            grpOperations.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblN;
        private TextBox txtN;
        private Button btnGenerate;
        private ListBox lstArray;
        private GroupBox grpOperations;
        private RadioButton rbCountNegative;
        private RadioButton rbSumNegative;
        private RadioButton rbMinDivisible5;
        private Button btnCalculate;
        private Label lblResult;
        private TextBox txtResult;
        private Button btnClear;
    }
}
