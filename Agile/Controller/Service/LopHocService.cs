using Agile.Controller.Respository;
using Agile.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Controller.Service
{
    internal class LopHocService
    {
        LopHocRepository _repos;
        public LopHocService()
        {
            _repos = new LopHocRepository();
        }
        public List<string> FakeData()
        {
            var data = new List<string>();
            data.Add("FE123");
            data.Add("FE123");
            data.Add("FE123");
            return data;
        }
        public void ThemLopHoc(LopHoc obj)
        {
            if (_repos.AddLopHoc(obj)==true)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void SuaLopHoc(LopHoc obj)
        {
            var temp = _repos.GetLopHocs(null).FirstOrDefault(lh => lh.IdLopHoc == obj.IdLopHoc);
            temp.MaLopHoc = obj.MaLopHoc;
            temp.MaGiangVien = obj.MaGiangVien;
            temp.NgayBatDau = obj.NgayBatDau;
            temp.NgayKetThuc = obj.NgayKetThuc;
            if (_repos.UpdateLopHoc(temp) == true)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }
        public void XoaLopHoc(Guid guidID)
        {
            var obj = _repos.GetLopHocs(null).FirstOrDefault(lh => lh.IdLopHoc == guidID);
            if (_repos.DeleteLopHoc(obj) == true)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        public List<LopHoc> GetLopHocs(string input)
        {
            return _repos.GetLopHocs(input);
        }
    }
}
