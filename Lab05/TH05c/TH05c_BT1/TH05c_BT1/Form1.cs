namespace TH05c_BT1
{
    public partial class BT1 : Form
    {
        public BT1()
        {
            InitializeComponent();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra số nhập vào
            int n;
            if (!int.TryParse(txt_nhap.Text, out n) || n <= 0)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương");
                txt_nhap.Focus();
                return;
            }

            if (cbo_ThemSo.Items.Contains(n))
            {
                MessageBox.Show("Số này đã tồn tại");
                txt_nhap.Focus();
                return;
            }

            // Thêm số vừa nhập vào combobox, xóa dữ liệu trong textbox nhập số, đặt lại con trỏ
            cbo_ThemSo.Items.Add(n);
            txt_nhap.Clear();
            txt_nhap.Focus();
        }

        private void cbo_ThemSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst_UocSo.Items.Clear();

            if (cbo_ThemSo.SelectedItem == null)
                return;

            int n = Convert.ToInt32(cbo_ThemSo.SelectedItem);
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    lst_UocSo.Items.Add(i);
                }
            }
        }
        // Tính tổng các ước số
        private void btn_TinhTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (int uoc in lst_UocSo.Items)
            {
                tong += uoc;
            }
            MessageBox.Show("Tổng các ước số: " + tong);
        }
        //Tìm ước số chẵn
        private void btn_TinhUocChan_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (int uoc in lst_UocSo.Items)
            {
                if (uoc % 2 == 0)
                {
                    count++;
                }
            }
            MessageBox.Show("Số lượng các ước số chẵn: " + count);
        }
        //Tìm ước là số nguyên tố
        private void btn_TinhSNT_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (int uoc in lst_UocSo.Items)
            {
                bool SNT = true;

                if (uoc < 2)
                {
                    SNT = false;
                }
                else
                {
                    for (int i = 2; i < uoc; i++)
                    {
                        if (uoc % i == 0)
                        {
                            SNT = false;
                            break;
                        }
                    }
                }

                if (SNT)
                {
                    count++;
                }
            }

            MessageBox.Show("Số lượng các ước số nguyên tố: " + count);
        }
        // Thoát có xác nhận của người dùng
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show(
                "Xác nhận thoát?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
