namespace Giao_Dien
{
    partial class FormDangNhap
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnLogin = new Button();
            txtPass = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            err = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Noto Sans", 13F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Highlight;
            groupBox1.Location = new Point(155, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightGoldenrodYellow;
            btnLogin.Font = new Font("Noto Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.DeepSkyBlue;
            btnLogin.Location = new Point(172, 214);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 51);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Noto Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(172, 142);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(218, 32);
            txtPass.TabIndex = 4;
            txtPass.UseSystemPasswordChar = true;
            txtPass.TextChanged += txtPass_TextChanged;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Noto Sans", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.Location = new Point(172, 81);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(218, 32);
            txtUser.TabIndex = 3;
            txtUser.TextChanged += txtUser_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(44, 142);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(44, 81);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // FormDangNhap
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 441);
            Controls.Add(groupBox1);
            Font = new Font("Noto Sans", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += FormDangNhap_FormClosed;
            Load += FormDangNhap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLogin;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label label2;
        private Label label1;
        private ErrorProvider err;
    }
}