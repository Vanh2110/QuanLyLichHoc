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
    public partial class FormQuanLyLopHoc : Form
    {
        bool isExit = true;
        QLLopHocService _service = new QLLopHocService();
        Guid _IDWC;
        public FormQuanLyLopHoc()
        {
            InitializeComponent();
            LoadCombobox();
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
        public void LoadCombobox()
        {
            foreach (var item in _service.FakeData())
            {
                cmbxGiangVien.Items.Add(item);
            }
            cmbxGiangVien.SelectedIndex = -1;
            cmbxGiangVien.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void LoadGrid(string input)
        {
            int stt = 1;
            Type t = typeof(LopHoc);

            int slThuocTinh = t.GetProperties().Length;
            dtgDanhSachLH.ColumnCount = slThuocTinh + 1;
            dtgDanhSachLH.Columns[0].Name = "STT";
            dtgDanhSachLH.Columns[1].Name = "ID";
            dtgDanhSachLH.Columns[2].Name = "Mã lớp";
            dtgDanhSachLH.Columns[3].Name = "Giảng viên";
            dtgDanhSachLH.Columns[4].Name = "Ngày bắt đầu";
            dtgDanhSachLH.Columns[5].Name = "Ngày kết thúc";

            dtgDanhSachLH.Rows.Clear();
            foreach (var item in _service.GetLopHoc(input))
            {
                dtgDanhSachLH.Rows.Add(stt++, item.IdLopHoc, item.Ten, item.MaLopHoc, item.NgayBatDau, item.NgayKetThuc);
            }
        }

    }
}
