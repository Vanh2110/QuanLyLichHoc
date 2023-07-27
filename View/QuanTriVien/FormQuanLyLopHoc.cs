using Giao_Dien.Controller.Repository;
using Giao_Dien.Controller.Service;
using Giao_Dien.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Giao_Dien.View
{
    public partial class FormQuanLyLopHoc : Form
    {
        bool isExit = true;
        QLLopHocRepository _repos = new QLLopHocRepository();
        QLLopHocService _service = new QLLopHocService();
        Guid _IDWC;
        public FormQuanLyLopHoc()
        {
            InitializeComponent();
            LoadCombobox();
            _service.GetLopHoc(null);
            LoadGrid(null);
        }
        private void FormQuanLyLopHoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }
        private void FormQuanLyLopHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông báo ", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            isExit = false;
            this.Close();
            FormDangNhap fDN = new FormDangNhap();
            fDN.Show();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FormQuanTriVien fQTV = new FormQuanTriVien();
            fQTV.Show();
            this.Hide();
        }
        public void LoadCombobox()
        {
            foreach (var item in _service.FakeData())
            {
                cmbxMaGiangVien.Items.Add(item);
            }
            cmbxMaGiangVien.SelectedIndex = -1;
            cmbxMaGiangVien.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void LoadGrid(string input)
        {
            int stt = 1;
            Type t = typeof(LopHoc);

            int slThuocTinh = t.GetProperties().Length;
            dtgDSLopHoc.ColumnCount = slThuocTinh + 1;
            dtgDSLopHoc.Columns[0].Name = "STT";
            dtgDSLopHoc.Columns[1].Name = "ID";
            dtgDSLopHoc.Columns[2].Name = "Mã lớp";
            dtgDSLopHoc.Columns[3].Name = "Môn học";
            dtgDSLopHoc.Columns[4].Name = "Mã Giảng viên";
            dtgDSLopHoc.Columns[5].Name = "Ngày bắt đầu";
            dtgDSLopHoc.Columns[6].Name = "Ngày kết thúc";

            dtgDSLopHoc.Rows.Clear();
            foreach (var item in _service.GetLopHoc(input))
            {
                dtgDSLopHoc.Rows.Add(stt++, item.IdLopHoc, item.MaLopHoc, item.Ten, item.MaGiangVien, item.NgayBatDau, item.NgayKetThuc);
            }
        }

        private void dtgDanhSachLH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            else
            {
                _IDWC = Guid.Parse(dtgDSLopHoc.Rows[rowIndex].Cells[1].Value.ToString());
                var obj = _service.GetLopHoc(null).FirstOrDefault(lh => lh.IdLopHoc == _IDWC);

                txtMaLop.Text = obj.MaLopHoc;
                txtMonHoc.Text = obj.Ten;
                cmbxMaGiangVien.SelectedItem = obj.MaGiangVien;
                txtNgayBD.Text = obj.NgayBatDau.ToString();
                txtNgayKT.Text = obj.NgayKetThuc.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LopHoc obj = new LopHoc();
            obj.MaLopHoc = txtMaLop.Text;
            obj.Ten = txtMonHoc.Text;
            obj.MaGiangVien = cmbxMaGiangVien.SelectedItem.ToString();
            //if (DateTime.TryParseExact(txtNgayBD.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayBatDau))
            //{
            //    obj.NgayBatDau = ngayBatDau;
            //}
            //obj.NgayBatDau = Convert.ToDateTime(ngayBatDau);
            //if (DateTime.TryParseExact(txtNgayKT.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayKetThuc))
            //{
            //    obj.NgayKetThuc = ngayKetThuc;
            //}
            
           obj.NgayBatDau = DateTime.Parse(txtNgayBD.Text);
           obj.NgayKetThuc = DateTime.Parse(txtNgayKT.Text);

            _service.ThemLopHoc(obj);
            LoadGrid(null);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var obj = new LopHoc();
            obj.MaLopHoc = txtMaLop.Text;
            obj.Ten = txtMonHoc.Text;
            obj.MaGiangVien = cmbxMaGiangVien.SelectedItem.ToString();
            obj.NgayBatDau = DateTime.Parse(txtNgayBD.Text);
            obj.NgayKetThuc = DateTime.Parse(txtNgayKT.Text);

            obj.IdLopHoc = _IDWC;
            _service.CapNhatLopHoc(obj);
            LoadGrid(null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _service.XoaLopHoc(_IDWC);
            LoadGrid(null);
        }

    }
}
