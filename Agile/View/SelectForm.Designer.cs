namespace Agile
{
    partial class SelectForm
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
            button1 = new Button();
            btnXem = new Button();
            btnQLLH = new Button();
            btnQLLop = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(173, 117);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "QLTV";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnQLTV_Click;
            // 
            // btnXem
            // 
            btnXem.Location = new Point(398, 117);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(94, 29);
            btnXem.TabIndex = 1;
            btnXem.Text = "Xem";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // btnQLLH
            // 
            btnQLLH.Location = new Point(173, 235);
            btnQLLH.Name = "btnQLLH";
            btnQLLH.Size = new Size(94, 29);
            btnQLLH.TabIndex = 2;
            btnQLLH.Text = "QLLH";
            btnQLLH.UseVisualStyleBackColor = true;
            btnQLLH.Click += btnQLLH_Click;
            // 
            // btnQLLop
            // 
            btnQLLop.Location = new Point(398, 235);
            btnQLLop.Name = "btnQLLop";
            btnQLLop.Size = new Size(94, 29);
            btnQLLop.TabIndex = 3;
            btnQLLop.Text = "QLLop";
            btnQLLop.UseVisualStyleBackColor = true;
            btnQLLop.Click += btnQLLop_Click;
            // 
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQLLop);
            Controls.Add(btnQLLH);
            Controls.Add(btnXem);
            Controls.Add(button1);
            Name = "SelectForm";
            Text = "SelectForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnXem;
        private Button btnQLLH;
        private Button btnQLLop;
    }
}