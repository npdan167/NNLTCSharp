namespace TH05d_BTNC1
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
            msCapNhat = new MenuStrip();
            tmsCapNhat = new ToolStripMenuItem();
            tsmiNhap = new ToolStripMenuItem();
            tsmiChuyenB = new ToolStripMenuItem();
            tsmiChuyenA = new ToolStripMenuItem();
            tsmiXoa = new ToolStripMenuItem();
            tmsKetThuc = new ToolStripMenuItem();
            gbLopA = new GroupBox();
            lstLopA = new ListBox();
            gbLopB = new GroupBox();
            lstLopB = new ListBox();
            msCapNhat.SuspendLayout();
            gbLopA.SuspendLayout();
            gbLopB.SuspendLayout();
            SuspendLayout();
            // 
            // msCapNhat
            // 
            msCapNhat.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            msCapNhat.ImageScalingSize = new Size(20, 20);
            msCapNhat.Items.AddRange(new ToolStripItem[] { tmsCapNhat, tmsKetThuc });
            msCapNhat.Location = new Point(0, 0);
            msCapNhat.Name = "msCapNhat";
            msCapNhat.Padding = new Padding(8, 2, 0, 2);
            msCapNhat.Size = new Size(530, 28);
            msCapNhat.TabIndex = 0;
            msCapNhat.Text = "Cập nhật";
            // 
            // tmsCapNhat
            // 
            tmsCapNhat.DropDownItems.AddRange(new ToolStripItem[] { tsmiNhap, tsmiChuyenB, tsmiChuyenA, tsmiXoa });
            tmsCapNhat.Name = "tmsCapNhat";
            tmsCapNhat.Size = new Size(95, 24);
            tmsCapNhat.Text = "Cập nhật";
            // 
            // tsmiNhap
            // 
            tsmiNhap.Name = "tsmiNhap";
            tsmiNhap.Size = new Size(239, 26);
            tsmiNhap.Text = "Nhập học viên mới";
            tsmiNhap.Click += tsmiNhap_Click;
            // 
            // tsmiChuyenB
            // 
            tsmiChuyenB.Name = "tsmiChuyenB";
            tsmiChuyenB.Size = new Size(239, 26);
            tsmiChuyenB.Text = "Chuyển sang lớp B";
            tsmiChuyenB.Click += tsmiChuyenB_Click;
            // 
            // tsmiChuyenA
            // 
            tsmiChuyenA.Name = "tsmiChuyenA";
            tsmiChuyenA.Size = new Size(239, 26);
            tsmiChuyenA.Text = "Chuyển sang lớp A";
            tsmiChuyenA.Click += tsmiChuyenA_Click;
            // 
            // tsmiXoa
            // 
            tsmiXoa.Name = "tsmiXoa";
            tsmiXoa.Size = new Size(239, 26);
            tsmiXoa.Text = "Xóa học viên";
            tsmiXoa.Click += tsmiXoa_Click;
            // 
            // tmsKetThuc
            // 
            tmsKetThuc.Name = "tmsKetThuc";
            tmsKetThuc.Size = new Size(90, 24);
            tmsKetThuc.Text = "Kết thúc";
            tmsKetThuc.Click += tmsKetThuc_Click;
            // 
            // gbLopA
            // 
            gbLopA.Controls.Add(lstLopA);
            gbLopA.Location = new Point(12, 31);
            gbLopA.Name = "gbLopA";
            gbLopA.Size = new Size(250, 241);
            gbLopA.TabIndex = 1;
            gbLopA.TabStop = false;
            gbLopA.Text = "Lớp A";
            // 
            // lstLopA
            // 
            lstLopA.FormattingEnabled = true;
            lstLopA.Location = new Point(6, 27);
            lstLopA.Name = "lstLopA";
            lstLopA.SelectionMode = SelectionMode.MultiSimple;
            lstLopA.Size = new Size(238, 204);
            lstLopA.TabIndex = 0;
            // 
            // gbLopB
            // 
            gbLopB.Controls.Add(lstLopB);
            gbLopB.Location = new Point(268, 31);
            gbLopB.Name = "gbLopB";
            gbLopB.Size = new Size(250, 241);
            gbLopB.TabIndex = 0;
            gbLopB.TabStop = false;
            gbLopB.Text = "Lớp B";
            // 
            // lstLopB
            // 
            lstLopB.FormattingEnabled = true;
            lstLopB.Location = new Point(6, 27);
            lstLopB.Name = "lstLopB";
            lstLopB.SelectionMode = SelectionMode.MultiSimple;
            lstLopB.Size = new Size(238, 204);
            lstLopB.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 284);
            Controls.Add(gbLopB);
            Controls.Add(gbLopA);
            Controls.Add(msCapNhat);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = msCapNhat;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Quản lý học viên";
            Load += Form1_Load;
            msCapNhat.ResumeLayout(false);
            msCapNhat.PerformLayout();
            gbLopA.ResumeLayout(false);
            gbLopB.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msCapNhat;
        private ToolStripMenuItem tmsCapNhat;
        private ToolStripMenuItem tsmiNhap;
        private ToolStripMenuItem tsmiChuyenB;
        private ToolStripMenuItem tsmiChuyenA;
        private ToolStripMenuItem tsmiXoa;
        private ToolStripMenuItem tmsKetThuc;
        private GroupBox gbLopA;
        private GroupBox gbLopB;
        private ListBox lstLopA;
        private ListBox lstLopB;
    }
}
