using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giao_Dien.Model.DomainClass
{
    internal class DanhSachNguoiDung
    {
        private static DanhSachNguoiDung _instance;
        internal static DanhSachNguoiDung Instance 
        { 
            get
            {
                if (_instance == null)
                    _instance = new DanhSachNguoiDung();
                return _instance;
            } 
            set => _instance = value; 
        }

        List<NguoiDung> _lstNguoiDung;

        public DanhSachNguoiDung(List<NguoiDung> lstNguoiDung)
        {
            _lstNguoiDung = lstNguoiDung;
        }

        public List<NguoiDung> LstNguoiDung { get => _lstNguoiDung; set => _lstNguoiDung = value; }

        private DanhSachNguoiDung()
        {
            LstNguoiDung = new List<NguoiDung>
            {
                new NguoiDung("admin1", "admin1", NguoiDung.LoaiND.admin),
                new NguoiDung("giangvien2", "giangvien2", NguoiDung.LoaiND.giangvien),
                new NguoiDung("sinhvien3", "sinhvien3", NguoiDung.LoaiND.sinhvien)
            };
        }
    }
}
    