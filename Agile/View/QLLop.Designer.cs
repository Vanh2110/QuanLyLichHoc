namespace Agile.View
{
    partial class QLLop
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
            btnCapNhat = new Button();
            btnQLTV = new Button();
            btnXoa = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMaLop = new TextBox();
            txtBatDau = new TextBox();
            label3 = new Label();
            txtKetThuc = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbxGiangVien = new ComboBox();
            btnThem = new Button();
            dtgLopHoc = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgLopHoc).BeginInit();
            SuspendLayout();
            // 
            // btnCapNhat
            // 
            btnCapNhat.Location = new Point(229, 217);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(94, 29);
            btnCapNhat.TabIndex = 0;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = true;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnQLTV
            // 
            btnQLTV.Location = new Point(597, 217);
            btnQLTV.Name = "btnQLTV";
            btnQLTV.Size = new Size(150, 29);
            btnQLTV.TabIndex = 1;
            btnQLTV.Text = "Quản lý thành viên";
            btnQLTV.UseVisualStyleBackColor = true;
            btnQLTV.Click += btnQLTV_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(423, 217);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 21);
            label1.Name = "label1";
            label1.Size = new Size(239, 41);
            label1.TabIndex = 4;
            label1.Text = "Quản lý lớp học";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 102);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã lớp:";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(181, 95);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(166, 27);
            txtMaLop.TabIndex = 6;
            // 
            // txtBatDau
            // 
            txtBatDau.Location = new Point(181, 142);
            txtBatDau.Name = "txtBatDau";
            txtBatDau.Size = new Size(166, 27);
            txtBatDau.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 149);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 7;
            label3.Text = "Ngày bắt đầu:";
            // 
            // txtKetThuc
            // 
            txtKetThuc.Location = new Point(581, 142);
            txtKetThuc.Name = "txtKetThuc";
            txtKetThuc.Size = new Size(166, 27);
            txtKetThuc.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(456, 149);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 9;
            label4.Text = "Ngày kết thúc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 102);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 11;
            label5.Text = "Giảng viên:";
            // 
            // cmbxGiangVien
            // 
            cmbxGiangVien.FormattingEnabled = true;
            cmbxGiangVien.Location = new Point(581, 94);
            cmbxGiangVien.Name = "cmbxGiangVien";
            cmbxGiangVien.Size = new Size(166, 28);
            cmbxGiangVien.TabIndex = 12;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(64, 217);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += button5_Click;
            // 
            // dtgLopHoc
            // 
            dtgLopHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLopHoc.Location = new Point(56, 298);
            dtgLopHoc.Name = "dtgLopHoc";
            dtgLopHoc.RowHeadersWidth = 51;
            dtgLopHoc.RowTemplate.Height = 29;
            dtgLopHoc.Size = new Size(986, 264);
            dtgLopHoc.TabIndex = 14;
            dtgLopHoc.CellContentClick += dtgLopHoc_CellContentClick;
            // 
            // QLLop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 665);
            Controls.Add(dtgLopHoc);
            Controls.Add(btnThem);
            Controls.Add(cmbxGiangVien);
            Controls.Add(label5);
            Controls.Add(txtKetThuc);
            Controls.Add(label4);
            Controls.Add(txtBatDau);
            Controls.Add(label3);
            Controls.Add(txtMaLop);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnXoa);
            Controls.Add(btnQLTV);
            Controls.Add(btnCapNhat);
            Name = "QLLop";
            Text = "QLLop";
            Load += QLLop_Load;
            ((System.ComponentModel.ISupportInitialize)dtgLopHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCapNhat;
        private Button btnQLTV;
        private Button btnXoa;
        private Label label1;
        private Label label2;
        private TextBox txtMaLop;
        private TextBox txtBatDau;
        private Label label3;
        private TextBox txtKetThuc;
        private Label label4;
        private Label label5;
        private ComboBox cmbxGiangVien;
        private Button btnThem;
        private DataGridView dtgLopHoc;
    }
}