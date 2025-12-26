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
            lblX = new Label();
            lblY = new Label();
            txtA = new TextBox();
            txtX = new TextBox();
            txtY = new TextBox();
            btnCalculate = new Button();
            btnExit = new Button();
            chkSelectFunction = new CheckBox();
            grpFunctions = new GroupBox();
            rbFunction1 = new RadioButton();
            rbFunction2 = new RadioButton();
            rbFunction3 = new RadioButton();
            grpFunctions.SuspendLayout();
            SuspendLayout();

            lblA.AutoSize = true;
            lblA.Location = new Point(30, 30);
            lblA.Name = "lblA";
            lblA.Size = new Size(95, 15);
            lblA.TabIndex = 0;
            lblA.Text = "Параметр a:";

            txtA.Location = new Point(140, 27);
            txtA.Name = "txtA";
            txtA.Size = new Size(150, 23);
            txtA.TabIndex = 1;

            lblX.AutoSize = true;
            lblX.Location = new Point(30, 65);
            lblX.Name = "lblX";
            lblX.Size = new Size(95, 15);
            lblX.TabIndex = 2;
            lblX.Text = "Переменная x:";

            txtX.Location = new Point(140, 62);
            txtX.Name = "txtX";
            txtX.Size = new Size(150, 23);
            txtX.TabIndex = 3;

            lblY.AutoSize = true;
            lblY.Location = new Point(30, 100);
            lblY.Name = "lblY";
            lblY.Size = new Size(83, 15);
            lblY.TabIndex = 4;
            lblY.Text = "Результат y:";

            txtY.Location = new Point(140, 97);
            txtY.Name = "txtY";
            txtY.ReadOnly = true;
            txtY.Size = new Size(150, 23);
            txtY.TabIndex = 5;

            btnCalculate.Location = new Point(30, 140);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(120, 30);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;

            btnExit.Location = new Point(170, 140);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(120, 30);
            btnExit.TabIndex = 7;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;

            chkSelectFunction.AutoSize = true;
            chkSelectFunction.Location = new Point(30, 190);
            chkSelectFunction.Name = "chkSelectFunction";
            chkSelectFunction.Size = new Size(192, 19);
            chkSelectFunction.TabIndex = 8;
            chkSelectFunction.Text = "Выбрать конкретную функцию";
            chkSelectFunction.UseVisualStyleBackColor = true;
            chkSelectFunction.CheckedChanged += chkSelectFunction_CheckedChanged;

            grpFunctions.Controls.Add(rbFunction3);
            grpFunctions.Controls.Add(rbFunction2);
            grpFunctions.Controls.Add(rbFunction1);
            grpFunctions.Enabled = false;
            grpFunctions.Location = new Point(30, 220);
            grpFunctions.Name = "grpFunctions";
            grpFunctions.Size = new Size(400, 120);
            grpFunctions.TabIndex = 9;
            grpFunctions.TabStop = false;
            grpFunctions.Text = "Выбор функции";

            rbFunction1.AutoSize = true;
            rbFunction1.Checked = true;
            rbFunction1.Location = new Point(15, 25);
            rbFunction1.Name = "rbFunction1";
            rbFunction1.Size = new Size(225, 19);
            rbFunction1.TabIndex = 0;
            rbFunction1.TabStop = true;
            rbFunction1.Text = "f1(x) = x * sin(x - 1)  [при x <= 0]";
            rbFunction1.UseVisualStyleBackColor = true;

            rbFunction2.AutoSize = true;
            rbFunction2.Location = new Point(15, 55);
            rbFunction2.Name = "rbFunction2";
            rbFunction2.Size = new Size(290, 19);
            rbFunction2.TabIndex = 1;
            rbFunction2.Text = "f2(x) = (x - 1)³ + cos(x³)  [при 0 < x <= a]";
            rbFunction2.UseVisualStyleBackColor = true;

            rbFunction3.AutoSize = true;
            rbFunction3.Location = new Point(15, 85);
            rbFunction3.Name = "rbFunction3";
            rbFunction3.Size = new Size(280, 19);
            rbFunction3.TabIndex = 2;
            rbFunction3.Text = "f3(x) = √(|x|³) * sin(x³)  [при x > a]";
            rbFunction3.UseVisualStyleBackColor = true;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 360);
            Controls.Add(grpFunctions);
            Controls.Add(chkSelectFunction);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(txtY);
            Controls.Add(lblY);
            Controls.Add(txtX);
            Controls.Add(lblX);
            Controls.Add(txtA);
            Controls.Add(lblA);
            Name = "Form1";
            Text = "Вычисление функции";
            grpFunctions.ResumeLayout(false);
            grpFunctions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblA;
        private Label lblX;
        private Label lblY;
        private TextBox txtA;
        private TextBox txtX;
        private TextBox txtY;
        private Button btnCalculate;
        private Button btnExit;
        private CheckBox chkSelectFunction;
        private GroupBox grpFunctions;
        private RadioButton rbFunction1;
        private RadioButton rbFunction2;
        private RadioButton rbFunction3;
    }
}
