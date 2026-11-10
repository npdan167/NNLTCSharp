namespace TH06a_BTNC1
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
            mxtxNgaySinh = new MaskedTextBox();
            txtMaLop = new TextBox();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // mxtxNgaySinh
            // 
            mxtxNgaySinh.Location = new Point(183, 235);
            mxtxNgaySinh.Mask = "00/00/0000";
            mxtxNgaySinh.Name = "mxtxNgaySinh";
            mxtxNgaySinh.Size = new Size(413, 28);
            mxtxNgaySinh.TabIndex = 0;
            mxtxNgaySinh.ValidatingType = typeof(DateTime);
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(183, 36);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(413, 28);
            txtMaLop.TabIndex = 1;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(183, 98);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(413, 28);
            txtMaSV.TabIndex = 2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(183, 166);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(413, 28);
            txtHoTen.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 44);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã lớp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 106);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã sv";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 174);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 6;
            label3.Text = "Họ tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 243);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 7;
            label4.Text = "Ngày sinh";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(93, 301);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(302, 301);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 9;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(502, 301);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 389);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(txtMaLop);
            Controls.Add(mxtxNgaySinh);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mxtxNgaySinh;
        private TextBox txtMaLop;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
