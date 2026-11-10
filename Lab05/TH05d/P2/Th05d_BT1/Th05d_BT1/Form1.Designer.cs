namespace Th05d_BT1
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
            lblMaMH = new Label();
            lblTenMH = new Label();
            txtMMH = new TextBox();
            txtTMH = new TextBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            SuspendLayout();
            // 
            // lblMaMH
            // 
            lblMaMH.AutoSize = true;
            lblMaMH.Location = new Point(20, 38);
            lblMaMH.Margin = new Padding(4, 0, 4, 0);
            lblMaMH.Name = "lblMaMH";
            lblMaMH.Size = new Size(61, 20);
            lblMaMH.TabIndex = 0;
            lblMaMH.Text = "Mã mh";
            // 
            // lblTenMH
            // 
            lblTenMH.AutoSize = true;
            lblTenMH.Location = new Point(20, 82);
            lblTenMH.Margin = new Padding(4, 0, 4, 0);
            lblTenMH.Name = "lblTenMH";
            lblTenMH.Size = new Size(66, 20);
            lblTenMH.TabIndex = 1;
            lblTenMH.Text = "Tên mh";
            // 
            // txtMMH
            // 
            txtMMH.Location = new Point(90, 31);
            txtMMH.Margin = new Padding(4, 3, 4, 3);
            txtMMH.Name = "txtMMH";
            txtMMH.Size = new Size(332, 28);
            txtMMH.TabIndex = 2;
            // 
            // txtTMH
            // 
            txtTMH.Location = new Point(90, 75);
            txtTMH.Margin = new Padding(4, 3, 4, 3);
            txtTMH.Name = "txtTMH";
            txtTMH.Size = new Size(332, 28);
            txtTMH.TabIndex = 3;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(305, 127);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(164, 127);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 127);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 177);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(txtTMH);
            Controls.Add(txtMMH);
            Controls.Add(lblTenMH);
            Controls.Add(lblMaMH);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Quản lý môn học";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaMH;
        private Label lblTenMH;
        private TextBox txtMMH;
        private TextBox txtTMH;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}
