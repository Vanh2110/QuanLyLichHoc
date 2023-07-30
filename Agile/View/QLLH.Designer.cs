namespace Agile
{
    partial class QLLH
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
            label1 = new Label();
            label3 = new Label();
            txtGioKT = new TextBox();
            txtPhong = new TextBox();
            label2 = new Label();
            txtGioBD = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbxLop = new ComboBox();
            cmbxNgay = new ComboBox();
            label6 = new Label();
            btnXoaDL = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dtgLichHoc = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgLichHoc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(23, 19);
            label1.Name = "label1";
            label1.Size = new Size(242, 41);
            label1.TabIndex = 0;
            label1.Text = "Quản lý lịch học";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(837, 161);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Giờ kết thúc:";
            // 
            // txtGioKT
            // 
            txtGioKT.Location = new Point(933, 154);
            txtGioKT.Name = "txtGioKT";
            txtGioKT.Size = new Size(201, 27);
            txtGioKT.TabIndex = 3;
            // 
            // txtPhong
            // 
            txtPhong.Location = new Point(553, 85);
            txtPhong.Name = "txtPhong";
            txtPhong.Size = new Size(201, 27);
            txtPhong.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 92);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 4;
            label2.Text = "Phòng học:";
            // 
            // txtGioBD
            // 
            txtGioBD.Location = new Point(553, 154);
            txtGioBD.Name = "txtGioBD";
            txtGioBD.Size = new Size(201, 27);
            txtGioBD.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(457, 161);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 6;
            label4.Text = "Giờ bắt đầu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 92);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 8;
            label5.Text = "Lớp:";
            // 
            // cmbxLop
            // 
            cmbxLop.FormattingEnabled = true;
            cmbxLop.Location = new Point(177, 85);
            cmbxLop.Name = "cmbxLop";
            cmbxLop.Size = new Size(201, 28);
            cmbxLop.TabIndex = 9;
            // 
            // cmbxNgay
            // 
            cmbxNgay.FormattingEnabled = true;
            cmbxNgay.Location = new Point(177, 154);
            cmbxNgay.Name = "cmbxNgay";
            cmbxNgay.Size = new Size(201, 28);
            cmbxNgay.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 161);
            label6.Name = "label6";
            label6.Size = new Size(120, 20);
            label6.TabIndex = 10;
            label6.Text = "Ngày trong tuần:";
            // 
            // btnXoaDL
            // 
            btnXoaDL.Location = new Point(54, 243);
            btnXoaDL.Name = "btnXoaDL";
            btnXoaDL.Size = new Size(94, 29);
            btnXoaDL.TabIndex = 12;
            btnXoaDL.Text = "Xóa dữ liệu";
            btnXoaDL.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(246, 243);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 13;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(457, 243);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 14;
            btnSua.Text = "Cập nhật";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(660, 243);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // dtgLichHoc
            // 
            dtgLichHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgLichHoc.Location = new Point(54, 343);
            dtgLichHoc.Name = "dtgLichHoc";
            dtgLichHoc.RowHeadersWidth = 51;
            dtgLichHoc.RowTemplate.Height = 29;
            dtgLichHoc.Size = new Size(1080, 290);
            dtgLichHoc.TabIndex = 16;
            dtgLichHoc.CellContentClick += dtgLichHoc_CellContentClick;
            // 
            // QLLH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 686);
            Controls.Add(dtgLichHoc);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnXoaDL);
            Controls.Add(cmbxNgay);
            Controls.Add(label6);
            Controls.Add(cmbxLop);
            Controls.Add(label5);
            Controls.Add(txtGioBD);
            Controls.Add(label4);
            Controls.Add(txtPhong);
            Controls.Add(label2);
            Controls.Add(txtGioKT);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "QLLH";
            Text = "QLLH";
            Load += QLLH_Load;
            ((System.ComponentModel.ISupportInitialize)dtgLichHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtGioKT;
        private TextBox txtPhong;
        private Label label2;
        private TextBox txtGioBD;
        private Label label4;
        private Label label5;
        private ComboBox cmbxLop;
        private ComboBox cmbxNgay;
        private Label label6;
        private Button btnXoaDL;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dtgLichHoc;
    }
}