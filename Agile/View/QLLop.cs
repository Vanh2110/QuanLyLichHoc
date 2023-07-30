using Agile.Controller.Respository;
using Agile.Controller.Service;
using Agile.Model.DomainClass;
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

namespace Agile.View
{
    public partial class QLLop : Form
    {
        LopHocRepository _resLophoc = new LopHocRepository();
        LopHocService _service = new LopHocService();
        Guid _idWhenClick;
        public QLLop()
        {
            InitializeComponent();
            _resLophoc.GetLopHocs(null);
            LoadGrid(null);
            LoadComboBox();
        }
        public void LoadComboBox()
        {
            foreach (var s in _service.FakeData())
            {
                cmbxGiangVien.Items.Add(s);
            }
            cmbxGiangVien.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void LoadGrid(string input)
        {
            int stt = 1;
            dtgLopHoc.ColumnCount = 6;
            dtgLopHoc.Columns[0].Name = "STT";
            dtgLopHoc.Columns[1].Name = "ID";
            dtgLopHoc.Columns[2].Name = "Mã lớp";
            dtgLopHoc.Columns[3].Name = "Giảng viên";
            dtgLopHoc.Columns[4].Name = "Ngày bắt đầu";
            dtgLopHoc.Columns[5].Name = "Ngày kết thúc";
            dtgLopHoc.Rows.Clear();
            foreach (var item in _service.GetLopHocs(input))
            {
                dtgLopHoc.Rows.Add(stt++, item.IdLopHoc, item.MaLopHoc, item.MaGiangVien, item.NgayBatDau, item.NgayKetThuc);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LopHoc obj = new LopHoc();
            obj.MaLopHoc = txtMaLop.Text;
            obj.MaGiangVien = cmbxGiangVien.SelectedItem.ToString();
            obj.NgayBatDau = DateTime.Parse(txtBatDau.Text);
            obj.NgayKetThuc = DateTime.Parse(txtKetThuc.Text);
            //if (DateTime.TryParseExact(txtBatDau.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayBatDau))
            //{
            //    obj.NgayBatDau = ngayBatDau;
            //}
            //if (DateTime.TryParseExact(txtKetThuc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayKetThuc))
            //{
            //    obj.NgayKetThuc = ngayKetThuc;
            //}
            _service.ThemLopHoc(obj);
            LoadGrid(null);
        }


        private void btnQLTV_Click(object sender, EventArgs e)
        {
            QLTV qltv = new QLTV();
            qltv.Show();
            this.Hide();
        }

        private void QLLop_Load(object sender, EventArgs e)
        {

        }

        private void dtgLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            else
            {
                _idWhenClick = Guid.Parse(dtgLopHoc.Rows[rowIndex].Cells[1].Value.ToString());
                var obj = _service.GetLopHocs(null).FirstOrDefault(lh => lh.IdLopHoc == _idWhenClick);
                txtMaLop.Text = obj.MaLopHoc;
                txtBatDau.Text = obj.NgayBatDau.ToString();
                cmbxGiangVien.SelectedItem = obj.MaGiangVien;
                txtKetThuc.Text = obj.NgayKetThuc.ToString();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var obj = new LopHoc();
            obj.MaLopHoc = txtMaLop.Text;
            obj.MaGiangVien = cmbxGiangVien.SelectedItem.ToString();
            obj.NgayBatDau = DateTime.Parse(txtBatDau.Text);
            obj.NgayKetThuc = DateTime.Parse(txtKetThuc.Text);
            //if (DateTime.TryParseExact(txtBatDau.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayBatDau))
            //{
            //    obj.NgayBatDau = ngayBatDau;
            //}
            //if (DateTime.TryParseExact(txtKetThuc.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayKetThuc))
            //{
            //    obj.NgayKetThuc = ngayKetThuc;
            //}
            obj.IdLopHoc = _idWhenClick;
            _service.SuaLopHoc(obj);
            LoadGrid(null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _service.XoaLopHoc(_idWhenClick);
            LoadGrid(null);
        }
    }
}
