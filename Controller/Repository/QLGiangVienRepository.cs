using Giao_Dien.Model.Context;
using Giao_Dien.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giao_Dien.Controller.Repository
{
    internal class QLGiangVienRepository
    {
        DBContext _context;
        public QLGiangVienRepository()
        {
            _context = new DBContext();
        }
        public List<GiangVien> GetGiangVien(string search)
        {
            if (search == null)
            {
                List<GiangVien> data = _context.GiangViens.ToList();
                return data;
            }
            return _context.GiangViens.Where(gv => gv.MaGiangVien == search).ToList();
        }
        public bool ThemGiangVien(GiangVien gv)
        {
            if (gv == null)
            {
                return false;
            }
            gv.IdGiangVien = Guid.NewGuid();
            _context.Add(gv);
            _context.SaveChanges();
            return true;
        }
        public bool CapNhatGiangVien(GiangVien gv)
        {
            if (gv == null)
            {
                return false;
            }
            _context.Update(gv);
            _context.SaveChanges();
            return true;
        }
        public bool XoaGiangVien(GiangVien gv)
        {
            if (gv == null)
            {
                return false;
            }
            _context.Remove(gv);
            _context.SaveChanges(); 
            return true;
        }
    }
}
    

