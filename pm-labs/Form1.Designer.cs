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
            lblRows = new Label();
            lblCols = new Label();
            txtRows = new TextBox();
            txtCols = new TextBox();
            btnCreateMatrix = new Button();
            grpFillMethod = new GroupBox();
            rbManual = new RadioButton();
            rbAuto = new RadioButton();
            dgvMatrix = new DataGridView();
            grpSelection = new GroupBox();
            rbByColumns = new RadioButton();
            rbByRows = new RadioButton();
            btnProcess = new Button();
            lblResult = new Label();
            lstResult = new ListBox();
            grpFillMethod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).BeginInit();
            grpSelection.SuspendLayout();
            SuspendLayout();

            lblRows.AutoSize = true;
            lblRows.Font = new Font("Segoe UI", 10F);
            lblRows.Location = new Point(20, 20);
            lblRows.Name = "lblRows";
            lblRows.Size = new Size(120, 19);
            lblRows.TabIndex = 0;
            lblRows.Text = "Количество строк:";

            txtRows.Font = new Font("Segoe UI", 10F);
            txtRows.Location = new Point(150, 17);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(80, 25);
            txtRows.TabIndex = 1;

            lblCols.AutoSize = true;
            lblCols.Font = new Font("Segoe UI", 10F);
            lblCols.Location = new Point(250, 20);
            lblCols.Name = "lblCols";
            lblCols.Size = new Size(145, 19);
            lblCols.TabIndex = 2;
            lblCols.Text = "Количество столбцов:";

            txtCols.Font = new Font("Segoe UI", 10F);
            txtCols.Location = new Point(405, 17);
            txtCols.Name = "txtCols";
            txtCols.Size = new Size(80, 25);
            txtCols.TabIndex = 3;

            grpFillMethod.Controls.Add(rbManual);
            grpFillMethod.Controls.Add(rbAuto);
            grpFillMethod.Font = new Font("Segoe UI", 10F);
            grpFillMethod.Location = new Point(20, 60);
            grpFillMethod.Name = "grpFillMethod";
            grpFillMethod.Size = new Size(280, 80);
            grpFillMethod.TabIndex = 4;
            grpFillMethod.TabStop = false;
            grpFillMethod.Text = "Способ заполнения";

            rbAuto.AutoSize = true;
            rbAuto.Checked = true;
            rbAuto.Location = new Point(20, 25);
            rbAuto.Name = "rbAuto";
            rbAuto.Size = new Size(173, 23);
            rbAuto.TabIndex = 0;
            rbAuto.TabStop = true;
            rbAuto.Text = "Автоматически (случайно)";

            rbManual.AutoSize = true;
            rbManual.Location = new Point(20, 50);
            rbManual.Name = "rbManual";
            rbManual.Size = new Size(80, 23);
            rbManual.TabIndex = 1;
            rbManual.Text = "Вручную";

            btnCreateMatrix.Font = new Font("Segoe UI", 10F);
            btnCreateMatrix.Location = new Point(320, 80);
            btnCreateMatrix.Name = "btnCreateMatrix";
            btnCreateMatrix.Size = new Size(165, 40);
            btnCreateMatrix.TabIndex = 5;
            btnCreateMatrix.Text = "Создать матрицу";
            btnCreateMatrix.UseVisualStyleBackColor = true;
            btnCreateMatrix.Click += btnCreateMatrix_Click;

            dgvMatrix.AllowUserToAddRows = false;
            dgvMatrix.AllowUserToDeleteRows = false;
            dgvMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatrix.Location = new Point(20, 160);
            dgvMatrix.Name = "dgvMatrix";
            dgvMatrix.Size = new Size(650, 250);
            dgvMatrix.TabIndex = 6;
            dgvMatrix.CellValueChanged += dgvMatrix_CellValueChanged;

            grpSelection.Controls.Add(rbByColumns);
            grpSelection.Controls.Add(rbByRows);
            grpSelection.Font = new Font("Segoe UI", 10F);
            grpSelection.Location = new Point(690, 160);
            grpSelection.Name = "grpSelection";
            grpSelection.Size = new Size(200, 100);
            grpSelection.TabIndex = 7;
            grpSelection.TabStop = false;
            grpSelection.Text = "Селекция массива";

            rbByRows.AutoSize = true;
            rbByRows.Checked = true;
            rbByRows.Location = new Point(20, 30);
            rbByRows.Name = "rbByRows";
            rbByRows.Size = new Size(110, 23);
            rbByRows.TabIndex = 0;
            rbByRows.TabStop = true;
            rbByRows.Text = "По строкам";

            rbByColumns.AutoSize = true;
            rbByColumns.Location = new Point(20, 60);
            rbByColumns.Name = "rbByColumns";
            rbByColumns.Size = new Size(125, 23);
            rbByColumns.TabIndex = 1;
            rbByColumns.Text = "По столбцам";

            btnProcess.Font = new Font("Segoe UI", 10F);
            btnProcess.Location = new Point(690, 280);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(200, 40);
            btnProcess.TabIndex = 8;
            btnProcess.Text = "Обработать";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;

            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10F);
            lblResult.Location = new Point(20, 430);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(250, 19);
            lblResult.TabIndex = 9;
            lblResult.Text = "Результат (отсортировано методом пузырька):";

            lstResult.Font = new Font("Segoe UI", 10F);
            lstResult.FormattingEnabled = true;
            lstResult.ItemHeight = 17;
            lstResult.Location = new Point(20, 460);
            lstResult.Name = "lstResult";
            lstResult.Size = new Size(870, 106);
            lstResult.TabIndex = 10;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 591);
            Controls.Add(lstResult);
            Controls.Add(lblResult);
            Controls.Add(btnProcess);
            Controls.Add(grpSelection);
            Controls.Add(dgvMatrix);
            Controls.Add(btnCreateMatrix);
            Controls.Add(grpFillMethod);
            Controls.Add(txtCols);
            Controls.Add(lblCols);
            Controls.Add(txtRows);
            Controls.Add(lblRows);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выполнил студент группы ИСПП-242 Кузнецова В.Б.";
            grpFillMethod.ResumeLayout(false);
            grpFillMethod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatrix).EndInit();
            grpSelection.ResumeLayout(false);
            grpSelection.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRows;
        private Label lblCols;
        private TextBox txtRows;
        private TextBox txtCols;
        private Button btnCreateMatrix;
        private GroupBox grpFillMethod;
        private RadioButton rbAuto;
        private RadioButton rbManual;
        private DataGridView dgvMatrix;
        private GroupBox grpSelection;
        private RadioButton rbByRows;
        private RadioButton rbByColumns;
        private Button btnProcess;
        private Label lblResult;
        private ListBox lstResult;
    }
}
