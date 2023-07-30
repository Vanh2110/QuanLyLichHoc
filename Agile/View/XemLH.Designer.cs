namespace Agile.View
{
    partial class XemLH
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
            dtgXemLH = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgXemLH).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(282, 41);
            label1.TabIndex = 0;
            label1.Text = "Lịch học 7 ngày tới";
            // 
            // dtgXemLH
            // 
            dtgXemLH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgXemLH.Location = new Point(27, 112);
            dtgXemLH.Name = "dtgXemLH";
            dtgXemLH.RowHeadersWidth = 51;
            dtgXemLH.RowTemplate.Height = 29;
            dtgXemLH.Size = new Size(1085, 380);
            dtgXemLH.TabIndex = 1;
            dtgXemLH.CellContentClick += dtgXemLH_CellContentClick;
            // 
            // XemLH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 736);
            Controls.Add(dtgXemLH);
            Controls.Add(label1);
            Name = "XemLH";
            Text = "XemLH";
            ((System.ComponentModel.ISupportInitialize)dtgXemLH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgXemLH;
    }
}