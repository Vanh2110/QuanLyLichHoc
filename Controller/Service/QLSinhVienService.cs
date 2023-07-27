using Giao_Dien.Controller.Repository;
using Giao_Dien.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giao_Dien.Controller.Service
{
    internal class QLSinhVienService
    {
        QLSinhVienRepository _repos;
        public QLSinhVienService()
        {
            _repos = new QLSinhVienRepository();
        }
        public List<SinhVien> GetSinhVien(string input)
        {
            return _repos.GetSinhVien(input);
        }
        public void ThemSinhVien(SinhVien obj)
        {
            if (_repos.ThemSinhVien(obj) == true)
            {
                MessageBox.Show("Thêm thành công !");
            }
            else
            {
                MessageBox.Show("Thêm thất bại !");
            }
        } 
        public void CapNhatSinhVien(SinhVien obj)
        {
            var temp = _repos.GetSinhVien(null).FirstOrDefault(sv => sv.IdSinhVien == obj.IdSinhVien);
            //temp.MaSv = obj.MaSv;
            temp.Ten = obj.Ten;
            temp.Email = obj.Email;
            temp.Sdt = obj.Sdt;
            temp.GioiTinh = obj.GioiTinh;
            temp.DiaChi = obj.DiaChi;
            if (_repos.CapNhatSinhVien(temp) == true)
            {
                MessageBox.Show("Sửa thành công !");
            }
            else
            {
                MessageBox.Show("Sửa thất bại !");
            }
        }
        public void XoaSinhVien(Guid id)
        {
            var obj = _repos.GetSinhVien(null).FirstOrDefault(sv => sv.IdSinhVien == id);
            if (_repos.XoaSinhVien(obj) == true)
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
