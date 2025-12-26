using System.IO;

namespace pm_labs
{
    public partial class Form1 : Form
    {
        private string fileName;
        private const string defaultFileName = "untitled.rtf";

        public Form1()
        {
            InitializeComponent();
            fileName = defaultFileName;
            toolStripStatusLabel1.Text = fileName;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            fileName = defaultFileName;
            toolStripStatusLabel1.Text = fileName;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
                fileName = openFileDialog1.FileName;
                toolStripStatusLabel1.Text = fileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName.Equals(defaultFileName))
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                richTextBox1.SaveFile(fileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = fileName;
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                fileName = saveFileDialog1.FileName;
                toolStripStatusLabel1.Text = fileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text Editor Help\n\nFile Menu:\n- New: Create new file\n- Open: Open existing file\n- Save: Save current file\n- Save As: Save with new name\n- Exit: Close application\n\nEdit Menu:\n- Cut: Cut selected text\n- Copy: Copy selected text\n- Paste: Paste from clipboard", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }
    }
}
