using System;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace BTH4_BT5
{
    public partial class ThemSinhVien : Form
    {
        public ThemSinhVien()
        {
            InitializeComponent();
        }

        private void ThemSinhVien_Load(object sender, EventArgs e)
        {
            if (cbKhoa.Items.Count > 0) cbKhoa.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMSSV.Text) ||
                string.IsNullOrWhiteSpace(tbTenSV.Text) ||
                string.IsNullOrWhiteSpace(tbDTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mssv = tbMSSV.Text.Trim();
            if (mssv.Any(c => !char.IsLetterOrDigit(c)) || !mssv.Any(c => char.IsDigit(c)))
            {
                MessageBox.Show("MSSV không hợp lệ (không chứa ký tự đặc biệt và phải có số)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMSSV.Focus();
                return;
            }

            string ten = tbTenSV.Text.Trim();
            if (!ten.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Tên sinh viên chỉ được chứa chữ và khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTenSV.Focus();
                return;
            }

            float diem;
            if (!float.TryParse(tbDTB.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out diem) || diem < 0 || diem > 10)
            {
                MessageBox.Show("Điểm phải là số từ 0 đến 10 (Dùng dấu chấm) !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDTB.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}