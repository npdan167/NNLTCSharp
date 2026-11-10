namespace TH06b_BT1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboLop = new ComboBox();
            txtMasv = new TextBox();
            txtHoTen = new TextBox();
            mtxtNgaySinh = new MaskedTextBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 78);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã sv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 130);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 176);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh";
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Location = new Point(103, 24);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(297, 28);
            cboLop.TabIndex = 4;
            // 
            // txtMasv
            // 
            txtMasv.Location = new Point(103, 70);
            txtMasv.Name = "txtMasv";
            txtMasv.Size = new Size(297, 28);
            txtMasv.TabIndex = 5;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(103, 122);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(297, 28);
            txtHoTen.TabIndex = 6;
            // 
            // mtxtNgaySinh
            // 
            mtxtNgaySinh.Location = new Point(103, 168);
            mtxtNgaySinh.Mask = "00/00/0000";
            mtxtNgaySinh.Name = "mtxtNgaySinh";
            mtxtNgaySinh.Size = new Size(297, 28);
            mtxtNgaySinh.TabIndex = 7;
            mtxtNgaySinh.ValidatingType = typeof(DateTime);
            // 
            // btnSua
            // 
            btnSua.Location = new Point(306, 211);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(166, 211);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(40, 211);
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
            ClientSize = new Size(445, 265);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(mtxtNgaySinh);
            Controls.Add(txtHoTen);
            Controls.Add(txtMasv);
            Controls.Add(cboLop);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboLop;
        private TextBox txtMasv;
        private TextBox txtHoTen;
        private MaskedTextBox mtxtNgaySinh;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}
