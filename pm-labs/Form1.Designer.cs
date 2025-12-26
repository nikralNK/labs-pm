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
            lblRows = new Label();
            lblCols = new Label();
            txtRows = new TextBox();
            txtCols = new TextBox();
            btnCreate = new Button();
            dataGridView1 = new DataGridView();
            grpTasks = new GroupBox();
            lblC = new Label();
            txtC = new TextBox();
            btnTaskA = new Button();
            btnTaskB = new Button();
            btnTaskC = new Button();
            lblResult = new Label();
            txtResult = new TextBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpTasks.SuspendLayout();
            SuspendLayout();

            lblRows.AutoSize = true;
            lblRows.Location = new Point(20, 20);
            lblRows.Name = "lblRows";
            lblRows.Size = new Size(120, 15);
            lblRows.TabIndex = 0;
            lblRows.Text = "Количество строк:";

            txtRows.Location = new Point(150, 17);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(80, 23);
            txtRows.TabIndex = 1;

            lblCols.AutoSize = true;
            lblCols.Location = new Point(250, 20);
            lblCols.Name = "lblCols";
            lblCols.Size = new Size(140, 15);
            lblCols.TabIndex = 2;
            lblCols.Text = "Количество столбцов:";

            txtCols.Location = new Point(400, 17);
            txtCols.Name = "txtCols";
            txtCols.Size = new Size(80, 23);
            txtCols.TabIndex = 3;

            btnCreate.Location = new Point(500, 15);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(130, 27);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Создать матрицу";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(400, 350);
            dataGridView1.TabIndex = 5;

            grpTasks.Controls.Add(btnClear);
            grpTasks.Controls.Add(txtResult);
            grpTasks.Controls.Add(lblResult);
            grpTasks.Controls.Add(btnTaskC);
            grpTasks.Controls.Add(btnTaskB);
            grpTasks.Controls.Add(btnTaskA);
            grpTasks.Controls.Add(txtC);
            grpTasks.Controls.Add(lblC);
            grpTasks.Location = new Point(440, 60);
            grpTasks.Name = "grpTasks";
            grpTasks.Size = new Size(340, 350);
            grpTasks.TabIndex = 6;
            grpTasks.TabStop = false;
            grpTasks.Text = "Задания";

            lblC.AutoSize = true;
            lblC.Location = new Point(15, 30);
            lblC.Name = "lblC";
            lblC.Size = new Size(60, 15);
            lblC.TabIndex = 0;
            lblC.Text = "Число C:";

            txtC.Location = new Point(85, 27);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 23);
            txtC.TabIndex = 1;

            btnTaskA.Enabled = false;
            btnTaskA.Location = new Point(15, 70);
            btnTaskA.Name = "btnTaskA";
            btnTaskA.Size = new Size(310, 35);
            btnTaskA.TabIndex = 2;
            btnTaskA.Text = "А) Количество элементов > C";
            btnTaskA.UseVisualStyleBackColor = true;
            btnTaskA.Click += btnTaskA_Click;

            btnTaskB.Enabled = false;
            btnTaskB.Location = new Point(15, 115);
            btnTaskB.Name = "btnTaskB";
            btnTaskB.Size = new Size(310, 35);
            btnTaskB.TabIndex = 3;
            btnTaskB.Text = "Б) Сумма элементов по периметру";
            btnTaskB.UseVisualStyleBackColor = true;
            btnTaskB.Click += btnTaskB_Click;

            btnTaskC.Enabled = false;
            btnTaskC.Location = new Point(15, 160);
            btnTaskC.Name = "btnTaskC";
            btnTaskC.Size = new Size(310, 50);
            btnTaskC.TabIndex = 4;
            btnTaskC.Text = "В) Сумма произведений (только для 4x4)";
            btnTaskC.UseVisualStyleBackColor = true;
            btnTaskC.Click += btnTaskC_Click;

            lblResult.AutoSize = true;
            lblResult.Location = new Point(15, 230);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(70, 15);
            lblResult.TabIndex = 5;
            lblResult.Text = "Результат:";

            txtResult.Location = new Point(15, 250);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.ScrollBars = ScrollBars.Vertical;
            txtResult.Size = new Size(310, 60);
            txtResult.TabIndex = 6;

            btnClear.Location = new Point(15, 315);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(310, 25);
            btnClear.TabIndex = 7;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 430);
            Controls.Add(grpTasks);
            Controls.Add(dataGridView1);
            Controls.Add(btnCreate);
            Controls.Add(txtCols);
            Controls.Add(lblCols);
            Controls.Add(txtRows);
            Controls.Add(lblRows);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выполнил студент группы ИСПП-242 Кузнецова В.Б.";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpTasks.ResumeLayout(false);
            grpTasks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRows;
        private Label lblCols;
        private TextBox txtRows;
        private TextBox txtCols;
        private Button btnCreate;
        private DataGridView dataGridView1;
        private GroupBox grpTasks;
        private Label lblC;
        private TextBox txtC;
        private Button btnTaskA;
        private Button btnTaskB;
        private Button btnTaskC;
        private Label lblResult;
        private TextBox txtResult;
        private Button btnClear;
    }
}
