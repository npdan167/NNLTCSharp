using System;
using System.Windows.Forms;

namespace lab5d4._1
{
    public partial class frmDongHo : Form
    {
        // Lưu thời gian còn lại: 30 phút = 1800 giây
        private int thoiGianConLai = 30 * 60;

        public frmDongHo()
        {
            InitializeComponent();

            // Thiết lập Timer chạy mỗi 1 giây
            timerDemNguoc.Interval = 1000;

            // Gắn sự kiện nút Bắt đầu
            btnBatDau.Click += btnBatDau_Click;

            // Gắn sự kiện đếm ngược
            timerDemNguoc.Tick += timerDemNguoc_Tick;

            // Gắn sự kiện khi Form mở
            this.Load += frmDongHo_Load;
        }

        // Khi Form được mở
        private void frmDongHo_Load(object sender, EventArgs e)
        {
            thoiGianConLai = 30 * 60;
            lblThoiGian.Text = "30:00";
            timerDemNguoc.Stop();
        }

        // Khi nhấn Bắt đầu
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            thoiGianConLai = 30 * 60;
            lblThoiGian.Text = "30:00";

            timerDemNguoc.Start();
            btnBatDau.Enabled = false;
        }

        // Mỗi giây giảm một đơn vị
        private void timerDemNguoc_Tick(object sender, EventArgs e)
        {
            thoiGianConLai--;

            // Đổi số giây thành phút và giây
            int phut = thoiGianConLai / 60;
            int giay = thoiGianConLai % 60;

            lblThoiGian.Text = $"{phut:00}:{giay:00}";

            // Khi hết thời gian
            if (thoiGianConLai <= 0)
            {
                timerDemNguoc.Stop();
                lblThoiGian.Text = "00:00";
                btnBatDau.Enabled = true;

                MessageBox.Show("Đã hết thời gian!");
            }
        }
    }
}