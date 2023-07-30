using Agile.Controller.Respository;
using Agile.Controller.Service;
using Agile.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agile
{
    public partial class QLLH : Form
    {
        LichHocRepository _resLichHoc = new LichHocRepository();
        LichHocService _service = new LichHocService();
        Guid _idWhenClick;
        public QLLH()
        {
            InitializeComponent();
            _resLichHoc.GetLichHocs(null);
            LoadComboBox();
            LoadGrid(null);
        }
        public void LoadComboBox()
        {
            foreach (var item in _service.FakeDataLop())
            {
                cmbxLop.Items.Add(item);
            }
            foreach (var item in _service.FakeDataNgay())
            {
                cmbxNgay.Items.Add(item);
            }
        }
        public void LoadGrid(string input)
        {
            dtgLichHoc.ColumnCount = 6;
            dtgLichHoc.Columns[0].Name = "ID";
            dtgLichHoc.Columns[1].Name = "Lớp";
            dtgLichHoc.Columns[2].Name = "Ngày trong tuần";
            dtgLichHoc.Columns[3].Name = "Giờ bắt đầu";
            dtgLichHoc.Columns[4].Name = "Giờ kết thúc";
            dtgLichHoc.Columns[5].Name = "Phòng học";
            dtgLichHoc.Rows.Clear();
            foreach (var item in _service.GetLichHocs(input))
            {
                dtgLichHoc.Rows.Add(item.IdLopHoc, item.MaLopHoc, item.NgayTrongTuan, item.GioBatDau, item.GioKetThuc, item.Phong);
            }
        }

        private void QLLH_Load(object sender, EventArgs e)
        {

        }

        private void dtgLichHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            else
            {
                _idWhenClick = Guid.Parse(dtgLichHoc.Rows[rowIndex].Cells[0].Value.ToString());
                var obj = _service.GetLichHocs(null).FirstOrDefault(lh => lh.IdLopHoc == _idWhenClick);
                cmbxLop.SelectedItem = obj.MaLopHoc;
                cmbxNgay.SelectedItem = obj.NgayTrongTuan;
                txtPhong.Text = obj.Phong;
                txtGioBD.Text = obj.GioBatDau.ToString();
                txtGioKT.Text = obj.GioKetThuc.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LichHoc obj = new LichHoc();
            obj.MaLopHoc = cmbxLop.ToString();
            obj.NgayTrongTuan = cmbxNgay.SelectedItem.ToString();
            obj.Phong = txtPhong.Text;
            if (TimeSpan.TryParse(txtGioBD.Text, out TimeSpan gioBatDau))
            {
                obj.GioBatDau = gioBatDau;
            }
            if (TimeSpan.TryParse(txtGioKT.Text, out TimeSpan gioKetThuc))
            {
                obj.GioBatDau = gioKetThuc;
            }
            _service.ThemLichHoc(obj);
            LoadGrid(null);
        }
    }
}
