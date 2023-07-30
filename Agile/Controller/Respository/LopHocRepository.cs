using Agile.Model.Context;
using Agile.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.Controller.Respository
{
    internal class LopHocRepository
    {
        DBContext _context;
        public LopHocRepository()
        {
            _context = new DBContext();
        }
        public List<LopHoc> GetLopHocs(string search)
        {
            if (search == null)
            {
                List<LopHoc> data = _context.LopHocs.ToList();
                return data;
            }
            return _context.LopHocs.Where(lh => lh.MaLopHoc.StartsWith(search)).ToList();
        }
        public bool AddLopHoc(LopHoc lopHoc)
        {
            if (lopHoc == null)
            {
                return false;
            }
            else
            {
                lopHoc.IdLopHoc = Guid.NewGuid();
                _context.Add(lopHoc);
                _context.SaveChanges();
                return true;
            }
        }
        public bool UpdateLopHoc(LopHoc lopHoc)
        {
            if (lopHoc == null)
            {
                return false;
            }
            _context.Update(lopHoc);
            _context.SaveChanges();
            return true;
        }
        public bool DeleteLopHoc(LopHoc lopHoc)
        {
            if (lopHoc == null)
            {
                return false;
            }
            else
            {
                _context.Remove(lopHoc);
                _context.SaveChanges(); 
                return true;
            }
        }
    }
}
