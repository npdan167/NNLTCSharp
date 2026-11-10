namespace lab5
{
    partial class frmBai1
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
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMaSV = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.lbNgoaiNgu = new System.Windows.Forms.Label();
            this.chkAnh = new System.Windows.Forms.CheckBox();
            this.chkPhap = new System.Windows.Forms.CheckBox();
            this.chkHoa = new System.Windows.Forms.CheckBox();
            this.lbDanToc = new System.Windows.Forms.Label();
            this.cboDanToc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.clnHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNgoaiNgu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDanToc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(26, 20);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(58, 13);
            this.lbHoTen.TabIndex = 0;
            this.lbHoTen.Text = "Họ và Tên";
            // 
            // lbMaSV
            // 
            this.lbMaSV.AutoSize = true;
            this.lbMaSV.Location = new System.Drawing.Point(26, 53);
            this.lbMaSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaSV.Name = "lbMaSV";
            this.lbMaSV.Size = new System.Drawing.Size(67, 13);
            this.lbMaSV.TabIndex = 2;
            this.lbMaSV.Text = "Mã sinh viên";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(26, 85);
            this.lbGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(47, 13);
            this.lbGioiTinh.TabIndex = 4;
            this.lbGioiTinh.Text = "Giới tính";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(109, 18);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(174, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(109, 50);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(174, 20);
            this.txtMaSV.TabIndex = 3;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(109, 84);
            this.radNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(47, 17);
            this.radNam.TabIndex = 5;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(165, 84);
            this.radNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 17);
            this.radNu.TabIndex = 6;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // lbNgoaiNgu
            // 
            this.lbNgoaiNgu.AutoSize = true;
            this.lbNgoaiNgu.Location = new System.Drawing.Point(26, 118);
            this.lbNgoaiNgu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgoaiNgu.Name = "lbNgoaiNgu";
            this.lbNgoaiNgu.Size = new System.Drawing.Size(56, 13);
            this.lbNgoaiNgu.TabIndex = 7;
            this.lbNgoaiNgu.Text = "Ngoại ngữ";
            // 
            // chkAnh
            // 
            this.chkAnh.AutoSize = true;
            this.chkAnh.Location = new System.Drawing.Point(109, 116);
            this.chkAnh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAnh.Name = "chkAnh";
            this.chkAnh.Size = new System.Drawing.Size(45, 17);
            this.chkAnh.TabIndex = 8;
            this.chkAnh.Text = "Anh";
            // 
            // chkPhap
            // 
            this.chkPhap.AutoSize = true;
            this.chkPhap.Location = new System.Drawing.Point(165, 116);
            this.chkPhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkPhap.Name = "chkPhap";
            this.chkPhap.Size = new System.Drawing.Size(51, 17);
            this.chkPhap.TabIndex = 9;
            this.chkPhap.Text = "Pháp";
            // 
            // chkHoa
            // 
            this.chkHoa.AutoSize = true;
            this.chkHoa.Location = new System.Drawing.Point(225, 116);
            this.chkHoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkHoa.Name = "chkHoa";
            this.chkHoa.Size = new System.Drawing.Size(46, 17);
            this.chkHoa.TabIndex = 10;
            this.chkHoa.Text = "Hoa";
            // 
            // lbDanToc
            // 
            this.lbDanToc.AutoSize = true;
            this.lbDanToc.Location = new System.Drawing.Point(26, 150);
            this.lbDanToc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDanToc.Name = "lbDanToc";
            this.lbDanToc.Size = new System.Drawing.Size(45, 13);
            this.lbDanToc.TabIndex = 11;
            this.lbDanToc.Text = "Dân tộc";
            // 
            // cboDanToc
            // 
            this.cboDanToc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDanToc.FormattingEnabled = true;
            this.cboDanToc.Location = new System.Drawing.Point(109, 148);
            this.cboDanToc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboDanToc.Name = "cboDanToc";
            this.cboDanToc.Size = new System.Drawing.Size(174, 21);
            this.cboDanToc.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Danh sách sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnHoTen,
            this.clnMaSV,
            this.clnGioiTinh,
            this.clnNgoaiNgu,
            this.clnDanToc});
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(26, 205);
            this.lvSinhVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvSinhVien.MultiSelect = false;
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(571, 119);
            this.lvSinhVien.TabIndex = 14;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // clnHoTen
            // 
            this.clnHoTen.Text = "Họ tên";
            this.clnHoTen.Width = 180;
            // 
            // clnMaSV
            // 
            this.clnMaSV.Text = "Mã sinh viên";
            this.clnMaSV.Width = 120;
            // 
            // clnGioiTinh
            // 
            this.clnGioiTinh.Text = "Giới tính";
            this.clnGioiTinh.Width = 100;
            // 
            // clnNgoaiNgu
            // 
            this.clnNgoaiNgu.Text = "Ngoại ngữ";
            this.clnNgoaiNgu.Width = 180;
            // 
            // clnDanToc
            // 
            this.clnDanToc.Text = "Dân tộc";
            this.clnDanToc.Width = 150;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(109, 363);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(242, 363);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 28);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(394, 363);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 28);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 653);
            this.Controls.Add(this.lbHoTen);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.lbMaSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.lbGioiTinh);
            this.Controls.Add(this.radNam);
            this.Controls.Add(this.radNu);
            this.Controls.Add(this.lbNgoaiNgu);
            this.Controls.Add(this.chkAnh);
            this.Controls.Add(this.chkPhap);
            this.Controls.Add(this.chkHoa);
            this.Controls.Add(this.lbDanToc);
            this.Controls.Add(this.cboDanToc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSinhVien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaitap1";
            this.Load += new System.EventHandler(this.frmBai1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMaSV;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.Label lbNgoaiNgu;
        private System.Windows.Forms.CheckBox chkAnh;
        private System.Windows.Forms.CheckBox chkPhap;
        private System.Windows.Forms.CheckBox chkHoa;
        private System.Windows.Forms.Label lbDanToc;
        private System.Windows.Forms.ComboBox cboDanToc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ColumnHeader clnHoTen;
        private System.Windows.Forms.ColumnHeader clnMaSV;
        private System.Windows.Forms.ColumnHeader clnGioiTinh;
        private System.Windows.Forms.ColumnHeader clnNgoaiNgu;
        private System.Windows.Forms.ColumnHeader clnDanToc;
    }
}

