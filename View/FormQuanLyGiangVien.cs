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
    public partial class FormQuanLyGiangVien : Form
    {
        bool isExit = true;
        public FormQuanLyGiangVien()
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
        private void FormQuanLyGiangVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }

        private void FormQuanLyGiangVien_FormClosing(object sender, FormClosingEventArgs e)
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
