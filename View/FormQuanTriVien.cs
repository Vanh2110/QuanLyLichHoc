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
    public partial class FormQuanTriVien : Form
    {
        bool isExit = true;
        public FormQuanTriVien()
        {
            InitializeComponent();
        }
        private void FormQuanTriVien_Load(object sender, EventArgs e)
        {

        }
        private void FormQuanTriVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (isExit)
            {
                MessageBox.Show("Bạn muốn thoát khỏi chương trình không ?", "Thông báo ", MessageBoxButtons.YesNo);
                Application.Exit();
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Close();
            FormDangNhap fDN = new FormDangNhap();
            fDN.Show();
        }
        private void btnQLSV_Click(object sender, EventArgs e)
        {
            FormQuanLySinhVien fQLSV = new FormQuanLySinhVien();
            fQLSV.Show();
            this.Hide();
        }
        private void btnQLGV_Click(object sender, EventArgs e)
        {
            FormQuanLyGiangVien fQLGV = new FormQuanLyGiangVien();
            fQLGV.Show();
            this.Hide();
        }
        private void btnQLLH_Click(object sender, EventArgs e)
        {
            FormQuanLyLopHoc fQLLH = new FormQuanLyLopHoc();
            fQLLH.Show();
            this.Hide();
        }       
        private void FormQuanTriVien_FormClosing(object sender, FormClosingEventArgs e)
        {

        }     
    }
}
