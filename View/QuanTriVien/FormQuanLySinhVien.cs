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
    public partial class FormQuanLySinhVien : Form
    {
        bool isExit = true;
        QLSinhVienRepository _repos = new QLSinhVienRepository();
        QLSinhVienService _service = new QLSinhVienService();
        Guid _IDWC;

        public FormQuanLySinhVien()
        {
            InitializeComponent();
            _service.GetSinhVien(null);
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
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormQuanTriVien fQTV = new FormQuanTriVien();
            fQTV.Show();
            this.Hide();
        }
        public void LoadGrid(string input)
        {
            int stt = 1;
            dtgDSSinhVien.ColumnCount = 8;
            dtgDSSinhVien.Columns[0].Name = "STT";
            dtgDSSinhVien.Columns[1].Name = "ID";
            dtgDSSinhVien.Columns[2].Name = "Mã sinh viên";
            dtgDSSinhVien.Columns[3].Name = "Tên";
            dtgDSSinhVien.Columns[4].Name = "Email";
            dtgDSSinhVien.Columns[5].Name = "SĐT";
            dtgDSSinhVien.Columns[6].Name = "Giới tính";
            dtgDSSinhVien.Columns[7].Name = "Địa chỉ";

            dtgDSSinhVien.Rows.Clear();
            foreach (var item in _service.GetSinhVien(input))
            {
                dtgDSSinhVien.Rows.Add(stt++, item.IdSinhVien, item.MaSv, item.Ten, item.Email, item.Sdt, (item.GioiTinh == true ? "Nam" : "Nữ"), item.DiaChi);
            }
        }
        private void dtgDSSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            else
            {
                _IDWC = Guid.Parse(dtgDSSinhVien.Rows[rowIndex].Cells[1].Value.ToString());
                var obj = _service.GetSinhVien(null).FirstOrDefault(sv => sv.IdSinhVien == _IDWC);

                txtMaSV.Text = obj.MaSv;
                txtTen.Text = obj.Ten;
                txtEmail.Text = obj.Email;
                txtSDT.Text = obj.Sdt;
                if (obj.GioiTinh == true)
                {
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
            SinhVien obj = new SinhVien();
            obj.MaSv = txtMaSV.Text;
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

            _service.ThemSinhVien(obj);
            LoadGrid(null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var obj = new SinhVien();
            obj.MaSv = txtMaSV.Text;
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
            obj.IdSinhVien = _IDWC;
            _service.CapNhatSinhVien(obj);
            LoadGrid(null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _service.XoaSinhVien(_IDWC);
            LoadGrid(null);
        }

        private void btnXoaDL_Click(object sender, EventArgs e)
        {

        }
    }
}
