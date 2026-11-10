namespace TH05c_Bai1
{
    partial class frmListBox
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
            lst_Trai = new ListBox();
            lst_Phai = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lst_Trai
            // 
            lst_Trai.FormattingEnabled = true;
            lst_Trai.ItemHeight = 22;
            lst_Trai.Items.AddRange(new object[] { "Cóc", "Ổi", "Xoài", "Me", "Bưởi", "Cam" });
            lst_Trai.Location = new Point(51, 30);
            lst_Trai.Name = "lst_Trai";
            lst_Trai.Size = new Size(150, 334);
            lst_Trai.TabIndex = 0;
            lst_Trai.SelectedIndexChanged += lst_Trai_SelectedIndexChanged;
            // 
            // lst_Phai
            // 
            lst_Phai.FormattingEnabled = true;
            lst_Phai.ItemHeight = 22;
            lst_Phai.Location = new Point(359, 30);
            lst_Phai.Name = "lst_Phai";
            lst_Phai.Size = new Size(150, 334);
            lst_Phai.TabIndex = 1;
            lst_Phai.SelectedIndexChanged += lst_Phai_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(231, 55);
            button1.Name = "button1";
            button1.Size = new Size(94, 52);
            button1.TabIndex = 2;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnQuaPhai_Click;
            // 
            // button2
            // 
            button2.Location = new Point(231, 129);
            button2.Name = "button2";
            button2.Size = new Size(94, 52);
            button2.TabIndex = 3;
            button2.Text = ">>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnQuaPhaiAll_Click;
            // 
            // button3
            // 
            button3.Location = new Point(231, 203);
            button3.Name = "button3";
            button3.Size = new Size(94, 52);
            button3.TabIndex = 4;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnQuaTrai_Click;
            // 
            // button4
            // 
            button4.Location = new Point(231, 273);
            button4.Name = "button4";
            button4.Size = new Size(94, 52);
            button4.TabIndex = 5;
            button4.Text = "<<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnQuaTraiAll_Click;
            // 
            // frmListBox
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 391);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lst_Phai);
            Controls.Add(lst_Trai);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmListBox";
            Text = "Sử dụng listbox";
            FormClosing += frmListBox_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst_Trai;
        private ListBox lst_Phai;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
