namespace pm_labs
{
    partial class AboutBox1
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

        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            logoPictureBox = new PictureBox();
            labelProductName = new Label();
            labelVersion = new Label();
            labelCopyright = new Label();
            labelCompanyName = new Label();
            textBoxDescription = new TextBox();
            okButton = new Button();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();

            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
            tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
            tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
            tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
            tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
            tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
            tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
            tableLayoutPanel.Controls.Add(okButton, 1, 5);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(9, 9);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 6;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel.Size = new Size(417, 265);
            tableLayoutPanel.TabIndex = 0;

            logoPictureBox.Dock = DockStyle.Fill;
            logoPictureBox.Location = new Point(3, 3);
            logoPictureBox.Name = "logoPictureBox";
            tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
            logoPictureBox.Size = new Size(131, 259);
            logoPictureBox.TabIndex = 12;
            logoPictureBox.TabStop = false;

            labelProductName.Dock = DockStyle.Fill;
            labelProductName.Location = new Point(143, 0);
            labelProductName.Margin = new Padding(6, 0, 3, 0);
            labelProductName.MaximumSize = new Size(0, 17);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(271, 17);
            labelProductName.TabIndex = 19;
            labelProductName.Text = "Text Editor";
            labelProductName.TextAlign = ContentAlignment.MiddleLeft;

            labelVersion.Dock = DockStyle.Fill;
            labelVersion.Location = new Point(143, 26);
            labelVersion.Margin = new Padding(6, 0, 3, 0);
            labelVersion.MaximumSize = new Size(0, 17);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(271, 17);
            labelVersion.TabIndex = 0;
            labelVersion.Text = "Version 1.0";
            labelVersion.TextAlign = ContentAlignment.MiddleLeft;

            labelCopyright.Dock = DockStyle.Fill;
            labelCopyright.Location = new Point(143, 52);
            labelCopyright.Margin = new Padding(6, 0, 3, 0);
            labelCopyright.MaximumSize = new Size(0, 17);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(271, 17);
            labelCopyright.TabIndex = 21;
            labelCopyright.Text = "Copyright 2024";
            labelCopyright.TextAlign = ContentAlignment.MiddleLeft;

            labelCompanyName.Dock = DockStyle.Fill;
            labelCompanyName.Location = new Point(143, 78);
            labelCompanyName.Margin = new Padding(6, 0, 3, 0);
            labelCompanyName.MaximumSize = new Size(0, 17);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(271, 17);
            labelCompanyName.TabIndex = 22;
            labelCompanyName.Text = "Company Name";
            labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;

            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(143, 107);
            textBoxDescription.Margin = new Padding(6, 3, 3, 3);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.ScrollBars = ScrollBars.Both;
            textBoxDescription.Size = new Size(271, 126);
            textBoxDescription.TabIndex = 23;
            textBoxDescription.TabStop = false;
            textBoxDescription.Text = "Simple text editor for editing RTF files";

            okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okButton.DialogResult = DialogResult.Cancel;
            okButton.Location = new Point(339, 239);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 24;
            okButton.Text = "&OK";
            okButton.Click += okButton_Click;

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 283);
            Controls.Add(tableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox1";
            Padding = new Padding(9);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About Text Editor";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel;
        private PictureBox logoPictureBox;
        private Label labelProductName;
        private Label labelVersion;
        private Label labelCopyright;
        private Label labelCompanyName;
        private TextBox textBoxDescription;
        private Button okButton;
    }
}
