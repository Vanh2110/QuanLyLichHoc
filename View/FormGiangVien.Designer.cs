namespace Giao_Dien
{
    partial class FormGiangVien
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
            groupBox1 = new GroupBox();
            dtgDSLichDay = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDSLichDay).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(361, 45);
            label1.Name = "label1";
            label1.Size = new Size(136, 33);
            label1.TabIndex = 0;
            label1.Text = "Giảng Viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgDSLichDay);
            groupBox1.Location = new Point(80, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(681, 280);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lịch học 7 ngày tới";
            // 
            // dtgDSLichDay
            // 
            dtgDSLichDay.BackgroundColor = SystemColors.ActiveCaption;
            dtgDSLichDay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDSLichDay.Dock = DockStyle.Fill;
            dtgDSLichDay.GridColor = SystemColors.ButtonHighlight;
            dtgDSLichDay.Location = new Point(3, 24);
            dtgDSLichDay.Name = "dtgDSLichDay";
            dtgDSLichDay.RowHeadersWidth = 51;
            dtgDSLichDay.RowTemplate.Height = 29;
            dtgDSLichDay.Size = new Size(675, 253);
            dtgDSLichDay.TabIndex = 0;
            dtgDSLichDay.CellContentClick += dtgDSLichHoc_CellContentClick;
            // 
            // FormGiangVien
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 490);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Noto Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormGiangVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormGiangVien";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDSLichDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dtgDSLichDay;
    }
}