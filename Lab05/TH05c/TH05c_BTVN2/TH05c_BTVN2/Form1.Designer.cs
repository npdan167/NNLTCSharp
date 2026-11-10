namespace TH05c_BTVN2
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
            lblListBox = new Label();
            grpBox1 = new GroupBox();
            lstSo = new ListBox();
            btnNhap = new Button();
            txtNhapSo = new TextBox();
            grpB2 = new GroupBox();
            btnTong = new Button();
            btnXoaDC = new Button();
            btnXoaChon = new Button();
            btnTang2 = new Button();
            btnBinhPhuong = new Button();
            btnChan = new Button();
            btnLe = new Button();
            btnKetThuc = new Button();
            grpBox1.SuspendLayout();
            grpB2.SuspendLayout();
            SuspendLayout();
            // 
            // lblListBox
            // 
            lblListBox.AutoSize = true;
            lblListBox.Font = new Font("Times New Roman", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListBox.ForeColor = Color.FromArgb(255, 128, 0);
            lblListBox.Location = new Point(151, 9);
            lblListBox.Margin = new Padding(4, 0, 4, 0);
            lblListBox.Name = "lblListBox";
            lblListBox.Size = new Size(220, 53);
            lblListBox.TabIndex = 0;
            lblListBox.Text = "LISTBOX";
            // 
            // grpBox1
            // 
            grpBox1.Controls.Add(lstSo);
            grpBox1.Controls.Add(btnNhap);
            grpBox1.Controls.Add(txtNhapSo);
            grpBox1.Location = new Point(39, 83);
            grpBox1.Name = "grpBox1";
            grpBox1.Size = new Size(189, 285);
            grpBox1.TabIndex = 1;
            grpBox1.TabStop = false;
            grpBox1.Text = "List Box";
            // 
            // lstSo
            // 
            lstSo.FormattingEnabled = true;
            lstSo.Location = new Point(6, 102);
            lstSo.Name = "lstSo";
            lstSo.SelectionMode = SelectionMode.MultiSimple;
            lstSo.Size = new Size(177, 184);
            lstSo.TabIndex = 2;
            // 
            // btnNhap
            // 
            btnNhap.Location = new Point(6, 67);
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(177, 29);
            btnNhap.TabIndex = 1;
            btnNhap.Text = "&Nhập";
            btnNhap.UseVisualStyleBackColor = true;
            btnNhap.Click += btnNhap_Click;
            // 
            // txtNhapSo
            // 
            txtNhapSo.Location = new Point(6, 27);
            txtNhapSo.Name = "txtNhapSo";
            txtNhapSo.Size = new Size(177, 28);
            txtNhapSo.TabIndex = 0;
            txtNhapSo.KeyDown += txtNhapSo_KeyDown;
            // 
            // grpB2
            // 
            grpB2.Controls.Add(btnTong);
            grpB2.Controls.Add(btnXoaDC);
            grpB2.Controls.Add(btnXoaChon);
            grpB2.Controls.Add(btnTang2);
            grpB2.Controls.Add(btnBinhPhuong);
            grpB2.Controls.Add(btnChan);
            grpB2.Controls.Add(btnLe);
            grpB2.Location = new Point(254, 83);
            grpB2.Name = "grpB2";
            grpB2.Size = new Size(260, 285);
            grpB2.TabIndex = 0;
            grpB2.TabStop = false;
            grpB2.Text = "Xử lý List Box";
            // 
            // btnTong
            // 
            btnTong.Location = new Point(6, 40);
            btnTong.Name = "btnTong";
            btnTong.Size = new Size(248, 29);
            btnTong.TabIndex = 3;
            btnTong.Text = "Tổng các phần tử trong List";
            btnTong.UseVisualStyleBackColor = true;
            btnTong.Click += btnTong_Click;
            // 
            // btnXoaDC
            // 
            btnXoaDC.Location = new Point(6, 75);
            btnXoaDC.Name = "btnXoaDC";
            btnXoaDC.Size = new Size(248, 29);
            btnXoaDC.TabIndex = 4;
            btnXoaDC.Text = "Xóa phần tử đầu và cuối";
            btnXoaDC.UseVisualStyleBackColor = true;
            btnXoaDC.Click += btnXoaDC_Click;
            // 
            // btnXoaChon
            // 
            btnXoaChon.Location = new Point(6, 110);
            btnXoaChon.Name = "btnXoaChon";
            btnXoaChon.Size = new Size(248, 29);
            btnXoaChon.TabIndex = 5;
            btnXoaChon.Text = "Xóa phần tử đang chọn";
            btnXoaChon.UseVisualStyleBackColor = true;
            btnXoaChon.Click += btnXoaChon_Click;
            // 
            // btnTang2
            // 
            btnTang2.Location = new Point(6, 145);
            btnTang2.Name = "btnTang2";
            btnTang2.Size = new Size(248, 29);
            btnTang2.TabIndex = 6;
            btnTang2.Text = "Tăng mỗi phần tử lên 2";
            btnTang2.UseVisualStyleBackColor = true;
            btnTang2.Click += btnTang2_Click;
            // 
            // btnBinhPhuong
            // 
            btnBinhPhuong.Location = new Point(6, 180);
            btnBinhPhuong.Name = "btnBinhPhuong";
            btnBinhPhuong.Size = new Size(248, 29);
            btnBinhPhuong.TabIndex = 7;
            btnBinhPhuong.Text = "Thay bằng bình phương";
            btnBinhPhuong.UseVisualStyleBackColor = true;
            btnBinhPhuong.Click += btnBinhPhuong_Click;
            // 
            // btnChan
            // 
            btnChan.Location = new Point(6, 215);
            btnChan.Name = "btnChan";
            btnChan.Size = new Size(248, 29);
            btnChan.TabIndex = 8;
            btnChan.Text = "Chọn số chẵn";
            btnChan.UseVisualStyleBackColor = true;
            btnChan.Click += btnChan_Click;
            // 
            // btnLe
            // 
            btnLe.Location = new Point(6, 250);
            btnLe.Name = "btnLe";
            btnLe.Size = new Size(248, 29);
            btnLe.TabIndex = 9;
            btnLe.Text = "Chọn số lẻ";
            btnLe.UseVisualStyleBackColor = true;
            btnLe.Click += btnLe_Click;
            // 
            // btnKetThuc
            // 
            btnKetThuc.Location = new Point(39, 395);
            btnKetThuc.Name = "btnKetThuc";
            btnKetThuc.Size = new Size(418, 29);
            btnKetThuc.TabIndex = 10;
            btnKetThuc.Text = "&KẾT THÚC";
            btnKetThuc.UseVisualStyleBackColor = true;
            btnKetThuc.Click += btnKetThuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 450);
            Controls.Add(btnKetThuc);
            Controls.Add(grpB2);
            Controls.Add(grpBox1);
            Controls.Add(lblListBox);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "frmListBox";
            grpBox1.ResumeLayout(false);
            grpBox1.PerformLayout();
            grpB2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListBox;
        private GroupBox grpBox1;
        private GroupBox grpB2;
        private ListBox lstSo;
        private Button btnNhap;
        private TextBox txtNhapSo;
        private Button btnTong;
        private Button btnXoaDC;
        private Button btnXoaChon;
        private Button btnTang2;
        private Button btnBinhPhuong;
        private Button btnChan;
        private Button btnLe;
        private Button btnKetThuc;
    }
}
