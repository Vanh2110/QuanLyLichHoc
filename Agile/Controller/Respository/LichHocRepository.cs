using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agile.Model.Context;
using Agile.Model.DomainClass;

namespace Agile.Controller.Respository
{
    internal class LichHocRepository
    {
        DBContext _context;
        public LichHocRepository()
        {
            _context = new DBContext();
        }
        public List<LichHoc> GetLichHocs(string search)
        {
            if (search == null)
            {
                List<LichHoc> data = _context.LichHocs.ToList();
                return data;
            }
            return _context.LichHocs.Where(lh => lh.MaLopHoc == search).ToList();
        }
        public bool AddLichHoc(LichHoc lichHoc)
        {
            if (lichHoc == null)
            {
                return false;
            }
            else
            {
                //lichHoc.IdLopHoc = Guid.NewGuid();
                _context.Add(lichHoc);
                _context.SaveChanges();
                return true;
            }
        }
        public bool UpdateLichHoc(LichHoc lichHoc)
        {
            if (lichHoc == null)
            {
                return false;
            }
                _context.Update(lichHoc);
                _context.SaveChanges();
                return true;
        }
        public bool DeleteLichHoc(LichHoc lichHoc)
        {
            if (lichHoc == null)
            {
                return false;
            }
            _context.Remove(lichHoc);
            _context.SaveChanges();
            return true;
        }
    }
}
