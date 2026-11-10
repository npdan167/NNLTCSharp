namespace TH06b_BTNC1
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
            btnHienThi = new Button();
            btnThoat = new Button();
            lvLop = new ListView();
            SuspendLayout();
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(49, 12);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(156, 40);
            btnHienThi.TabIndex = 0;
            btnHienThi.Text = "Hiển thị dữ liệu";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(671, 358);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 45);
            btnThoat.TabIndex = 1;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // lvLop
            // 
            lvLop.FullRowSelect = true;
            lvLop.GridLines = true;
            lvLop.Location = new Point(49, 58);
            lvLop.Name = "lvLop";
            lvLop.Size = new Size(716, 294);
            lvLop.TabIndex = 2;
            lvLop.UseCompatibleStateImageBehavior = false;
            lvLop.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 435);
            Controls.Add(lvLop);
            Controls.Add(btnThoat);
            Controls.Add(btnHienThi);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Danh sách lớp";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHienThi;
        private Button btnThoat;
        private ListView lvLop;
    }
}
