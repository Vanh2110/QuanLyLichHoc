namespace Giao_Dien.View
{
    partial class FormQuanTriVien
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
            btnQLSV = new Button();
            btnQLGV = new Button();
            btnQLLH = new Button();
            label1 = new Label();
            btnExit = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnQLSV
            // 
            btnQLSV.Font = new Font("Noto Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnQLSV.Location = new Point(145, 108);
            btnQLSV.Name = "btnQLSV";
            btnQLSV.Size = new Size(178, 60);
            btnQLSV.TabIndex = 0;
            btnQLSV.Text = "Quản lý Sinh Viên";
            btnQLSV.UseVisualStyleBackColor = true;
            btnQLSV.Click += btnQLSV_Click;
            // 
            // btnQLGV
            // 
            btnQLGV.Font = new Font("Noto Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnQLGV.Location = new Point(145, 237);
            btnQLGV.Name = "btnQLGV";
            btnQLGV.Size = new Size(178, 60);
            btnQLGV.TabIndex = 1;
            btnQLGV.Text = "Quản lý Giảng Viên";
            btnQLGV.UseVisualStyleBackColor = true;
            btnQLGV.Click += btnQLGV_Click;
            // 
            // btnQLLH
            // 
            btnQLLH.Font = new Font("Noto Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnQLLH.Location = new Point(442, 108);
            btnQLLH.Name = "btnQLLH";
            btnQLLH.Size = new Size(178, 60);
            btnQLLH.TabIndex = 2;
            btnQLLH.Text = "Quản lý lớp học ";
            btnQLLH.UseVisualStyleBackColor = true;
            btnQLLH.Click += btnQLLH_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Fuchsia;
            label1.Location = new Point(290, 26);
            label1.Name = "label1";
            label1.Size = new Size(176, 33);
            label1.TabIndex = 3;
            label1.Text = "Quản Trị Viên";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Lime;
            btnExit.Location = new Point(674, 437);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(117, 57);
            btnExit.TabIndex = 24;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.OliveDrab;
            btnLogout.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.Gold;
            btnLogout.Location = new Point(504, 437);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(117, 57);
            btnLogout.TabIndex = 23;
            btnLogout.Text = "Log-out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // FormQuanTriVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 506);
            Controls.Add(btnExit);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Controls.Add(btnQLLH);
            Controls.Add(btnQLGV);
            Controls.Add(btnQLSV);
            Name = "FormQuanTriVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormQuanTriVien";
            FormClosing += FormQuanTriVien_FormClosing;
            FormClosed += FormQuanTriVien_FormClosed;
            Load += FormQuanTriVien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQLSV;
        private Button btnQLGV;
        private Button btnQLLH;
        private Label label1;
        private Button btnExit;
        private Button btnLogout;
    }
}