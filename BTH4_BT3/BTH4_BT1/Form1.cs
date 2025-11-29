using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Title = "Open Media File";
            openFileDialog1.Filter = "Media Files (*.avi; *.mpeg; *.wav; *.midi; *.mp4; *.mp3)|*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3|All Files (*.*)|*.*";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                axWindowsMediaPlayer1.URL = filePath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string date = now.ToString("dd/MM/yyyy");
            string time = now.ToString("hh:mm:ss tt"); 
            lblStatus.Text = $"Hôm nay là: {date} - Bây giờ là: {time}";
        }
    }
}
