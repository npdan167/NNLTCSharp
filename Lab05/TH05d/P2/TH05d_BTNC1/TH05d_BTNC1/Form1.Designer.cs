namespace TH05d_BTNC1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMaLop = new Label();
            lblMaSV = new Label();
            lblHoTen = new Label();
            lblNgaySinh = new Label();
            txtMaLop = new TextBox();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            mxtxNgaySinh = new MaskedTextBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            SuspendLayout();
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(24, 32);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(61, 20);
            lblMaLop.TabIndex = 0;
            lblMaLop.Text = "Mã lớp";
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(24, 98);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(54, 20);
            lblMaSV.TabIndex = 1;
            lblMaSV.Text = "Mã sv";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(24, 160);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(58, 20);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(24, 220);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(81, 20);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(111, 24);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(296, 28);
            txtMaLop.TabIndex = 4;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(111, 90);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(296, 28);
            txtMaSV.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(111, 152);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(296, 28);
            txtHoTen.TabIndex = 6;
            // 
            // mxtxNgaySinh
            // 
            mxtxNgaySinh.Location = new Point(111, 217);
            mxtxNgaySinh.Mask = "00/00/0000";
            mxtxNgaySinh.Name = "mxtxNgaySinh";
            mxtxNgaySinh.Size = new Size(296, 28);
            mxtxNgaySinh.TabIndex = 7;
            mxtxNgaySinh.ValidatingType = typeof(DateTime);
            // 
            // btnSua
            // 
            btnSua.Location = new Point(282, 262);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(154, 262);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(24, 262);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 316);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(mxtxNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(txtMaLop);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblHoTen);
            Controls.Add(lblMaSV);
            Controls.Add(lblMaLop);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Quản lý sinh viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaLop;
        private Label lblMaSV;
        private Label lblHoTen;
        private Label lblNgaySinh;
        private TextBox txtMaLop;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private MaskedTextBox mxtxNgaySinh;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}
