using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH05d_BTNC1
{
    public partial class frmNhap : Form
    {

        public string HoTenNhap
        {
            get { return txtHoTen.Text.Trim(); }
        }

        public string LopDuocChon
        {
            get { return cboLop.Text; }
        }

        public frmNhap()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên học viên!");
                txtHoTen.Focus();
                return;
            }

            if (cboLop.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn lớp!");
                cboLop.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();

        }
    }
}
