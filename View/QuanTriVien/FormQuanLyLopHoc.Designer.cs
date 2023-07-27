namespace Giao_Dien.View
{
    partial class FormQuanLyLopHoc
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
            groupBox1 = new GroupBox();
            txtMonHoc = new TextBox();
            txt = new Label();
            btnQLTV = new Button();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnXoaDL = new Button();
            btnThem = new Button();
            cmbxMaGiangVien = new ComboBox();
            txtNgayKT = new TextBox();
            txtNgayBD = new TextBox();
            txtMaLop = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtgDSLopHoc = new DataGridView();
            btnThoat = new Button();
            btnDangXuat = new Button();
            btnQuayLai = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDSLopHoc).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMonHoc);
            groupBox1.Controls.Add(txt);
            groupBox1.Controls.Add(btnQLTV);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnCapNhat);
            groupBox1.Controls.Add(btnXoaDL);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(cmbxMaGiangVien);
            groupBox1.Controls.Add(txtNgayKT);
            groupBox1.Controls.Add(txtNgayBD);
            groupBox1.Controls.Add(txtMaLop);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(67, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(901, 315);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtMonHoc
            // 
            txtMonHoc.Location = new Point(587, 35);
            txtMonHoc.Name = "txtMonHoc";
            txtMonHoc.Size = new Size(180, 28);
            txtMonHoc.TabIndex = 29;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(440, 38);
            txt.Name = "txt";
            txt.Size = new Size(78, 20);
            txt.TabIndex = 28;
            txt.Text = "Môn học :";
            // 
            // btnQLTV
            // 
            btnQLTV.Font = new Font("Noto Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnQLTV.Location = new Point(729, 227);
            btnQLTV.Name = "btnQLTV";
            btnQLTV.Size = new Size(131, 59);
            btnQLTV.TabIndex = 27;
            btnQLTV.Text = "Quản lý thành viên";
            btnQLTV.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Yellow;
            btnXoa.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(207, 225);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 59);
            btnXoa.TabIndex = 26;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.SkyBlue;
            btnCapNhat.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnCapNhat.ForeColor = SystemColors.ControlLightLight;
            btnCapNhat.Location = new Point(378, 227);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(117, 57);
            btnCapNhat.TabIndex = 25;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnXoaDL
            // 
            btnXoaDL.BackColor = Color.FromArgb(255, 192, 128);
            btnXoaDL.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaDL.ForeColor = Color.Navy;
            btnXoaDL.Location = new Point(559, 226);
            btnXoaDL.Name = "btnXoaDL";
            btnXoaDL.Size = new Size(117, 57);
            btnXoaDL.TabIndex = 24;
            btnXoaDL.Text = "Xóa DL";
            btnXoaDL.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.MenuHighlight;
            btnThem.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.GreenYellow;
            btnThem.Location = new Point(30, 225);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(117, 59);
            btnThem.TabIndex = 23;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // cmbxMaGiangVien
            // 
            cmbxMaGiangVien.FormattingEnabled = true;
            cmbxMaGiangVien.Location = new Point(183, 89);
            cmbxMaGiangVien.Name = "cmbxMaGiangVien";
            cmbxMaGiangVien.Size = new Size(180, 28);
            cmbxMaGiangVien.TabIndex = 8;
            // 
            // txtNgayKT
            // 
            txtNgayKT.Location = new Point(587, 138);
            txtNgayKT.Name = "txtNgayKT";
            txtNgayKT.Size = new Size(180, 28);
            txtNgayKT.TabIndex = 7;
            // 
            // txtNgayBD
            // 
            txtNgayBD.Location = new Point(183, 138);
            txtNgayBD.Name = "txtNgayBD";
            txtNgayBD.Size = new Size(180, 28);
            txtNgayBD.TabIndex = 5;
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(183, 38);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(180, 28);
            txtMaLop.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 138);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày kết thúc :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 92);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 2;
            label5.Text = "Mã Giảng Viên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 146);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 1;
            label3.Text = "Ngày Bắt Đầu :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 38);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã lớp :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(393, 48);
            label1.Name = "label1";
            label1.Size = new Size(216, 33);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Lớp Học";
            // 
            // dtgDSLopHoc
            // 
            dtgDSLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDSLopHoc.Dock = DockStyle.Bottom;
            dtgDSLopHoc.Location = new Point(0, 452);
            dtgDSLopHoc.Name = "dtgDSLopHoc";
            dtgDSLopHoc.RowHeadersWidth = 51;
            dtgDSLopHoc.RowTemplate.Height = 29;
            dtgDSLopHoc.Size = new Size(1134, 222);
            dtgDSLopHoc.TabIndex = 2;
            dtgDSLopHoc.CellContentClick += dtgDanhSachLH_CellContentClick;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.Transparent;
            btnThoat.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.Lime;
            btnThoat.Location = new Point(954, 12);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(117, 57);
            btnThoat.TabIndex = 28;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.OliveDrab;
            btnDangXuat.Font = new Font("Noto Sans", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.ForeColor = Color.Gold;
            btnDangXuat.Location = new Point(796, 12);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(117, 57);
            btnDangXuat.TabIndex = 27;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = SystemColors.MenuHighlight;
            btnQuayLai.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            btnQuayLai.ForeColor = SystemColors.HighlightText;
            btnQuayLai.Location = new Point(12, 12);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(101, 33);
            btnQuayLai.TabIndex = 29;
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // FormQuanLyLopHoc
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 674);
            Controls.Add(btnQuayLai);
            Controls.Add(btnThoat);
            Controls.Add(dtgDSLopHoc);
            Controls.Add(btnDangXuat);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Noto Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormQuanLyLopHoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormQuanLyLopHoc";
            FormClosing += FormQuanLyLopHoc_FormClosing;
            FormClosed += FormQuanLyLopHoc_FormClosed;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDSLopHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbxMaGiangVien;
        private TextBox txtNgayKT;
        private TextBox txtNgayBD;
        private TextBox txtMaLop;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtgDSLopHoc;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnXoaDL;
        private Button btnThem;
        private Button btnThoat;
        private Button btnDangXuat;
        private Button btnQLTV;
        private Button btnQuayLai;
        private TextBox txtMonHoc;
        private Label txt;
    }
}