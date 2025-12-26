namespace pm_labs
{
    partial class Form2
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
            lblTitle = new Label();
            btnChooseColor = new Button();
            btnOK = new Button();
            btnCancel = new Button();
            panelPreview = new Panel();
            colorDialog1 = new ColorDialog();
            SuspendLayout();

            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(100, 19);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Выберите цвет:";

            btnChooseColor.Location = new Point(20, 50);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(150, 30);
            btnChooseColor.TabIndex = 1;
            btnChooseColor.Text = "Выбрать цвет...";
            btnChooseColor.UseVisualStyleBackColor = true;
            btnChooseColor.Click += btnChooseColor_Click;

            panelPreview.BorderStyle = BorderStyle.FixedSingle;
            panelPreview.Location = new Point(190, 50);
            panelPreview.Name = "panelPreview";
            panelPreview.Size = new Size(100, 30);
            panelPreview.TabIndex = 2;

            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(90, 110);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(90, 30);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;

            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(200, 110);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 30);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 161);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(panelPreview);
            Controls.Add(btnChooseColor);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Настройки цвета";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnChooseColor;
        private Button btnOK;
        private Button btnCancel;
        private Panel panelPreview;
        private ColorDialog colorDialog1;
    }
}
