namespace TH05c_BTVN2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Nhập số
        private void btnNhap_Click(object sender, EventArgs e)
        {
            lstSo.Items.Add(txtNhapSo.Text);
            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }

        private void txtNhapSo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnNhap.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        // Tính tổng phần tử trong listbox
        private void btnTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (var so in lstSo.Items)
            {
                sum += int.Parse(so.ToString());
            }
            MessageBox.Show("Tổng các phần tử trong List: " + sum);
        }

        private void btnXoaDC_Click(object sender, EventArgs e)
        {
            // Xoa ptu cuoi
            if (lstSo.Items.Count > 0)
                lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
            //Xoa ptu dau
            if (lstSo.Items.Count > 0)
                lstSo.Items.RemoveAt(0);
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            // Chon nhieu -> dung for
            for (int i = lstSo.SelectedItems.Count - 1; i >= 0; i--)
            {
                lstSo.Items.Remove(lstSo.SelectedItems[i]);
            }
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            List<int> ds = new List<int>();

            foreach (var so in lstSo.Items)
                ds.Add(int.Parse(so.ToString()) + 2);
            // Xoa list cu
            lstSo.Items.Clear();
            // Add list + 2
            foreach (var so in ds)
                lstSo.Items.Add(so);
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            List<int> ds = new List<int>();

            foreach (var so in lstSo.Items)
                ds.Add(int.Parse(so.ToString()) * int.Parse(so.ToString()));

            lstSo.Items.Clear();
            // Add list binh phuong
            foreach (var so in ds)
                lstSo.Items.Add(so);
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            //DS chua so chan
            List<int> ds = new List<int>();

            foreach (var so in lstSo.Items)
            {
                //ktra so chan
                int i = int.Parse(so.ToString());
                if (i % 2 == 0)
                    //add cac so tim duoc vao list ds
                    ds.Add(i);
            }
            //show list ds
            MessageBox.Show("Các phần tử là số chẵn trong listbox: " + string.Join(", ", ds));
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            List<int> ds = new List<int>();

            foreach (var so in lstSo.Items)
            {
                int i = int.Parse(so.ToString());
                if (i % 2 != 0)
                    ds.Add(i);
            }
            MessageBox.Show("Các phần tử là số lẻ trong listbox: " + string.Join(", ", ds));
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
