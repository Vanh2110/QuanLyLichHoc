using Agile.Controller.Respository;
using Agile.Controller.Service;
using Agile.Model.DomainClass;

namespace Agile
{
    public partial class QLTV : Form
    {
        SinhVienRespository _resSinhVien = new SinhVienRespository();
        SinhVienService _service = new SinhVienService();
        Guid _idWhenClick;
        bool isExit = true;
        public QLTV()
        {
            InitializeComponent();
            txtMaLop.Text = "SD18301";
            _resSinhVien.GetSinhViens(null);
            LoadGrid(null);
        }
        public void LoadGrid(string input)
        {
            int stt = 1;
            dtgSinhVien.ColumnCount = 6;
            dtgSinhVien.Columns[0].Name = "STT";
            dtgSinhVien.Columns[1].Name = "ID";
            dtgSinhVien.Columns[2].Name = "Mã SV";
            dtgSinhVien.Columns[3].Name = "Họ tên";
            dtgSinhVien.Columns[4].Name = "Email";
            dtgSinhVien.Columns[5].Name = "SĐT";
            dtgSinhVien.Rows.Clear();
            foreach (var item in _service.GetSinhViens(input))
            {
                dtgSinhVien.Rows.Add(stt++, item.IdSinhVien, item.MaSv, item.Ten, item.Email, item.Sdt);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien obj = new SinhVien();
            obj.MaSv = txtMaSV.Text;
            obj.Ten = txtTen.Text;
            obj.Email = txtEmail.Text;
            obj.Sdt = txtSDT.Text;
            _service.ThemSV(obj);
            LoadGrid(null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _service.XoaSV(_idWhenClick);
            LoadGrid(null);
        }

        private void dtgSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex < 0)
            {
                return;
            }
            else
            {
                _idWhenClick = Guid.Parse(dtgSinhVien.Rows[rowIndex].Cells[1].Value.ToString());
                var obj = _service.GetSinhViens(null).FirstOrDefault(sv => sv.IdSinhVien == _idWhenClick);
                txtMaSV.Text = obj.MaSv;
                txtEmail.Text = obj.Email;
                txtTen.Text = obj.Ten;
                txtSDT.Text = obj.Sdt;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                Application.Exit();
            }
        }
    }
}