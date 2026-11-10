namespace TH06a_BT1
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
            txtMMH = new TextBox();
            txtTMH = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            SuspendLayout();
            // 
            // txtMMH
            // 
            txtMMH.Location = new Point(155, 56);
            txtMMH.Margin = new Padding(4, 3, 4, 3);
            txtMMH.Name = "txtMMH";
            txtMMH.Size = new Size(412, 28);
            txtMMH.TabIndex = 0;
            // 
            // txtTMH
            // 
            txtTMH.Location = new Point(155, 125);
            txtTMH.Margin = new Padding(4, 3, 4, 3);
            txtTMH.Name = "txtTMH";
            txtTMH.Size = new Size(412, 28);
            txtTMH.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 2;
            label1.Text = "Mã mh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Tên mh";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(91, 182);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(118, 29);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(275, 182);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(118, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(451, 182);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(118, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 250);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTMH);
            Controls.Add(txtMMH);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMMH;
        private TextBox txtTMH;
        private Label label1;
        private Label label2;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
