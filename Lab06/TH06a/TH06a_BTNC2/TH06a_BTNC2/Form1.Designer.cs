namespace TH06a_BTNC2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            SuspendLayout();
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(154, 30);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(352, 28);
            txtMaSV.TabIndex = 0;
            // 
            // txtMaMH
            // 
            txtMaMH.Location = new Point(154, 97);
            txtMaMH.Name = "txtMaMH";
            txtMaMH.Size = new Size(352, 28);
            txtMaMH.TabIndex = 1;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(154, 163);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(352, 28);
            txtDiem.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Mã sv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 105);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 4;
            label2.Text = "Mã mh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 171);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 5;
            label3.Text = "Điểm";
            // 
            // btnSua
            // 
            btnSua.Location = new Point(412, 218);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(250, 218);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(91, 218);
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
            ClientSize = new Size(584, 290);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDiem);
            Controls.Add(txtMaMH);
            Controls.Add(txtMaSV);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSV;
        private TextBox txtMaMH;
        private TextBox txtDiem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}
