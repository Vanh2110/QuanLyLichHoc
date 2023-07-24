using Giao_Dien.Model.DomainClass;
using Giao_Dien.View;
using System.Collections.Generic;

namespace Giao_Dien
{
    public partial class FormDangNhap : Form
    {
        bool isExit = true;
        List<NguoiDung> _lstNguoiDung = DanhSachNguoiDung.Instance.LstNguoiDung;

        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtPass.Text, txtPass.Text))
            {
                MessageBox.Show("Đăng nhập thành công !", "Thông Báo");
                switch (Const.NguoiDung.LoaiNguoiDung1)
                {
                    case NguoiDung.LoaiND.admin:
                        FormQuanTriVien fQTV = new FormQuanTriVien();
                        fQTV.ShowDialog();
                        this.Hide();
                        break;
                    case NguoiDung.LoaiND.sinhvien:


                        break;
                    case NguoiDung.LoaiND.giangvien:


                        break;
                }
            }
            else if (txtUser.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Username và password không được để trống !", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sai username hoặc password !", "Thông Báo ");
                txtUser.Focus();
            }
        }

        bool KiemTraDangNhap(string username, string password)
        {
            for (int i = 0; i < _lstNguoiDung.Count; i++)
            {
                if (username == _lstNguoiDung[i].Username && password == _lstNguoiDung[i].Passsword)
                {
                    Const.NguoiDung = _lstNguoiDung[i];
                    return true;
                }
            }
            return false;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}