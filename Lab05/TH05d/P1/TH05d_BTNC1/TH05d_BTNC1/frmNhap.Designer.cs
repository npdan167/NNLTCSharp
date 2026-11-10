namespace TH05d_BTNC1
{
    partial class frmNhap
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
            label1 = new Label();
            label2 = new Label();
            txtHoTen = new TextBox();
            cboLop = new ComboBox();
            btnCapNhat = new Button();
            btnTroVe = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 29);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 75);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Lớp";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(104, 21);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(223, 28);
            txtHoTen.TabIndex = 2;
            // 
            // cboLop
            // 
            cboLop.FormattingEnabled = true;
            cboLop.Items.AddRange(new object[] { "Lớp A", "Lớp B" });
            cboLop.Location = new Point(104, 67);
            cboLop.Name = "cboLop";
            cboLop.Size = new Size(223, 28);
            cboLop.TabIndex = 3;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(104, 123);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnTroVe
            // 
            btnTroVe.Location = new Point(233, 123);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(94, 29);
            btnTroVe.TabIndex = 5;
            btnTroVe.Text = "Trở về";
            btnTroVe.UseVisualStyleBackColor = true;
            btnTroVe.Click += btnTroVe_Click;
            // 
            // frmNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 173);
            Controls.Add(btnTroVe);
            Controls.Add(btnCapNhat);
            Controls.Add(cboLop);
            Controls.Add(txtHoTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmNhap";
            Text = "Nhập học viên mới";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtHoTen;
        private ComboBox cboLop;
        private Button btnCapNhat;
        private Button btnTroVe;
    }
}