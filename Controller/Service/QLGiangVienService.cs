using Accessibility;
using Giao_Dien.Controller.Repository;
using Giao_Dien.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giao_Dien.Controller.Service
{
    internal class QLGiangVienService
    {
        QLGiangVienRepository _repos = new QLGiangVienRepository();
        public QLGiangVienService()
        {
            _repos = new QLGiangVienRepository();
        }
        public List<GiangVien> GetGiangVien(string input)
        {
            return _repos.GetGiangVien(input);
        }
        public void ThemGiangVien(GiangVien obj)
        {
            if(_repos.ThemGiangVien(obj) == true)
            {
                MessageBox.Show("Thêm thành công !");
            }
            else
            {
                MessageBox.Show("Thêm thất bại !");
            }
        }
        public void CapNhatGiangVien(GiangVien obj)
        {
            var temp = _repos.GetGiangVien(null).FirstOrDefault(gv => gv.IdGiangVien == gv.IdGiangVien);
            temp.MaGiangVien = obj.MaGiangVien;
            temp.Ten = obj.Ten;
            temp.Email = obj.Email;
            temp.Sdt = obj.Sdt;
            temp.GioiTinh = obj.GioiTinh;
            temp.DiaChi = obj.DiaChi;
            if (_repos.CapNhatGiangVien(temp) == true)
            {
                MessageBox.Show("Sửa thành công !");
            }
            else
            {
                MessageBox.Show("Sửa thất bại !");
            }
        }
        public void XoaGiangVien(Guid id)
        {
            var obj = _repos.GetGiangVien(null).FirstOrDefault(gv => gv.IdGiangVien == id);
            if(_repos.XoaGiangVien(obj) == true)
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
