using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agile.Model.Context;
using Agile.Model.DomainClass;

namespace Agile.Controller.Respository
{
    internal class SinhVienRespository
    {
        DBContext _context;
        public SinhVienRespository()
        {
            _context = new DBContext();
        }
        public List<SinhVien> GetSinhViens(string search)
        {
            if (search == null)
            {
                List<SinhVien> data = _context.SinhViens.ToList();
                return data;
            }
            return _context.SinhViens.Where(sv => sv.MaSv.StartsWith(search) || sv.Ten.StartsWith(search)).ToList();

        }
        public bool AddSinhVien(SinhVien sinhvien)
        {
            if (sinhvien == null)
            {
                return false;
            }
            else
            {
                sinhvien.IdSinhVien = Guid.NewGuid();
                _context.Add(sinhvien);
                _context.SaveChanges();
                return true;    
            }
        }
        public bool DeleteSinhVien(SinhVien sv)
        {
            if (sv == null)
            {
                return false;
            }
            _context.Remove(sv);
            _context.SaveChanges();
            return true;
        }
    }
}
