namespace TH05c_Bai3
{
    partial class frmTreeView
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
            lbl_pb = new Label();
            lbl_hsnv = new Label();
            trv_DS = new TreeView();
            txt_phongban = new TextBox();
            lbl_pbduoi = new Label();
            btn_ThemPB = new Button();
            btn_XoaPB = new Button();
            lbl_ms = new Label();
            lbl_ht = new Label();
            lbl_dc = new Label();
            lbl_pbgiua = new Label();
            txt_diachi = new TextBox();
            txt_hoten = new TextBox();
            txt_maso = new TextBox();
            cbo_phongban = new ComboBox();
            btn_ThemNV = new Button();
            btn_Thoat = new Button();
            SuspendLayout();
            // 
            // lbl_pb
            // 
            lbl_pb.AutoSize = true;
            lbl_pb.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_pb.Location = new Point(12, 9);
            lbl_pb.Name = "lbl_pb";
            lbl_pb.Size = new Size(92, 20);
            lbl_pb.TabIndex = 0;
            lbl_pb.Text = "Phòng ban";
            // 
            // lbl_hsnv
            // 
            lbl_hsnv.AutoSize = true;
            lbl_hsnv.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_hsnv.ForeColor = Color.Blue;
            lbl_hsnv.Location = new Point(295, 9);
            lbl_hsnv.Name = "lbl_hsnv";
            lbl_hsnv.Size = new Size(288, 35);
            lbl_hsnv.TabIndex = 1;
            lbl_hsnv.Text = "HỒ SƠ NHÂN VIÊN";
            // 
            // trv_DS
            // 
            trv_DS.Location = new Point(12, 41);
            trv_DS.Name = "trv_DS";
            trv_DS.Size = new Size(249, 411);
            trv_DS.TabIndex = 2;
            // 
            // txt_phongban
            // 
            txt_phongban.Location = new Point(111, 458);
            txt_phongban.Name = "txt_phongban";
            txt_phongban.Size = new Size(150, 28);
            txt_phongban.TabIndex = 3;
            // 
            // lbl_pbduoi
            // 
            lbl_pbduoi.AutoSize = true;
            lbl_pbduoi.Location = new Point(12, 466);
            lbl_pbduoi.Name = "lbl_pbduoi";
            lbl_pbduoi.Size = new Size(86, 20);
            lbl_pbduoi.TabIndex = 4;
            lbl_pbduoi.Text = "Phòng ban";
            // 
            // btn_ThemPB
            // 
            btn_ThemPB.Location = new Point(111, 492);
            btn_ThemPB.Name = "btn_ThemPB";
            btn_ThemPB.Size = new Size(150, 39);
            btn_ThemPB.TabIndex = 5;
            btn_ThemPB.Text = "Thêm phòng ban";
            btn_ThemPB.UseVisualStyleBackColor = true;
            btn_ThemPB.Click += btn_ThemPB_Click;
            // 
            // btn_XoaPB
            // 
            btn_XoaPB.Location = new Point(111, 543);
            btn_XoaPB.Name = "btn_XoaPB";
            btn_XoaPB.Size = new Size(150, 39);
            btn_XoaPB.TabIndex = 6;
            btn_XoaPB.Text = "Xóa phòng ban";
            btn_XoaPB.UseVisualStyleBackColor = true;
            btn_XoaPB.Click += btn_XoaPB_Click;
            // 
            // lbl_ms
            // 
            lbl_ms.AutoSize = true;
            lbl_ms.Location = new Point(295, 71);
            lbl_ms.Name = "lbl_ms";
            lbl_ms.Size = new Size(54, 20);
            lbl_ms.TabIndex = 7;
            lbl_ms.Text = "Mã số";
            // 
            // lbl_ht
            // 
            lbl_ht.AutoSize = true;
            lbl_ht.Location = new Point(546, 71);
            lbl_ht.Name = "lbl_ht";
            lbl_ht.Size = new Size(58, 20);
            lbl_ht.TabIndex = 8;
            lbl_ht.Text = "Họ tên";
            // 
            // lbl_dc
            // 
            lbl_dc.AutoSize = true;
            lbl_dc.Location = new Point(295, 157);
            lbl_dc.Name = "lbl_dc";
            lbl_dc.Size = new Size(60, 20);
            lbl_dc.TabIndex = 9;
            lbl_dc.Text = "Địa chỉ";
            // 
            // lbl_pbgiua
            // 
            lbl_pbgiua.AutoSize = true;
            lbl_pbgiua.Location = new Point(295, 260);
            lbl_pbgiua.Name = "lbl_pbgiua";
            lbl_pbgiua.Size = new Size(86, 20);
            lbl_pbgiua.TabIndex = 10;
            lbl_pbgiua.Text = "Phòng ban";
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(387, 157);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(462, 28);
            txt_diachi.TabIndex = 11;
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(633, 71);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(216, 28);
            txt_hoten.TabIndex = 12;
            // 
            // txt_maso
            // 
            txt_maso.Location = new Point(387, 71);
            txt_maso.Name = "txt_maso";
            txt_maso.Size = new Size(125, 28);
            txt_maso.TabIndex = 13;
            // 
            // cbo_phongban
            // 
            cbo_phongban.FormattingEnabled = true;
            cbo_phongban.Location = new Point(387, 257);
            cbo_phongban.Name = "cbo_phongban";
            cbo_phongban.Size = new Size(462, 28);
            cbo_phongban.TabIndex = 14;
            // 
            // btn_ThemNV
            // 
            btn_ThemNV.Location = new Point(387, 344);
            btn_ThemNV.Name = "btn_ThemNV";
            btn_ThemNV.Size = new Size(94, 29);
            btn_ThemNV.TabIndex = 15;
            btn_ThemNV.Text = "Thêm";
            btn_ThemNV.UseVisualStyleBackColor = true;
            btn_ThemNV.Click += btn_ThemNV_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(536, 344);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(94, 29);
            btn_Thoat.TabIndex = 16;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // frmTreeView
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 594);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_ThemNV);
            Controls.Add(cbo_phongban);
            Controls.Add(txt_maso);
            Controls.Add(txt_hoten);
            Controls.Add(txt_diachi);
            Controls.Add(lbl_pbgiua);
            Controls.Add(lbl_dc);
            Controls.Add(lbl_ht);
            Controls.Add(lbl_ms);
            Controls.Add(btn_XoaPB);
            Controls.Add(btn_ThemPB);
            Controls.Add(lbl_pbduoi);
            Controls.Add(txt_phongban);
            Controls.Add(trv_DS);
            Controls.Add(lbl_hsnv);
            Controls.Add(lbl_pb);
            DoubleBuffered = true;
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmTreeView";
            Text = "Phòng ban - Nhân viên";
            FormClosing += frmTreeView_FormClosing;
            Load += frmTreeView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_pb;
        private Label lbl_hsnv;
        private TreeView trv_DS;
        private TextBox txt_phongban;
        private Label lbl_pbduoi;
        private Button btn_ThemPB;
        private Button btn_XoaPB;
        private Label lbl_ms;
        private Label lbl_ht;
        private Label lbl_dc;
        private Label lbl_pbgiua;
        private TextBox txt_diachi;
        private TextBox txt_hoten;
        private TextBox txt_maso;
        private ComboBox cbo_phongban;
        private Button btn_ThemNV;
        private Button btn_Thoat;
    }
}
