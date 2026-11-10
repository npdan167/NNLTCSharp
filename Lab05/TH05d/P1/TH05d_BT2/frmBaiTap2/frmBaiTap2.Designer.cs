namespace lab5
{
    partial class frmBaiTap2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbSTK = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.lbĐCKH = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.txtSTK = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lvTaiKhoan = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(170, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN NGÂN HÀNG";
            // 
            // lbSTK
            // 
            this.lbSTK.AutoSize = true;
            this.lbSTK.Location = new System.Drawing.Point(168, 62);
            this.lbSTK.Name = "lbSTK";
            this.lbSTK.Size = new System.Drawing.Size(67, 13);
            this.lbSTK.TabIndex = 1;
            this.lbSTK.Text = "Số tài khoản";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(149, 105);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(86, 13);
            this.lbTenKH.TabIndex = 3;
            this.lbTenKH.Text = "Tên khách hàng";
            // 
            // lbĐCKH
            // 
            this.lbĐCKH.AutoSize = true;
            this.lbĐCKH.Location = new System.Drawing.Point(135, 145);
            this.lbĐCKH.Name = "lbĐCKH";
            this.lbĐCKH.Size = new System.Drawing.Size(100, 13);
            this.lbĐCKH.TabIndex = 5;
            this.lbĐCKH.Text = "Địa chỉ khách hàng";
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Location = new System.Drawing.Point(121, 185);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(114, 13);
            this.lbSoTien.TabIndex = 7;
            this.lbSoTien.Text = "Số tiền trong tài khoản";
            // 
            // txtSTK
            // 
            this.txtSTK.Location = new System.Drawing.Point(265, 62);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(438, 20);
            this.txtSTK.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 102);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(265, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(438, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(265, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(438, 20);
            this.textBox3.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(320, 208);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 30);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(420, 208);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 30);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(521, 208);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 30);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(618, 208);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 30);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 438);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(432, 435);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(200, 20);
            this.txtTongTien.TabIndex = 15;
            // 
            // lvTaiKhoan
            // 
            this.lvTaiKhoan.FullRowSelect = true;
            this.lvTaiKhoan.GridLines = true;
            this.lvTaiKhoan.HideSelection = false;
            this.lvTaiKhoan.Location = new System.Drawing.Point(53, 247);
            this.lvTaiKhoan.MultiSelect = false;
            this.lvTaiKhoan.Name = "lvTaiKhoan";
            this.lvTaiKhoan.Size = new System.Drawing.Size(650, 175);
            this.lvTaiKhoan.TabIndex = 13;
            this.lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            this.lvTaiKhoan.View = System.Windows.Forms.View.Details;
            // 
            // frmBaiTap2
            // 
            this.ClientSize = new System.Drawing.Size(717, 534);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbSTK);
            this.Controls.Add(this.txtSTK);
            this.Controls.Add(this.lbTenKH);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbĐCKH);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lvTaiKhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTongTien);
            this.Name = "frmBaiTap2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản ngân hàng";
            this.Load += new System.EventHandler(this.frmBaiTap2_Load_2);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSTK;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label lbĐCKH;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.TextBox txtSTK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ListView lvTaiKhoan;
    }
}