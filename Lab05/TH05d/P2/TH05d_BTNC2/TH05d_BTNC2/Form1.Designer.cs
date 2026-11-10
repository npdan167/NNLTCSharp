namespace TH05d_BTNC2
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
            txtMaSV = new TextBox();
            txtMaMH = new TextBox();
            txtDiem = new TextBox();
            lblMaSv = new Label();
            lblMaMH = new Label();
            lblDiem = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            SuspendLayout();
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(109, 21);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(327, 28);
            txtMaSV.TabIndex = 0;
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(109, 88);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(327, 28);
            txtMaMH.TabIndex = 1;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(109, 151);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(327, 28);
            txtDiem.TabIndex = 2;
            // 
            // lblMaSv
            // 
            lblMaSv.AutoSize = true;
            lblMaSv.Location = new Point(24, 29);
            lblMaSv.Name = "lblMaSv";
            lblMaSv.Size = new Size(54, 20);
            lblMaSv.TabIndex = 3;
            lblMaSv.Text = "Mã sv";
            // 
            // lblMaMH
            // 
            lblMaMH.AutoSize = true;
            lblMaMH.Location = new Point(24, 96);
            lblMaMH.Name = "lblMaMH";
            lblMaMH.Size = new Size(61, 20);
            lblMaMH.TabIndex = 4;
            lblMaMH.Text = "Mã mh";
            // 
            // lblDiem
            // 
            lblDiem.AutoSize = true;
            lblDiem.Location = new Point(24, 159);
            lblDiem.Name = "lblDiem";
            lblDiem.Size = new Size(48, 20);
            lblDiem.TabIndex = 5;
            lblDiem.Text = "Điểm";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(285, 216);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(159, 216);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(39, 216);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 257);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(lblDiem);
            Controls.Add(lblMaMH);
            Controls.Add(lblMaSv);
            Controls.Add(txtDiem);
            Controls.Add(txtMaMH);
            Controls.Add(txtMaSV);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Quản lý điểm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSV;
        private TextBox txtMaMH;
        private TextBox txtDiem;
        private Label lblMaSv;
        private Label lblMaMH;
        private Label lblDiem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}
