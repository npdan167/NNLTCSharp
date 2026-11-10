namespace lab5d4._1
{
    partial class frmDongHo
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
            this.components = new System.ComponentModel.Container();
            this.btnBatDau = new System.Windows.Forms.Button();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.timerDemNguoc = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnBatDau
            // 
            this.btnBatDau.Location = new System.Drawing.Point(347, 175);
            this.btnBatDau.Name = "btnBatDau";
            this.btnBatDau.Size = new System.Drawing.Size(75, 23);
            this.btnBatDau.TabIndex = 0;
            this.btnBatDau.Text = "Bắt Đầu";
            this.btnBatDau.UseVisualStyleBackColor = true;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(366, 143);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(34, 13);
            this.lblThoiGian.TabIndex = 1;
            this.lblThoiGian.Text = "30:00";
            // 
            // frmDongHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.btnBatDau);
            this.Name = "frmDongHo";
            this.Text = "Đồng hồ";
            this.Load += new System.EventHandler(this.frmDongHo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBatDau;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Timer timerDemNguoc;
    }
}

