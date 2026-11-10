namespace TH05c_BT3
{
    partial class frm_Chuoi
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
            lst_HoTen = new ListBox();
            btnNgauNhien = new Button();
            btn_Xoa = new Button();
            btn_XoaSon = new Button();
            btn_XoaLe = new Button();
            btn_ChuyenHOA = new Button();
            btn_ChuyenThuong = new Button();
            btn_ChuyenHDT = new Button();
            btn_XoaAll = new Button();
            SuspendLayout();
            // 
            // lst_HoTen
            // 
            lst_HoTen.FormattingEnabled = true;
            lst_HoTen.Location = new Point(100, 47);
            lst_HoTen.Margin = new Padding(4, 3, 4, 3);
            lst_HoTen.Name = "lst_HoTen";
            lst_HoTen.Size = new Size(200, 324);
            lst_HoTen.TabIndex = 0;
            lst_HoTen.DoubleClick += lst_HoTen_DoubleClick;
            // 
            // btnNgauNhien
            // 
            btnNgauNhien.Location = new Point(100, 12);
            btnNgauNhien.Name = "btnNgauNhien";
            btnNgauNhien.Size = new Size(200, 29);
            btnNgauNhien.TabIndex = 1;
            btnNgauNhien.Text = "Nhập tên ngẫu nhiên";
            btnNgauNhien.UseVisualStyleBackColor = true;
            btnNgauNhien.Click += btnNgauNhien_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(307, 58);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(323, 29);
            btn_Xoa.TabIndex = 2;
            btn_Xoa.Text = "Xóa phần tử đang chọn";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_XoaSon
            // 
            btn_XoaSon.Location = new Point(307, 93);
            btn_XoaSon.Name = "btn_XoaSon";
            btn_XoaSon.Size = new Size(323, 29);
            btn_XoaSon.TabIndex = 3;
            btn_XoaSon.Text = "Xóa phần tử có tên là Sơn";
            btn_XoaSon.UseVisualStyleBackColor = true;
            btn_XoaSon.Click += btn_XoaSon_Click;
            // 
            // btn_XoaLe
            // 
            btn_XoaLe.Location = new Point(307, 128);
            btn_XoaLe.Name = "btn_XoaLe";
            btn_XoaLe.Size = new Size(323, 29);
            btn_XoaLe.TabIndex = 4;
            btn_XoaLe.Text = "Xóa phần tử họ Lê";
            btn_XoaLe.UseVisualStyleBackColor = true;
            btn_XoaLe.Click += btn_XoaLe_Click;
            // 
            // btn_ChuyenHOA
            // 
            btn_ChuyenHOA.Location = new Point(307, 163);
            btn_ChuyenHOA.Name = "btn_ChuyenHOA";
            btn_ChuyenHOA.Size = new Size(323, 52);
            btn_ChuyenHOA.TabIndex = 5;
            btn_ChuyenHOA.Text = "Chuyển PT đang chọn thành chữ HOA";
            btn_ChuyenHOA.UseVisualStyleBackColor = true;
            btn_ChuyenHOA.Click += btn_ChuyenHOA_Click;
            // 
            // btn_ChuyenThuong
            // 
            btn_ChuyenThuong.Location = new Point(307, 221);
            btn_ChuyenThuong.Name = "btn_ChuyenThuong";
            btn_ChuyenThuong.Size = new Size(323, 29);
            btn_ChuyenThuong.TabIndex = 6;
            btn_ChuyenThuong.Text = "Chuyển PT đang chọn thành chữ thường";
            btn_ChuyenThuong.UseVisualStyleBackColor = true;
            btn_ChuyenThuong.Click += btn_ChuyenThuong_Click;
            // 
            // btn_ChuyenHDT
            // 
            btn_ChuyenHDT.Location = new Point(307, 256);
            btn_ChuyenHDT.Name = "btn_ChuyenHDT";
            btn_ChuyenHDT.Size = new Size(323, 50);
            btn_ChuyenHDT.TabIndex = 7;
            btn_ChuyenHDT.Text = "Chuyển PT đang chọn thành viết hoa đầu mỗi từ";
            btn_ChuyenHDT.UseVisualStyleBackColor = true;
            btn_ChuyenHDT.Click += btn_ChuyenHDT_Click;
            // 
            // btn_XoaAll
            // 
            btn_XoaAll.Location = new Point(307, 312);
            btn_XoaAll.Name = "btn_XoaAll";
            btn_XoaAll.Size = new Size(323, 29);
            btn_XoaAll.TabIndex = 8;
            btn_XoaAll.Text = "Xóa tất cả các phần tử";
            btn_XoaAll.UseVisualStyleBackColor = true;
            btn_XoaAll.Click += btn_XoaAll_Click;
            // 
            // frm_Chuoi
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 450);
            Controls.Add(btn_XoaAll);
            Controls.Add(btn_ChuyenHDT);
            Controls.Add(btn_ChuyenThuong);
            Controls.Add(btn_ChuyenHOA);
            Controls.Add(btn_XoaLe);
            Controls.Add(btn_XoaSon);
            Controls.Add(btn_Xoa);
            Controls.Add(btnNgauNhien);
            Controls.Add(lst_HoTen);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_Chuoi";
            Text = "frmChuoi";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst_HoTen;
        private Button btnNgauNhien;
        private Button btn_Xoa;
        private Button btn_XoaSon;
        private Button btn_XoaLe;
        private Button btn_ChuyenHOA;
        private Button btn_ChuyenThuong;
        private Button btn_ChuyenHDT;
        private Button btn_XoaAll;
    }
}
