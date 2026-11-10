namespace TH05C
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
            button1 = new Button();
            lst_Phai = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // lst_Trai
            // 
            lst_Trai.AccessibleName = "";
            lst_Trai.FormattingEnabled = true;
            lst_Trai.ItemHeight = 22;
            lst_Trai.Items.AddRange(new object[] { "Cóc", "Ổi", "Xoài ", "Me", "Bưởi", "Cam" });
            lst_Trai.Location = new Point(37, 31);
            lst_Trai.Name = "lst_Trai";
            lst_Trai.Size = new Size(201, 378);
            lst_Trai.TabIndex = 0;
            lst_Trai.SelectedIndexChanged += lst_Trai_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(260, 74);
            button1.Name = "button1";
            button1.Size = new Size(74, 50);
            button1.TabIndex = 1;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnQuaPhai_Click;
            // 
            // lst_Phai
            // 
            lst_Phai.AccessibleName = "";
            lst_Phai.FormattingEnabled = true;
            lst_Phai.ItemHeight = 22;
            lst_Phai.Location = new Point(355, 31);
            lst_Phai.Name = "lst_Phai";
            lst_Phai.Size = new Size(201, 378);
            lst_Phai.TabIndex = 2;
            lst_Phai.SelectedIndexChanged += lst_Phai_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(260, 228);
            button2.Name = "button2";
            button2.Size = new Size(74, 50);
            button2.TabIndex = 3;
            button2.Text = "<";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnQuaTrai_Click;
            // 
            // button3
            // 
            button3.Location = new Point(259, 307);
            button3.Name = "button3";
            button3.Size = new Size(74, 50);
            button3.TabIndex = 4;
            button3.Text = "<<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnQuaTraiAll_Click;
            // 
            // button4
            // 
            button4.Location = new Point(259, 147);
            button4.Name = "button4";
            button4.Size = new Size(74, 50);
            button4.TabIndex = 5;
            button4.Text = ">>";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnQuaPhaiAll_Click;
            // 
            // frmListBox
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 441);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lst_Phai);
            Controls.Add(button1);
            Controls.Add(lst_Trai);
            Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmListBox";
            Text = "Sử dụng Listbox";
            FormClosing += frmListBox_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lst_Trai;
        private Button button1;
        private ListBox lst_Phai;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
