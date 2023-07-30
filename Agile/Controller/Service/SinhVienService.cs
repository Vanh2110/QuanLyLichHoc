using Agile.Controller.Respository;
using Agile.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Controller.Service
{
    internal class SinhVienService
    {
        SinhVienRespository _repos;
        public SinhVienService()
        {
            _repos = new SinhVienRespository();
        }
        public void ThemSV(SinhVien obj)
        {
            if (_repos.AddSinhVien(obj)==true)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void XoaSV(Guid guidID)
        {
            var obj = _repos.GetSinhViens(null).FirstOrDefault(sv => sv.IdSinhVien == guidID);
            if (_repos.DeleteSinhVien(obj)==true)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
        public List<SinhVien> GetSinhViens(string input)
        {
            return _repos.GetSinhViens(input);
        }
    }
}
