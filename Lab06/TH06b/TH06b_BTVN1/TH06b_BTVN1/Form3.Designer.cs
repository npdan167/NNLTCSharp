namespace TH06b_BTVN1
{
    partial class frmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTao = new Button();
            btnThem = new Button();
            btnHuy = new Button();
            btnThanhToan = new Button();
            grbCTHD = new GroupBox();
            txtSoLuong = new TextBox();
            txtMaHD = new TextBox();
            cboMaSP = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grbCTHD.SuspendLayout();
            SuspendLayout();
            // 
            // btnTao
            // 
            btnTao.Location = new Point(409, 38);
            btnTao.Name = "btnTao";
            btnTao.Size = new Size(194, 29);
            btnTao.TabIndex = 0;
            btnTao.Text = "Tạo hóa đơn mới";
            btnTao.UseVisualStyleBackColor = true;
            btnTao.Click += btnTao_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(214, 247);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(362, 247);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThanhToan
            // 
            btnThanhToan.Location = new Point(378, 426);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(154, 29);
            btnThanhToan.TabIndex = 3;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // grbCTHD
            // 
            grbCTHD.Controls.Add(txtSoLuong);
            grbCTHD.Controls.Add(txtMaHD);
            grbCTHD.Controls.Add(btnThem);
            grbCTHD.Controls.Add(btnHuy);
            grbCTHD.Controls.Add(cboMaSP);
            grbCTHD.Controls.Add(label3);
            grbCTHD.Controls.Add(label2);
            grbCTHD.Controls.Add(label1);
            grbCTHD.Location = new Point(76, 90);
            grbCTHD.Name = "grbCTHD";
            grbCTHD.Size = new Size(487, 301);
            grbCTHD.TabIndex = 4;
            grbCTHD.TabStop = false;
            grbCTHD.Text = "Chi tiết hóa đơn";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(150, 182);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(189, 28);
            txtSoLuong.TabIndex = 5;
            // 
            // txtMaHD
            // 
            txtMaHD.Location = new Point(150, 48);
            txtMaHD.Name = "txtMaHD";
            txtMaHD.Size = new Size(189, 28);
            txtMaHD.TabIndex = 4;
            // 
            // cboMaSP
            // 
            cboMaSP.FormattingEnabled = true;
            cboMaSP.Location = new Point(150, 119);
            cboMaSP.Name = "cboMaSP";
            cboMaSP.Size = new Size(189, 28);
            cboMaSP.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 190);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 2;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 127);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 56);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn";
            // 
            // frmBanHang
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 474);
            Controls.Add(grbCTHD);
            Controls.Add(btnThanhToan);
            Controls.Add(btnTao);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmBanHang";
            Text = "Bán hàng";
            Load += frmBanHang_Load;
            grbCTHD.ResumeLayout(false);
            grbCTHD.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnTao;
        private Button btnThem;
        private Button btnHuy;
        private Button btnThanhToan;
        private GroupBox grbCTHD;
        private TextBox txtSoLuong;
        private TextBox txtMaHD;
        private ComboBox cboMaSP;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}