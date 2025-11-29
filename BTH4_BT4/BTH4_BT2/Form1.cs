using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq; 

namespace BTH4_BT2
{
    public partial class Form1 : Form
    {
        private string currentFilePath = null;
        private bool isUpdatingUI = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fontCollection = new InstalledFontCollection();
            foreach (FontFamily fontFamily in fontCollection.Families)
            {
                toolStripFont.Items.Add(fontFamily.Name);
            }
            object[] fontSizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            toolStripSize.Items.AddRange(fontSizes);

            rtbMainTextBox.Font = new Font("Tahoma", 14, FontStyle.Regular);
            toolStripFont.SelectedItem = "Tahoma";
            toolStripSize.SelectedItem = 14;

            openFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf";
            saveFileDialog1.DefaultExt = ".rtf";
        }

        private void toolStripBtnNewFile_Click(object sender, EventArgs e)
        {
            rtbMainTextBox.Clear();
            rtbMainTextBox.Font = new Font("Tahoma", 14, FontStyle.Regular);
            toolStripFont.SelectedItem = "Tahoma";
            toolStripSize.SelectedItem = 14;
            currentFilePath = null;
        }

        private void toolStripMenuOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = openFileDialog1.FileName;
                string fileExtension = Path.GetExtension(currentFilePath).ToLower();
                try
                {
                    if (fileExtension == ".rtf")
                        rtbMainTextBox.LoadFile(currentFilePath, RichTextBoxStreamType.RichText);
                    else
                        rtbMainTextBox.LoadFile(currentFilePath, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải file: " + ex.Message);
                }
            }
        }

        private void toolStripBtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string savePath = currentFilePath;

                if (string.IsNullOrEmpty(savePath))
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                        savePath = saveFileDialog1.FileName;
                    else
                        return;
                }

                string ext = Path.GetExtension(savePath).ToLower();
                if (ext == ".txt")
                    rtbMainTextBox.SaveFile(savePath, RichTextBoxStreamType.PlainText);
                else
                    rtbMainTextBox.SaveFile(savePath, RichTextBoxStreamType.RichText);

                currentFilePath = savePath;
                MessageBox.Show("Lưu văn bản thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.Font = (rtbMainTextBox.SelectionFont != null) ? rtbMainTextBox.SelectionFont : rtbMainTextBox.Font;

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rtbMainTextBox.SelectionFont = fontDialog.Font;
            }
        }
        private void ToggleFontStyle(FontStyle style)
        {
            Font currentFont = (rtbMainTextBox.SelectionFont != null) ? rtbMainTextBox.SelectionFont : rtbMainTextBox.Font;
            FontStyle newStyle = currentFont.Style ^ style;
            Font newFont = new Font(currentFont.FontFamily, currentFont.Size, newStyle);

            rtbMainTextBox.SelectionFont = newFont;
            rtbMainTextBox.Focus();
        }
        private void toolStripBtnBold_Click(object sender, EventArgs e) { ToggleFontStyle(FontStyle.Bold); }
        private void toolStripBtnItalic_Click(object sender, EventArgs e) { ToggleFontStyle(FontStyle.Italic); }
        private void toolStripBtnUnderlined_Click(object sender, EventArgs e) { ToggleFontStyle(FontStyle.Underline); }

        private void rtbMainTextBox_SelectionChanged(object sender, EventArgs e)
        {
            isUpdatingUI = true;
            try
            {
                Font currentFont = rtbMainTextBox.SelectionFont;
                if (currentFont == null) currentFont = rtbMainTextBox.Font;
                if (toolStripFont.Items.Contains(currentFont.Name))
                    toolStripFont.SelectedItem = currentFont.Name;
                else
                    toolStripFont.Text = currentFont.Name;

                toolStripSize.Text = currentFont.Size.ToString();
            }
            catch { }
            isUpdatingUI = false;
        }

        private void toolStripFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdatingUI) return;
            string newFontName = toolStripFont.Text;
            if (!IsFontInstalled(newFontName))
            {
                return;
            }

            ApplyFont(newFontName, -1);
        }
        private void toolStripSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdatingUI) return;

            float newSize;
            if (float.TryParse(toolStripSize.Text, out newSize))
            {
                ApplyFont(null, newSize); 
            }
        }

        private void toolStripSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !isUpdatingUI)
            {
                toolStripSize_SelectedIndexChanged(sender, e);
                e.SuppressKeyPress = true;
                rtbMainTextBox.Focus();
            }
        }
        private void toolStripFont_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !isUpdatingUI)
            {
                toolStripFont_SelectedIndexChanged(sender, e);
                e.SuppressKeyPress = true;
                rtbMainTextBox.Focus();
            }
        }
        private void ApplyFont(string fontName, float fontSize)
        {
            try
            {
                Font currentFont = rtbMainTextBox.SelectionFont;
                if (currentFont == null) currentFont = rtbMainTextBox.Font;
                string name = (fontName == null) ? currentFont.Name : fontName;
                float size = (fontSize <= 0) ? currentFont.Size : fontSize;
                FontStyle style = currentFont.Style;
                Font newFont = new Font(name, size, style);
                rtbMainTextBox.SelectionFont = newFont;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi áp dụng font");
            }
        }

        private bool IsFontInstalled(string fontName)
        {
            using (InstalledFontCollection fonts = new InstalledFontCollection())
            {
                foreach (FontFamily family in fonts.Families)
                {
                    if (family.Name.Equals(fontName, StringComparison.OrdinalIgnoreCase))
                        return true;
                }
            }
            return false;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}