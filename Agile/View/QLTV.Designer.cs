namespace Agile
{
    partial class QLTV
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMaLop = new TextBox();
            txtMaSV = new TextBox();
            txtTen = new TextBox();
            btnXoa = new Button();
            btnThem = new Button();
            dtgSinhVien = new DataGridView();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtSDT = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgSinhVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(44, 9);
            label1.Name = "label1";
            label1.Size = new Size(338, 41);
            label1.TabIndex = 0;
            label1.Text = "Quản lý thành viên lớp";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 88);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 128);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Mã SV:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 84);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Tên SV:";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(129, 81);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(205, 27);
            txtMaLop.TabIndex = 4;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(129, 121);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(205, 27);
            txtMaSV.TabIndex = 5;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(463, 81);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(205, 27);
            txtTen.TabIndex = 6;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(835, 124);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(185, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(835, 84);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(185, 29);
            btnThem.TabIndex = 8;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtgSinhVien
            // 
            dtgSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSinhVien.Location = new Point(64, 210);
            dtgSinhVien.Name = "dtgSinhVien";
            dtgSinhVien.RowHeadersWidth = 51;
            dtgSinhVien.RowTemplate.Height = 29;
            dtgSinhVien.Size = new Size(956, 230);
            dtgSinhVien.TabIndex = 9;
            dtgSinhVien.CellContentClick += dtgSinhVien_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 128);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 10;
            label5.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(463, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(205, 27);
            txtEmail.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 169);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 12;
            label6.Text = "SĐT:";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(129, 166);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(205, 27);
            txtSDT.TabIndex = 13;
            // 
            // QLTV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 660);
            Controls.Add(txtSDT);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label5);
            Controls.Add(dtgSinhVien);
            Controls.Add(btnThem);
            Controls.Add(btnXoa);
            Controls.Add(txtTen);
            Controls.Add(txtMaSV);
            Controls.Add(txtMaLop);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "QLTV";
            Text = "QLTV";
            ((System.ComponentModel.ISupportInitialize)dtgSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMaLop;
        private TextBox txtMaSV;
        private TextBox txtTen;
        private Button btnXoa;
        private Button btnThem;
        private DataGridView dtgSinhVien;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtSDT;
    }
}