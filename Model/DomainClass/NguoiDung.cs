using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Giao_Dien.Model.DomainClass;

[Table("NguoiDung")]
public partial class NguoiDung
{
    [Key]
    [Column("username")]
    [StringLength(30)]
    [Unicode(false)]
    public string Username { get; set; } = null!; 

    [Column("passsword")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Passsword { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? LoaiTaiKhoan { get; set; }

    //public enum LoaiND
    //{
    //    admin,
    //    giangvien,
    //    sinhvien
    //}

    //private LoaiND LoaiNguoiDung;
    //public LoaiND LoaiNguoiDung1 { get { return LoaiNguoiDung; } set => LoaiNguoiDung = value; }

    //public NguoiDung(string username, string password, LoaiND loainguoidung)
    //{
    //    Username = username;
    //    Passsword = password;
    //    LoaiNguoiDung1 = loainguoidung;
    //}
}
