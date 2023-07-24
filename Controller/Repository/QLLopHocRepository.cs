using Giao_Dien.Model.Context;
using Giao_Dien.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giao_Dien.Controller.Repository
{
    internal class QLLopHocRepository
    {
        DBContext _context;
        public QLLopHocRepository()
        {
            _context = new DBContext();
        }
        public List<LopHoc> GetLopHoc(string search)
        {
            if (search == null)
            {
                List<LopHoc> data = _context.LopHocs.ToList();
                return data;
            }
            return _context.LopHocs.Where(lh => lh.Ten.StartsWith(search) || lh.MaLopHoc.StartsWith(search)).ToList();
        }
        public bool ThemLopHoc(LopHoc lopHoc)
        {
            if (lopHoc == null)
            {
                return false;
            }
            lopHoc.IdLopHoc = Guid.NewGuid();
            _context.Add(lopHoc);
            _context.SaveChanges();
            return true;
        }
        public bool CNLopHoc(LopHoc lopHoc)
        {
            if (lopHoc == null)
            {
                return false;
            }
            _context.Update(lopHoc);
            _context.SaveChanges();
            return true;
        }
        public bool XoaLopHoc(LopHoc lopHoc)
        {
            if (lopHoc == null)
            {
                return false;
            }
            _context.Remove(lopHoc);
            _context.SaveChanges();
            return true;
        }
    }
}
