using Azure.Core;
using Azure.Identity;
using Giao_Dien.Model.DomainClass;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giao_Dien.Controller.Service
{
    internal class NguoiDungService
    {
        private List<NguoiDung> _lstND = new List<NguoiDung>();
        public NguoiDungService()
        {
            NguoiDung quantrivien = new NguoiDung
            {
                Username = "admin",
                Passsword = "1",
                LoaiTaiKhoan = "Quản trị viên"
            }; 
            NguoiDung giangvien = new NguoiDung
            {
                Username = "giangvien",
                Passsword = "1",
                LoaiTaiKhoan = "Giảng viên"
            }; 
            NguoiDung sinhvien = new NguoiDung
            {
                Username = "sinhvien",
                Passsword = "1",
                LoaiTaiKhoan = "Sinh viên"
            };
            _lstND.Add(quantrivien);
            _lstND.Add(giangvien);
            _lstND.Add(sinhvien);

        }
        public void ThemND(NguoiDung nd)
        {
            _lstND.Add(nd);
        }
        public string KiemTraNguoiDung(string user, string pass)
        {
            foreach (var item in _lstND)
            {
                if(item.Username == user && item.Passsword == pass)
                {
                    return item.LoaiTaiKhoan;
                }
            }
            return null;
        }
    }
}
