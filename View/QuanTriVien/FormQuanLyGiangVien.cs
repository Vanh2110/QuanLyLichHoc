using Giao_Dien.Controller.Repository;
using Giao_Dien.Controller.Service;
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
    public partial class FormQuanLyGiangVien : Form
    {
        bool isExit = true;
        QLGiangVienRepository _repos = new QLGiangVienRepository();
        QLGiangVienService _service = new QLGiangVienService();
        Guid _IDWC;
        public FormQuanLyGiangVien()
        {
            InitializeComponent();
            _service.GetGiangVien(null);
            LoadGrid(null);
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
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormQuanTriVien fQTV = new FormQuanTriVien();
            fQTV.Show();
            this.Hide();
        }
        public void LoadGrid(string input)
        {

            int stt = 1;
            dtgDSGV.ColumnCount = 8;
            dtgDSGV.Columns[0].Name = "STT";
            dtgDSGV.Columns[1].Name = "ID";
            dtgDSGV.Columns[2].Name = "Mã giảng viên";
            dtgDSGV.Columns[3].Name = "Họ tên";
            dtgDSGV.Columns[4].Name = "Email";
            dtgDSGV.Columns[5].Name = "Sđt";
            dtgDSGV.Columns[6].Name = "Giới tính";
            dtgDSGV.Columns[7].Name = "Địa chỉ";

            dtgDSGV.Rows.Clear();
            foreach (var item in _service.GetGiangVien(input))
            {
                dtgDSGV.Rows.Add(stt++, item.IdGiangVien, item.MaGiangVien, item.Ten, item.Email, item.Sdt, (item.GioiTinh == true ? "Nam" : "Nữ"), item.DiaChi);
            }
        }

        private void dtgDSGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            else
            {
                _IDWC = Guid.Parse(dtgDSGV.Rows[rowIndex].Cells[1].Value.ToString());
                var obj = _service.GetGiangVien(null).FirstOrDefault(gv => gv.IdGiangVien == _IDWC);

                txtMaGV.Text = obj.MaGiangVien;
                txtTen.Text = obj.Ten;
                txtEmail.Text = obj.Email;
                txtSDT.Text = obj.Sdt;
                if (obj.GioiTinh == true)
                {
                    // btn Nam được chọn 
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                rtbDiaChi.Text = obj.DiaChi;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GiangVien obj = new GiangVien();
            obj.MaGiangVien = txtMaGV.Text;
            obj.Ten = txtTen.Text;
            obj.Email = txtEmail.Text;
            obj.Sdt = txtSDT.Text;
            if (radNam.Checked)
            {
                obj.GioiTinh = true;
            }
            else
            {
                obj.GioiTinh = false;
            }
            obj.DiaChi = rtbDiaChi.Text;
            _service.ThemGiangVien(obj);
            LoadGrid(null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var obj = new GiangVien();
            obj.MaGiangVien = txtMaGV.Text;
            obj.Ten = txtTen.Text;
            obj.Email = txtEmail.Text;
            obj.Sdt = txtSDT.Text;
            if (radNam.Checked)
            {
                obj.GioiTinh = true;
            }
            else
            {
                obj.GioiTinh = false;
            }
            obj.DiaChi = rtbDiaChi.Text;

            obj.IdGiangVien = _IDWC;

            _service.CapNhatGiangVien(obj);
            LoadGrid(null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _service.XoaGiangVien(_IDWC);
            LoadGrid(null);
        }

    }
}
