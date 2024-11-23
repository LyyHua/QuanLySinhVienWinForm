using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class AddStudentForm : Form
    {
        public Student Student { get; private set; }
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtMaSo.Text) ||
                string.IsNullOrWhiteSpace(txtTen.Text) ||
                cmbKhoa.SelectedItem == null ||
                !double.TryParse(txtDiemTB.Text, out double diemTB))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ và đúng định dạng thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new Student object
            Student = new Student
            {
                MaSo = txtMaSo.Text.Trim(),
                Ten = txtTen.Text.Trim(),
                Khoa = cmbKhoa.SelectedItem.ToString(),
                DiemTB = diemTB
            };

            // Set dialog result and close the form
            DialogResult = DialogResult.OK;
            Close();
        }
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMaSo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiemTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
