namespace TH05c_BTVN1
{
    partial class frm_BTVN1
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
            tabTuDien = new TabControl();
            tabAnhViet = new TabPage();
            lstTiengAnh = new ListBox();
            cboTiengAnh = new ComboBox();
            txtNghiaViet = new TextBox();
            lblNghiaViet = new Label();
            lblTiengAnh = new Label();
            tabVietAnh = new TabPage();
            lstTiengViet = new ListBox();
            txtNghiaAnh = new TextBox();
            lblNghiaAnh = new Label();
            cboTiengViet = new ComboBox();
            lblTiengViet = new Label();
            btnThoat = new Button();
            tabTuDien.SuspendLayout();
            tabAnhViet.SuspendLayout();
            tabVietAnh.SuspendLayout();
            SuspendLayout();
            // 
            // tabTuDien
            // 
            tabTuDien.Controls.Add(tabAnhViet);
            tabTuDien.Controls.Add(tabVietAnh);
            tabTuDien.Location = new Point(104, 44);
            tabTuDien.Margin = new Padding(4, 3, 4, 3);
            tabTuDien.Name = "tabTuDien";
            tabTuDien.SelectedIndex = 0;
            tabTuDien.Size = new Size(360, 415);
            tabTuDien.TabIndex = 0;
            // 
            // tabAnhViet
            // 
            tabAnhViet.Controls.Add(lstTiengAnh);
            tabAnhViet.Controls.Add(cboTiengAnh);
            tabAnhViet.Controls.Add(txtNghiaViet);
            tabAnhViet.Controls.Add(lblNghiaViet);
            tabAnhViet.Controls.Add(lblTiengAnh);
            tabAnhViet.Location = new Point(4, 29);
            tabAnhViet.Margin = new Padding(4, 3, 4, 3);
            tabAnhViet.Name = "tabAnhViet";
            tabAnhViet.Padding = new Padding(4, 3, 4, 3);
            tabAnhViet.Size = new Size(352, 382);
            tabAnhViet.TabIndex = 0;
            tabAnhViet.Text = "ANH - VIỆT";
            tabAnhViet.UseVisualStyleBackColor = true;
            // 
            // lstTiengAnh
            // 
            lstTiengAnh.FormattingEnabled = true;
            lstTiengAnh.Location = new Point(7, 75);
            lstTiengAnh.Name = "lstTiengAnh";
            lstTiengAnh.Size = new Size(150, 284);
            lstTiengAnh.TabIndex = 5;
            lstTiengAnh.DoubleClick += lstTiengAnh_DoubleClick;
            // 
            // cboTiengAnh
            // 
            cboTiengAnh.FormattingEnabled = true;
            cboTiengAnh.Location = new Point(7, 41);
            cboTiengAnh.Name = "cboTiengAnh";
            cboTiengAnh.Size = new Size(151, 28);
            cboTiengAnh.TabIndex = 3;
            cboTiengAnh.TextUpdate += cboTiengAnh_TextUpdate;
            cboTiengAnh.KeyDown += cboTiengAnh_KeyDown;
            // 
            // txtNghiaViet
            // 
            txtNghiaViet.Location = new Point(184, 41);
            txtNghiaViet.Name = "txtNghiaViet";
            txtNghiaViet.Size = new Size(151, 28);
            txtNghiaViet.TabIndex = 2;
            // 
            // lblNghiaViet
            // 
            lblNghiaViet.AutoSize = true;
            lblNghiaViet.Location = new Point(184, 18);
            lblNghiaViet.Name = "lblNghiaViet";
            lblNghiaViet.Size = new Size(82, 20);
            lblNghiaViet.TabIndex = 1;
            lblNghiaViet.Text = "Tiếng Việt";
            // 
            // lblTiengAnh
            // 
            lblTiengAnh.AutoSize = true;
            lblTiengAnh.Location = new Point(7, 18);
            lblTiengAnh.Name = "lblTiengAnh";
            lblTiengAnh.Size = new Size(83, 20);
            lblTiengAnh.TabIndex = 0;
            lblTiengAnh.Text = "Tiếng Anh";
            // 
            // tabVietAnh
            // 
            tabVietAnh.Controls.Add(lstTiengViet);
            tabVietAnh.Controls.Add(txtNghiaAnh);
            tabVietAnh.Controls.Add(lblNghiaAnh);
            tabVietAnh.Controls.Add(cboTiengViet);
            tabVietAnh.Controls.Add(lblTiengViet);
            tabVietAnh.Location = new Point(4, 29);
            tabVietAnh.Margin = new Padding(4, 3, 4, 3);
            tabVietAnh.Name = "tabVietAnh";
            tabVietAnh.Padding = new Padding(4, 3, 4, 3);
            tabVietAnh.Size = new Size(352, 382);
            tabVietAnh.TabIndex = 1;
            tabVietAnh.Text = "VIỆT - ANH";
            tabVietAnh.UseVisualStyleBackColor = true;
            // 
            // lstTiengViet
            // 
            lstTiengViet.FormattingEnabled = true;
            lstTiengViet.Location = new Point(8, 75);
            lstTiengViet.Name = "lstTiengViet";
            lstTiengViet.Size = new Size(150, 284);
            lstTiengViet.TabIndex = 7;
            lstTiengViet.DoubleClick += lstTiengViet_DoubleClick;
            // 
            // txtNghiaAnh
            // 
            txtNghiaAnh.Location = new Point(194, 41);
            txtNghiaAnh.Name = "txtNghiaAnh";
            txtNghiaAnh.Size = new Size(151, 28);
            txtNghiaAnh.TabIndex = 6;
            // 
            // lblNghiaAnh
            // 
            lblNghiaAnh.AutoSize = true;
            lblNghiaAnh.Location = new Point(194, 18);
            lblNghiaAnh.Name = "lblNghiaAnh";
            lblNghiaAnh.Size = new Size(83, 20);
            lblNghiaAnh.TabIndex = 5;
            lblNghiaAnh.Text = "Tiếng Anh";
            // 
            // cboTiengViet
            // 
            cboTiengViet.FormattingEnabled = true;
            cboTiengViet.Location = new Point(7, 41);
            cboTiengViet.Name = "cboTiengViet";
            cboTiengViet.Size = new Size(151, 28);
            cboTiengViet.TabIndex = 4;
            cboTiengViet.SelectedIndexChanged += cboTiengViet_SelectedIndexChanged;
            cboTiengViet.TextUpdate += cboTiengViet_TextUpdate;
            // 
            // lblTiengViet
            // 
            lblTiengViet.AutoSize = true;
            lblTiengViet.Location = new Point(7, 18);
            lblTiengViet.Name = "lblTiengViet";
            lblTiengViet.Size = new Size(82, 20);
            lblTiengViet.TabIndex = 1;
            lblTiengViet.Text = "Tiếng Việt";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(414, 482);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Th&oát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frm_BTVN1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 538);
            Controls.Add(btnThoat);
            Controls.Add(tabTuDien);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frm_BTVN1";
            Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";
            Load += frm_BTVN1_Load;
            tabTuDien.ResumeLayout(false);
            tabAnhViet.ResumeLayout(false);
            tabAnhViet.PerformLayout();
            tabVietAnh.ResumeLayout(false);
            tabVietAnh.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabTuDien;
        private TabPage tabAnhViet;
        private TabPage tabVietAnh;
        private ComboBox cboTiengAnh;
        private TextBox txtNghiaViet;
        private Label lblNghiaViet;
        private Label lblTiengAnh;
        private ComboBox cboTiengViet;
        private Label lblTiengViet;
        private TextBox txtNghiaAnh;
        private Label lblNghiaAnh;
        private Button btnThoat;
        private ListBox lstTiengAnh;
        private ListBox lstTiengViet;
    }
}
