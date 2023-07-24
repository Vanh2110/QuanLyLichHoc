using Giao_Dien.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_Dien.View
{
    public partial class FormQuanLySinhVien : Form
    {
        bool isExit = true;
        public FormQuanLySinhVien()
        {
            InitializeComponent();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Close();
            FormDangNhap fDN = new FormDangNhap();
            fDN.Show();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
        private void FormQuanLySinhVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
        private void FormQuanLySinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo ", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
