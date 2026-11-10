namespace TH05d_BTVN1
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
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            lblMaKhoa = new Label();
            lblMaLop = new Label();
            lblTenLop = new Label();
            txtMaKhoa = new TextBox();
            txtMaLop = new TextBox();
            txtTenLop = new TextBox();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(38, 172);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(93, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(138, 172);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(238, 172);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Location = new Point(12, 25);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(73, 20);
            lblMaKhoa.TabIndex = 3;
            lblMaKhoa.Text = "Mã khoa";
            // 
            // lblMaLop
            // 
            lblMaLop.AutoSize = true;
            lblMaLop.Location = new Point(12, 72);
            lblMaLop.Name = "lblMaLop";
            lblMaLop.Size = new Size(61, 20);
            lblMaLop.TabIndex = 4;
            lblMaLop.Text = "Mã lớp";
            // 
            // lblTenLop
            // 
            lblTenLop.AutoSize = true;
            lblTenLop.Location = new Point(12, 117);
            lblTenLop.Name = "lblTenLop";
            lblTenLop.Size = new Size(66, 20);
            lblTenLop.TabIndex = 5;
            lblTenLop.Text = "Tên lớp";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(90, 17);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(284, 28);
            txtMaKhoa.TabIndex = 6;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(90, 64);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(284, 28);
            txtMaLop.TabIndex = 7;
            // 
            // txtTenLop
            // 
            txtTenLop.Location = new Point(90, 109);
            txtTenLop.Name = "txtTenLop";
            txtTenLop.Size = new Size(284, 28);
            txtTenLop.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 213);
            Controls.Add(txtTenLop);
            Controls.Add(txtMaLop);
            Controls.Add(txtMaKhoa);
            Controls.Add(lblTenLop);
            Controls.Add(lblMaLop);
            Controls.Add(lblMaKhoa);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "frmLop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Label lblMaKhoa;
        private Label lblMaLop;
        private Label lblTenLop;
        private TextBox txtMaKhoa;
        private TextBox txtMaLop;
        private TextBox txtTenLop;
    }
}
