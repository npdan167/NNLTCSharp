namespace TH06b_BTVN1
{
    partial class frmChinh
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            tsmiTaoTonKho = new ToolStripMenuItem();
            tsmiThemSP = new ToolStripMenuItem();
            tsmiBanHang = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiTaoTonKho, tsmiThemSP, tsmiBanHang });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(377, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTaoTonKho
            // 
            tsmiTaoTonKho.Name = "tsmiTaoTonKho";
            tsmiTaoTonKho.Size = new Size(102, 24);
            tsmiTaoTonKho.Text = "Tạo tồn kho";
            tsmiTaoTonKho.Click += tsmiTaoTonKho_Click;
            // 
            // tsmiThemSP
            // 
            tsmiThemSP.Name = "tsmiThemSP";
            tsmiThemSP.Size = new Size(158, 24);
            tsmiThemSP.Text = "Thêm sản phẩm mới";
            tsmiThemSP.Click += tsmiThemSP_Click;
            // 
            // tsmiBanHang
            // 
            tsmiBanHang.Name = "tsmiBanHang";
            tsmiBanHang.Size = new Size(85, 24);
            tsmiBanHang.Text = "Bán hàng";
            tsmiBanHang.Click += tsmiBanHang_Click;
            // 
            // frmChinh
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 228);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmChinh";
            Text = "Form Chính";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiTaoTonKho;
        private ToolStripMenuItem tsmiThemSP;
        private ToolStripMenuItem tsmiBanHang;
    }
}
