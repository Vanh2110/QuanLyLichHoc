using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Giao_Dien.Model.DomainClass;

[Table("SinhVien")]
[Index("IdSinhVien", Name = "UQ__SinhVien__61584888E677B166", IsUnique = true)]
public partial class SinhVien
{
    [Column("ID_SinhVien")]
    public Guid? IdSinhVien { get; set; }

    [Key]
    [Column("MaSV")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaSv { get; set; } = null!;

    [StringLength(40)]
    public string? Ten { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Sdt { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Email { get; set; }

    public bool? GioiTinh { get; set; }

    [StringLength(50)]
    public string? DiaChi { get; set; }

    [StringLength(50)]
    public string? ChuyenNganh { get; set; }

    [InverseProperty("MaSvNavigation")]
    public virtual ThanhVienLop? ThanhVienLop { get; set; }
}
