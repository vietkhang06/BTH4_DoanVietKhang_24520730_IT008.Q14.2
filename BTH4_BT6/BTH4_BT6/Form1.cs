using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BTH4_BT6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bgWorker.WorkerReportsProgress = true;
        }

        private void btnChonNguon_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbSource.Text = fbd.SelectedPath;
            }
        }

        private void btnChonDich_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                tbDest.Text = fbd.SelectedPath;
            }
        }

        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSource.Text) || string.IsNullOrEmpty(tbDest.Text))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ đường dẫn nguồn và đích!");
                return;
            }

            progressBar1.Value = 0;

            string[] args = { tbSource.Text, tbDest.Text };
            if (!bgWorker.IsBusy)
            {
                bgWorker.RunWorkerAsync(args);
            }
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] args = (string[])e.Argument;
            string sourceDir = args[0];
            string destDir = args[1];

            string[] allFiles = Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories);

            int totalFiles = allFiles.Length;
            int count = 0;

            foreach (string filePath in allFiles)
            {
                string relativePath = filePath.Substring(sourceDir.Length + 1);
                string destFilePath = Path.Combine(destDir, relativePath);

                Directory.CreateDirectory(Path.GetDirectoryName(destFilePath));

                File.Copy(filePath, destFilePath, true);

                count++;
                int percentage = (int)((double)count / totalFiles * 100);

                bgWorker.ReportProgress(percentage, filePath);

                System.Threading.Thread.Sleep(50);
            }
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            string currentFile = e.UserState.ToString();
            progressBar1.Text = "Đang sao chép: " + currentFile;
            toolTip1.Show(currentFile, progressBar1, 0, -20, 1000);
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Sao chép dữ liệu thành công!", "Thông báo");
            progressBar1.Text = "Hoàn tất.";
        }
    }
}
