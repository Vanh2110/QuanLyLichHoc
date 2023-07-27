using Giao_Dien.Controller.Service;
using Giao_Dien.Model.DomainClass;
using Giao_Dien.View;
using System.Collections.Generic;

namespace Giao_Dien
{
    public partial class FormDangNhap : Form
    {
        bool isExit = true;
        NguoiDungService _NDservice = new NguoiDungService();
        //List<NguoiDung> _lstNguoiDung = DanhSachNguoiDung.Instance.LstNguoiDung;

        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string TKDN = txtUser.Text;
            string MKDN = txtPass.Text;

            string loaiTK = _NDservice.KiemTraNguoiDung(TKDN, MKDN);


            if (loaiTK != null)
            {
                if (loaiTK.Equals("Quản trị viên"))
                {
                    MessageBox.Show("Đăng nhập thành công ", "Thông báo !");

                    FormQuanTriVien fQTV = new FormQuanTriVien();
                    fQTV.Show();
                    this.Hide();
                }
                else if (loaiTK.Equals("Giảng viên"))
                {
                    MessageBox.Show("Đăng nhập thành công ", "Thông báo !");

                    FormGiangVien fGV = new FormGiangVien();
                    fGV.Show();
                    this.Hide();
                }
                else if (loaiTK.Equals("Sinh viên"))
                {
                    MessageBox.Show("Đăng nhập thành công ", "Thông báo !");

                    FormSinhVien fSV = new FormSinhVien();
                    fSV.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }


    }
}