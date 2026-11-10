namespace TH05c_BT2
{
    partial class frm_QLSV
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
            trv_DSLop = new TreeView();
            lbl_ChonLop = new Label();
            lbl_TTSV = new Label();
            lbl_MSV = new Label();
            lbl_HoTen = new Label();
            lbl_DiaChi = new Label();
            grp_ThemLop = new GroupBox();
            lbl_TenLop = new Label();
            txt_TTL = new TextBox();
            btn_ThemLop = new Button();
            cb_ThemLop = new CheckBox();
            btn_CapNhat = new Button();
            btn_Xoa = new Button();
            txt_MSV = new TextBox();
            txt_HoTen = new TextBox();
            txt_DiaChi = new TextBox();
            cbo_ChonLop = new ComboBox();
            grp_ThemLop.SuspendLayout();
            SuspendLayout();
            // 
            // trv_DSLop
            // 
            trv_DSLop.Location = new Point(0, 0);
            trv_DSLop.Margin = new Padding(4, 3, 4, 3);
            trv_DSLop.Name = "trv_DSLop";
            trv_DSLop.Size = new Size(395, 470);
            trv_DSLop.TabIndex = 0;
            trv_DSLop.AfterSelect += treeView1_AfterSelect;
            trv_DSLop.NodeMouseClick += trv_DSLop_NodeMouseClick;
            // 
            // lbl_ChonLop
            // 
            lbl_ChonLop.AutoSize = true;
            lbl_ChonLop.Location = new Point(435, 25);
            lbl_ChonLop.Name = "lbl_ChonLop";
            lbl_ChonLop.Size = new Size(76, 20);
            lbl_ChonLop.TabIndex = 1;
            lbl_ChonLop.Text = "Chọn lớp";
            // 
            // lbl_TTSV
            // 
            lbl_TTSV.AutoSize = true;
            lbl_TTSV.Location = new Point(435, 80);
            lbl_TTSV.Name = "lbl_TTSV";
            lbl_TTSV.Size = new Size(148, 20);
            lbl_TTSV.TabIndex = 2;
            lbl_TTSV.Text = "Thông tin sinh viên";
            // 
            // lbl_MSV
            // 
            lbl_MSV.AutoSize = true;
            lbl_MSV.Location = new Point(451, 120);
            lbl_MSV.Name = "lbl_MSV";
            lbl_MSV.Size = new Size(102, 20);
            lbl_MSV.TabIndex = 3;
            lbl_MSV.Text = "Mã sinh viên";
            // 
            // lbl_HoTen
            // 
            lbl_HoTen.AutoSize = true;
            lbl_HoTen.Location = new Point(451, 165);
            lbl_HoTen.Name = "lbl_HoTen";
            lbl_HoTen.Size = new Size(58, 20);
            lbl_HoTen.TabIndex = 4;
            lbl_HoTen.Text = "Họ tên";
            // 
            // lbl_DiaChi
            // 
            lbl_DiaChi.AutoSize = true;
            lbl_DiaChi.Location = new Point(451, 214);
            lbl_DiaChi.Name = "lbl_DiaChi";
            lbl_DiaChi.Size = new Size(60, 20);
            lbl_DiaChi.TabIndex = 5;
            lbl_DiaChi.Text = "Địa chỉ";
            // 
            // grp_ThemLop
            // 
            grp_ThemLop.Controls.Add(lbl_TenLop);
            grp_ThemLop.Controls.Add(txt_TTL);
            grp_ThemLop.Controls.Add(btn_ThemLop);
            grp_ThemLop.Location = new Point(451, 383);
            grp_ThemLop.Name = "grp_ThemLop";
            grp_ThemLop.Size = new Size(522, 77);
            grp_ThemLop.TabIndex = 6;
            grp_ThemLop.TabStop = false;
            grp_ThemLop.Text = "Thông tin lớp";
            // 
            // lbl_TenLop
            // 
            lbl_TenLop.AutoSize = true;
            lbl_TenLop.Location = new Point(37, 36);
            lbl_TenLop.Name = "lbl_TenLop";
            lbl_TenLop.Size = new Size(66, 20);
            lbl_TenLop.TabIndex = 13;
            lbl_TenLop.Text = "Tên lớp";
            // 
            // txt_TTL
            // 
            txt_TTL.Location = new Point(126, 33);
            txt_TTL.Name = "txt_TTL";
            txt_TTL.Size = new Size(260, 28);
            txt_TTL.TabIndex = 13;
            // 
            // btn_ThemLop
            // 
            btn_ThemLop.Location = new Point(405, 33);
            btn_ThemLop.Name = "btn_ThemLop";
            btn_ThemLop.Size = new Size(94, 29);
            btn_ThemLop.TabIndex = 9;
            btn_ThemLop.Text = "Thêm lớp";
            btn_ThemLop.UseVisualStyleBackColor = true;
            btn_ThemLop.Click += btn_ThemLop_Click;
            // 
            // cb_ThemLop
            // 
            cb_ThemLop.AutoSize = true;
            cb_ThemLop.Location = new Point(451, 338);
            cb_ThemLop.Name = "cb_ThemLop";
            cb_ThemLop.Size = new Size(102, 24);
            cb_ThemLop.TabIndex = 0;
            cb_ThemLop.Text = "Thêm lớp";
            cb_ThemLop.UseVisualStyleBackColor = true;
            cb_ThemLop.CheckedChanged += cb_ThemLop_CheckedChanged;
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(606, 275);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(170, 47);
            btn_CapNhat.TabIndex = 7;
            btn_CapNhat.Text = "Cập nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(830, 275);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 47);
            btn_Xoa.TabIndex = 8;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // txt_MSV
            // 
            txt_MSV.Location = new Point(577, 117);
            txt_MSV.Name = "txt_MSV";
            txt_MSV.Size = new Size(347, 28);
            txt_MSV.TabIndex = 10;
            // 
            // txt_HoTen
            // 
            txt_HoTen.Location = new Point(577, 162);
            txt_HoTen.Name = "txt_HoTen";
            txt_HoTen.Size = new Size(347, 28);
            txt_HoTen.TabIndex = 11;
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Location = new Point(577, 211);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(347, 28);
            txt_DiaChi.TabIndex = 12;
            // 
            // cbo_ChonLop
            // 
            cbo_ChonLop.FormattingEnabled = true;
            cbo_ChonLop.Location = new Point(577, 25);
            cbo_ChonLop.Name = "cbo_ChonLop";
            cbo_ChonLop.Size = new Size(347, 28);
            cbo_ChonLop.TabIndex = 13;
            // 
            // frm_QLSV
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 470);
            Controls.Add(cbo_ChonLop);
            Controls.Add(btn_Xoa);
            Controls.Add(txt_MSV);
            Controls.Add(txt_HoTen);
            Controls.Add(txt_DiaChi);
            Controls.Add(btn_CapNhat);
            Controls.Add(cb_ThemLop);
            Controls.Add(grp_ThemLop);
            Controls.Add(lbl_DiaChi);
            Controls.Add(lbl_HoTen);
            Controls.Add(lbl_MSV);
            Controls.Add(lbl_TTSV);
            Controls.Add(lbl_ChonLop);
            Controls.Add(trv_DSLop);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_QLSV";
            Text = "Quản lý sinh viên";
            Load += frm_QLSV_Load;
            grp_ThemLop.ResumeLayout(false);
            grp_ThemLop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView trv_DSLop;
        private Label lbl_ChonLop;
        private Label lbl_TTSV;
        private Label lbl_MSV;
        private Label lbl_HoTen;
        private Label lbl_DiaChi;
        private GroupBox grp_ThemLop;
        private CheckBox cb_ThemLop;
        private Button btn_ThemLop;
        private Button btn_CapNhat;
        private Button btn_Xoa;
        private TextBox txt_TTL;
        private TextBox txt_MSV;
        private TextBox txt_HoTen;
        private TextBox txt_DiaChi;
        private Label lbl_TenLop;
        private ComboBox cbo_ChonLop;
    }
}
