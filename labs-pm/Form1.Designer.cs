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
            btnRed = new Button();
            btnGreen = new Button();
            btnBlue = new Button();
            btnYellow = new Button();
            btnHello = new Button();
            btnGoodbye = new Button();
            lblMessage = new Label();
            grpTask2 = new GroupBox();
            lblResult1 = new Label();
            lblResult2 = new Label();
            btnCalculate = new Button();
            txtX = new TextBox();
            txtY = new TextBox();
            txtZ = new TextBox();
            lblX = new Label();
            lblY = new Label();
            lblZ = new Label();
            grpTask2.SuspendLayout();
            SuspendLayout();

            btnRed.Location = new Point(30, 30);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(100, 40);
            btnRed.TabIndex = 0;
            btnRed.Text = "красный";
            btnRed.UseVisualStyleBackColor = true;
            btnRed.Click += btnRed_Click;

            btnGreen.Location = new Point(150, 30);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(100, 40);
            btnGreen.TabIndex = 1;
            btnGreen.Text = "зеленый";
            btnGreen.UseVisualStyleBackColor = true;
            btnGreen.Click += btnGreen_Click;

            btnBlue.Location = new Point(270, 30);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(100, 40);
            btnBlue.TabIndex = 2;
            btnBlue.Text = "синий";
            btnBlue.UseVisualStyleBackColor = true;
            btnBlue.Click += btnBlue_Click;

            btnYellow.Location = new Point(390, 30);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(100, 40);
            btnYellow.TabIndex = 3;
            btnYellow.Text = "желтый";
            btnYellow.UseVisualStyleBackColor = true;
            btnYellow.Click += btnYellow_Click;

            btnHello.Location = new Point(30, 100);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(100, 40);
            btnHello.TabIndex = 4;
            btnHello.Text = "привет";
            btnHello.UseVisualStyleBackColor = true;
            btnHello.Click += btnHello_Click;

            btnGoodbye.Location = new Point(150, 100);
            btnGoodbye.Name = "btnGoodbye";
            btnGoodbye.Size = new Size(120, 40);
            btnGoodbye.TabIndex = 5;
            btnGoodbye.Text = "до свидания";
            btnGoodbye.UseVisualStyleBackColor = true;
            btnGoodbye.Click += btnGoodbye_Click;

            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMessage.Location = new Point(30, 160);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 21);
            lblMessage.TabIndex = 6;

            grpTask2.Controls.Add(lblZ);
            grpTask2.Controls.Add(lblY);
            grpTask2.Controls.Add(lblX);
            grpTask2.Controls.Add(txtZ);
            grpTask2.Controls.Add(txtY);
            grpTask2.Controls.Add(txtX);
            grpTask2.Controls.Add(btnCalculate);
            grpTask2.Controls.Add(lblResult2);
            grpTask2.Controls.Add(lblResult1);
            grpTask2.Location = new Point(30, 200);
            grpTask2.Name = "grpTask2";
            grpTask2.Size = new Size(740, 220);
            grpTask2.TabIndex = 7;
            grpTask2.TabStop = false;
            grpTask2.Text = "Задание 2: Вычисление функций";

            lblX.AutoSize = true;
            lblX.Location = new Point(20, 30);
            lblX.Name = "lblX";
            lblX.Size = new Size(17, 15);
            lblX.TabIndex = 0;
            lblX.Text = "X:";

            txtX.Location = new Point(50, 27);
            txtX.Name = "txtX";
            txtX.Size = new Size(100, 23);
            txtX.TabIndex = 1;

            lblY.AutoSize = true;
            lblY.Location = new Point(170, 30);
            lblY.Name = "lblY";
            lblY.Size = new Size(17, 15);
            lblY.TabIndex = 2;
            lblY.Text = "Y:";

            txtY.Location = new Point(200, 27);
            txtY.Name = "txtY";
            txtY.Size = new Size(100, 23);
            txtY.TabIndex = 3;

            lblZ.AutoSize = true;
            lblZ.Location = new Point(320, 30);
            lblZ.Name = "lblZ";
            lblZ.Size = new Size(17, 15);
            lblZ.TabIndex = 4;
            lblZ.Text = "Z:";

            txtZ.Location = new Point(350, 27);
            txtZ.Name = "txtZ";
            txtZ.Size = new Size(100, 23);
            txtZ.TabIndex = 5;

            btnCalculate.Location = new Point(470, 25);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(100, 30);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Вычислить";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;

            lblResult1.AutoSize = true;
            lblResult1.Font = new Font("Segoe UI", 10F);
            lblResult1.Location = new Point(20, 80);
            lblResult1.Name = "lblResult1";
            lblResult1.Size = new Size(0, 19);
            lblResult1.TabIndex = 7;

            lblResult2.AutoSize = true;
            lblResult2.Font = new Font("Segoe UI", 10F);
            lblResult2.Location = new Point(20, 120);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(0, 19);
            lblResult2.TabIndex = 8;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpTask2);
            Controls.Add(lblMessage);
            Controls.Add(btnGoodbye);
            Controls.Add(btnHello);
            Controls.Add(btnYellow);
            Controls.Add(btnBlue);
            Controls.Add(btnGreen);
            Controls.Add(btnRed);
            Name = "Form1";
            Text = "Лабораторная работа 17";
            Load += Form1_Load;
            grpTask2.ResumeLayout(false);
            grpTask2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRed;
        private Button btnGreen;
        private Button btnBlue;
        private Button btnYellow;
        private Button btnHello;
        private Button btnGoodbye;
        private Label lblMessage;
        private GroupBox grpTask2;
        private Label lblResult1;
        private Label lblResult2;
        private Button btnCalculate;
        private TextBox txtX;
        private TextBox txtY;
        private TextBox txtZ;
        private Label lblX;
        private Label lblY;
        private Label lblZ;
    }
}
