using Agile.Controller.Respository;
using Agile.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Controller.Service
{
    internal class LichHocService
    {
        LichHocRepository _repos;
        public LichHocService()
        {
            _repos = new LichHocRepository();
        }
        public List<string> FakeDataLop()
        {
            var data = new List<string>();
            data.Add("SD18301");
            data.Add("SD18308");
            return data;
        }
        public List<string> FakeDataNgay()
        {
            var data = new List<string>();
            data.Add("Thứ 2");
            data.Add("Thứ 3");
            data.Add("Thứ 4");
            data.Add("Thứ 5");
            data.Add("Thứ 6");
            data.Add("Thứ 7");
            return data;
        }
        public void ThemLichHoc(LichHoc obj)
        {
            if (_repos.AddLichHoc(obj) == true)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void SuaLichHoc(LichHoc obj)
        {
            var temp = _repos.GetLichHocs(null).FirstOrDefault(lh => lh.MaLopHoc == obj.MaLopHoc);
            temp.MaLopHoc = obj.MaLopHoc;
            temp.Phong = obj.Phong;
            temp.NgayTrongTuan = obj.NgayTrongTuan;
            temp.GioBatDau = obj.GioBatDau;
            temp.GioKetThuc = obj.GioKetThuc;
            if (_repos.UpdateLichHoc(temp) == true)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
        public void XoaLichHoc(Guid guidID)
        {
            var obj = _repos.GetLichHocs(null).FirstOrDefault(lh => lh.IdLopHoc ==guidID);
            if (_repos.DeleteLichHoc(obj) == true)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        public List<LichHoc> GetLichHocs(string input)
        {
            return _repos.GetLichHocs(input);
        }
    }
}
