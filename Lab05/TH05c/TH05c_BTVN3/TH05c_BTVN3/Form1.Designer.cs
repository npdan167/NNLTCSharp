namespace TH05c_BTVN3
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
            trvDanhBa = new TreeView();
            grpTTDB = new GroupBox();
            btnAdd = new Button();
            txtLN = new TextBox();
            txtFN = new TextBox();
            lblLN = new Label();
            lblFN = new Label();
            btnExit = new Button();
            grpTTDB.SuspendLayout();
            SuspendLayout();
            // 
            // trvDanhBa
            // 
            trvDanhBa.Location = new Point(0, 0);
            trvDanhBa.Margin = new Padding(4, 3, 4, 3);
            trvDanhBa.Name = "trvDanhBa";
            trvDanhBa.Size = new Size(227, 450);
            trvDanhBa.TabIndex = 0;
            // 
            // grpTTDB
            // 
            grpTTDB.Controls.Add(btnAdd);
            grpTTDB.Controls.Add(txtLN);
            grpTTDB.Controls.Add(txtFN);
            grpTTDB.Controls.Add(lblLN);
            grpTTDB.Controls.Add(lblFN);
            grpTTDB.Location = new Point(235, 22);
            grpTTDB.Margin = new Padding(4, 3, 4, 3);
            grpTTDB.Name = "grpTTDB";
            grpTTDB.Padding = new Padding(4, 3, 4, 3);
            grpTTDB.Size = new Size(490, 212);
            grpTTDB.TabIndex = 1;
            grpTTDB.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(375, 160);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtLN
            // 
            txtLN.Location = new Point(140, 99);
            txtLN.Name = "txtLN";
            txtLN.Size = new Size(329, 28);
            txtLN.TabIndex = 3;
            // 
            // txtFN
            // 
            txtFN.Location = new Point(140, 45);
            txtFN.Name = "txtFN";
            txtFN.Size = new Size(329, 28);
            txtFN.TabIndex = 2;
            // 
            // lblLN
            // 
            lblLN.AutoSize = true;
            lblLN.Location = new Point(45, 102);
            lblLN.Name = "lblLN";
            lblLN.Size = new Size(88, 20);
            lblLN.TabIndex = 1;
            lblLN.Text = "Last Name";
            // 
            // lblFN
            // 
            lblFN.AutoSize = true;
            lblFN.Location = new Point(45, 53);
            lblFN.Name = "lblFN";
            lblFN.Size = new Size(89, 20);
            lblFN.TabIndex = 0;
            lblFN.Text = "First Name";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(585, 258);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 45);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 450);
            Controls.Add(btnExit);
            Controls.Add(grpTTDB);
            Controls.Add(trvDanhBa);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "frmBTVN3";
            Load += Form1_Load;
            grpTTDB.ResumeLayout(false);
            grpTTDB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TreeView trvDanhBa;
        private GroupBox grpTTDB;
        private Button btnAdd;
        private TextBox txtLN;
        private TextBox txtFN;
        private Label lblLN;
        private Label lblFN;
        private Button btnExit;
    }
}
