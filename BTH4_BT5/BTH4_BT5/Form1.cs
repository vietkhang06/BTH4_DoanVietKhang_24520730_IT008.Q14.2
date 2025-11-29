using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_BT5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void imgThem_Click(object sender, EventArgs e)
        {
            ThemSinhVien f = new ThemSinhVien();
            if (f.ShowDialog() == DialogResult.OK)
            {

                string masv = f.Controls["tbMSSV"].Text;     
                string hoten = f.Controls["tbTenSV"].Text;
                string khoa = f.Controls["cbKhoa"].Text;
                string diem = f.Controls["tbDTB"].Text;
                int stt = dgDsSinhVien.Rows.Count; 
                dgDsSinhVien.Rows.Add(stt, masv, hoten, khoa, diem);
            }
        }
        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemSinhVien f = new ThemSinhVien();
            if (f.ShowDialog() == DialogResult.OK)
            {

                string masv = f.Controls["tbMSSV"].Text;
                string hoten = f.Controls["tbTenSV"].Text;
                string khoa = f.Controls["cbKhoa"].Text;
                string diem = f.Controls["tbDTB"].Text;
                int stt = dgDsSinhVien.Rows.Count;
                dgDsSinhVien.Rows.Add(stt, masv, hoten, khoa, diem);
            }
        }
        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = tbTimKiem.Text.ToLower().Trim();
            foreach (DataGridViewRow row in dgDsSinhVien.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cellValue = row.Cells[2].Value;
                    if (cellValue != null)
                    {
                        string tenSV = cellValue.ToString().ToLower();
                        if (tenSV.Contains(keyword))
                        {
                            row.Visible = true;
                        }
                        else
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
