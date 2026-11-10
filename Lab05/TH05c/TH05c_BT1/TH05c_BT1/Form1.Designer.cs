namespace TH05c_BT1
{
    partial class BT1
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
            lbl_nhapso = new Label();
            lbl_dsus = new Label();
            txt_nhap = new TextBox();
            btn_CapNhat = new Button();
            cbo_ThemSo = new ComboBox();
            lst_UocSo = new ListBox();
            btn_TinhTong = new Button();
            btn_TinhUocChan = new Button();
            btn_TinhSNT = new Button();
            btn_Thoat = new Button();
            SuspendLayout();
            // 
            // lbl_nhapso
            // 
            lbl_nhapso.AutoSize = true;
            lbl_nhapso.Location = new Point(78, 34);
            lbl_nhapso.Name = "lbl_nhapso";
            lbl_nhapso.Size = new Size(69, 20);
            lbl_nhapso.TabIndex = 0;
            lbl_nhapso.Text = "Nhập số";
            // 
            // lbl_dsus
            // 
            lbl_dsus.AutoSize = true;
            lbl_dsus.Location = new Point(404, 34);
            lbl_dsus.Name = "lbl_dsus";
            lbl_dsus.Size = new Size(168, 20);
            lbl_dsus.TabIndex = 1;
            lbl_dsus.Text = "Danh sách các ước số";
            // 
            // txt_nhap
            // 
            txt_nhap.Location = new Point(78, 77);
            txt_nhap.Name = "txt_nhap";
            txt_nhap.Size = new Size(125, 28);
            txt_nhap.TabIndex = 2;
            // 
            // btn_CapNhat
            // 
            btn_CapNhat.Location = new Point(241, 77);
            btn_CapNhat.Name = "btn_CapNhat";
            btn_CapNhat.Size = new Size(94, 29);
            btn_CapNhat.TabIndex = 3;
            btn_CapNhat.Text = "&Cập nhật";
            btn_CapNhat.UseVisualStyleBackColor = true;
            btn_CapNhat.Click += btn_CapNhat_Click;
            // 
            // cbo_ThemSo
            // 
            cbo_ThemSo.FormattingEnabled = true;
            cbo_ThemSo.Location = new Point(78, 150);
            cbo_ThemSo.Name = "cbo_ThemSo";
            cbo_ThemSo.Size = new Size(257, 28);
            cbo_ThemSo.TabIndex = 4;
            cbo_ThemSo.SelectedIndexChanged += cbo_ThemSo_SelectedIndexChanged;
            // 
            // lst_UocSo
            // 
            lst_UocSo.FormattingEnabled = true;
            lst_UocSo.Location = new Point(404, 57);
            lst_UocSo.Name = "lst_UocSo";
            lst_UocSo.Size = new Size(257, 164);
            lst_UocSo.TabIndex = 5;
            // 
            // btn_TinhTong
            // 
            btn_TinhTong.Location = new Point(404, 237);
            btn_TinhTong.Name = "btn_TinhTong";
            btn_TinhTong.Size = new Size(257, 29);
            btn_TinhTong.TabIndex = 6;
            btn_TinhTong.Text = "&Tổng các ước số";
            btn_TinhTong.UseVisualStyleBackColor = true;
            btn_TinhTong.Click += btn_TinhTong_Click;
            // 
            // btn_TinhUocChan
            // 
            btn_TinhUocChan.Location = new Point(404, 272);
            btn_TinhUocChan.Name = "btn_TinhUocChan";
            btn_TinhUocChan.Size = new Size(257, 29);
            btn_TinhUocChan.TabIndex = 7;
            btn_TinhUocChan.Text = "&Số lượng các ước số chẵn";
            btn_TinhUocChan.UseVisualStyleBackColor = true;
            btn_TinhUocChan.Click += btn_TinhUocChan_Click;
            // 
            // btn_TinhSNT
            // 
            btn_TinhSNT.Location = new Point(404, 307);
            btn_TinhSNT.Name = "btn_TinhSNT";
            btn_TinhSNT.Size = new Size(257, 29);
            btn_TinhSNT.TabIndex = 8;
            btn_TinhSNT.Text = "Số lượng các ước số &nguyên tố";
            btn_TinhSNT.UseVisualStyleBackColor = true;
            btn_TinhSNT.Click += btn_TinhSNT_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(241, 307);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(94, 29);
            btn_Thoat.TabIndex = 9;
            btn_Thoat.Text = "Th&oát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // BT1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 450);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_TinhSNT);
            Controls.Add(btn_TinhUocChan);
            Controls.Add(btn_TinhTong);
            Controls.Add(lst_UocSo);
            Controls.Add(cbo_ThemSo);
            Controls.Add(btn_CapNhat);
            Controls.Add(txt_nhap);
            Controls.Add(lbl_dsus);
            Controls.Add(lbl_nhapso);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BT1";
            Text = "Bài tập 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nhapso;
        private Label lbl_dsus;
        private TextBox txt_nhap;
        private Button btn_CapNhat;
        private ComboBox cbo_ThemSo;
        private ListBox lst_UocSo;
        private Button btn_TinhTong;
        private Button btn_TinhUocChan;
        private Button btn_TinhSNT;
        private Button btn_Thoat;
    }
}
