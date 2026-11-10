namespace TH06b_BT2
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
            cboMonHoc = new ComboBox();
            cboSinhVien = new ComboBox();
            txtDiem = new TextBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "Sinh viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Môn học";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Điểm";
            // 
            // cboMonHoc
            // 
            cboMonHoc.FormattingEnabled = true;
            cboMonHoc.Location = new Point(104, 75);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.Size = new Size(255, 28);
            cboMonHoc.TabIndex = 3;
            // 
            // cboSinhVien
            // 
            cboSinhVien.FormattingEnabled = true;
            cboSinhVien.Location = new Point(104, 18);
            cboSinhVien.Name = "cboSinhVien";
            cboSinhVien.Size = new Size(255, 28);
            cboSinhVien.TabIndex = 4;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(104, 138);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(255, 28);
            txtDiem.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 201);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(137, 201);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(265, 201);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 8;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 253);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(txtDiem);
            Controls.Add(cboSinhVien);
            Controls.Add(cboMonHoc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "frmDiem_combo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cboMonHoc;
        private ComboBox cboSinhVien;
        private TextBox txtDiem;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
