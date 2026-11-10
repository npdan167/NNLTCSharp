namespace TH05c_Bai2
{
    partial class Cbo_Dantoc
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
            btn_loadDL = new Button();
            cbo_dt = new ComboBox();
            label1 = new Label();
            btnHienThi = new Button();
            lbl_kq = new Label();
            SuspendLayout();
            // 
            // btn_loadDL
            // 
            btn_loadDL.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_loadDL.Location = new Point(31, 27);
            btn_loadDL.Name = "btn_loadDL";
            btn_loadDL.Size = new Size(253, 35);
            btn_loadDL.TabIndex = 0;
            btn_loadDL.Text = "Load dữ liệu Combobox";
            btn_loadDL.UseVisualStyleBackColor = true;
            btn_loadDL.Click += btn_loadDL_Click;
            // 
            // cbo_dt
            // 
            cbo_dt.FormattingEnabled = true;
            cbo_dt.Location = new Point(166, 92);
            cbo_dt.Name = "cbo_dt";
            cbo_dt.Size = new Size(243, 28);
            cbo_dt.TabIndex = 1;
            cbo_dt.SelectedIndexChanged += cbo_dt_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 95);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 2;
            label1.Text = "Dân tộc";
            // 
            // btnHienThi
            // 
            btnHienThi.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHienThi.Location = new Point(242, 153);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(94, 29);
            btnHienThi.TabIndex = 3;
            btnHienThi.Text = "Hiển thị ";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btn_hienthi_Click;
            // 
            // lbl_kq
            // 
            lbl_kq.AutoSize = true;
            lbl_kq.ForeColor = Color.Red;
            lbl_kq.Location = new Point(285, 213);
            lbl_kq.Name = "lbl_kq";
            lbl_kq.Size = new Size(0, 20);
            lbl_kq.TabIndex = 4;
            // 
            // Cbo_Dantoc
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 291);
            Controls.Add(lbl_kq);
            Controls.Add(btnHienThi);
            Controls.Add(label1);
            Controls.Add(cbo_dt);
            Controls.Add(btn_loadDL);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Cbo_Dantoc";
            Text = "Cbo_Dantoc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_loadDL;
        private ComboBox cbo_dt;
        private Label label1;
        private Button btnHienThi;
        private Label lbl_kq;
    }
}
