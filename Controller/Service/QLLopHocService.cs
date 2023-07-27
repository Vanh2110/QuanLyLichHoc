using Giao_Dien.Controller.Repository;
using Giao_Dien.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Giao_Dien.Controller.Service
{
    internal class QLLopHocService
    {
        QLLopHocRepository _repos;
        public QLLopHocService()
        {
            _repos = new QLLopHocRepository();  
        }
        public List<LopHoc> GetLopHoc(string input)
        {
            return _repos.GetLopHoc(input);
        }
        public List<string> FakeData()
        {
            var data = new List<string>();
            data.Add("FE123");
            data.Add("huyennk6");
            data.Add("linhdt5");
            return data;
        }
        public void ThemLopHoc(LopHoc obj)
        {
            if(_repos.ThemLopHoc(obj) == true)
            {
                MessageBox.Show("Thêm thành công !");
            }
            else
            {
                MessageBox.Show("Thêm thất bại !");
            }
        }
        public void CapNhatLopHoc(LopHoc obj)
        {
            var temp = _repos.GetLopHoc(null).FirstOrDefault(lh => lh.IdLopHoc == obj.IdLopHoc);           
            temp.MaLopHoc = obj.MaLopHoc;
            temp.Ten = obj.Ten;
            temp.MaGiangVien = obj.MaGiangVien;
            temp.NgayBatDau = obj.NgayBatDau;
            temp.NgayKetThuc = obj.NgayKetThuc;
            if (_repos.CapNhatLopHoc(temp) == true)
            {
                MessageBox.Show("Cập nhật thành công !");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại !");
            }
        }
        public void XoaLopHoc(Guid IDlh)
        {
            var obj = _repos.GetLopHoc(null).FirstOrDefault(lh => lh.IdLopHoc == IDlh);
            if (_repos.XoaLopHoc(obj) == true)
            {
                MessageBox.Show("Xóa thành công !");
            }
            else
            {
                MessageBox.Show("Xóa thất bại !");
            }
        }
    }
}
