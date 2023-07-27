using Giao_Dien.Model.Context;
using Giao_Dien.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giao_Dien.Controller.Repository
{
    internal class QLSinhVienRepository
    {
        DBContext _context;
        public QLSinhVienRepository()
        {
            _context = new DBContext();
        }
        public List<SinhVien> GetSinhVien(string search)
        {
            if(search == null)
            {
                List<SinhVien> data = _context.SinhViens.ToList();
                return data;
            }
            return _context.SinhViens.Where(sv => sv.MaSv.StartsWith(search)).ToList();
        }
        public bool ThemSinhVien(SinhVien sv)
        {
            if (sv == null)
            {
                return false;
            }
            sv.IdSinhVien = Guid.NewGuid();
            _context.Add(sv);
            _context.SaveChanges();
            return true;
        }
        public bool CapNhatSinhVien(SinhVien sv)
        {
            if(sv == null)
            {
                return false;
            }
            _context.Update(sv);
            _context.SaveChanges();
            return true; 
        }
        public bool XoaSinhVien(SinhVien sv)
        {
            if(sv == null)
            {
                return false;
            }
            _context.Remove(sv);
            _context.SaveChanges();
            return true;
        }
    }
}
