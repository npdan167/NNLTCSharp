namespace TH06b_BTNC2
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
            label1 = new Label();
            cboMonHoc = new ComboBox();
            btnLocDuLieu = new Button();
            label2 = new Label();
            txtTongDiem = new TextBox();
            lvDiem = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Môn học";
            // 
            // cboMonHoc
            // 
            cboMonHoc.FormattingEnabled = true;
            cboMonHoc.Location = new Point(187, 37);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.Size = new Size(255, 28);
            cboMonHoc.TabIndex = 1;
            // 
            // btnLocDuLieu
            // 
            btnLocDuLieu.Location = new Point(544, 36);
            btnLocDuLieu.Name = "btnLocDuLieu";
            btnLocDuLieu.Size = new Size(108, 29);
            btnLocDuLieu.TabIndex = 2;
            btnLocDuLieu.Text = "Lọc dữ liệu";
            btnLocDuLieu.UseVisualStyleBackColor = true;
            btnLocDuLieu.Click += btnLocDuLieu_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 520);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 3;
            label2.Text = "Tổng điểm";
            // 
            // txtTongDiem
            // 
            txtTongDiem.Location = new Point(470, 512);
            txtTongDiem.Name = "txtTongDiem";
            txtTongDiem.Size = new Size(182, 28);
            txtTongDiem.TabIndex = 4;
            // 
            // lvDiem
            // 
            lvDiem.FullRowSelect = true;
            lvDiem.GridLines = true;
            lvDiem.Location = new Point(40, 98);
            lvDiem.Name = "lvDiem";
            lvDiem.Size = new Size(654, 387);
            lvDiem.TabIndex = 5;
            lvDiem.UseCompatibleStateImageBehavior = false;
            lvDiem.View = View.Details;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 569);
            Controls.Add(lvDiem);
            Controls.Add(txtTongDiem);
            Controls.Add(label2);
            Controls.Add(btnLocDuLieu);
            Controls.Add(cboMonHoc);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboMonHoc;
        private Button btnLocDuLieu;
        private Label label2;
        private TextBox txtTongDiem;
        private ListView lvDiem;
    }
}
