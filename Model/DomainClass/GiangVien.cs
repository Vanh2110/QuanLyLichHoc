using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Giao_Dien.Model.DomainClass;

[Table("GiangVien")]
[Index("IdGiangVien", Name = "UQ__GiangVie__DEB4488589D2DFBD", IsUnique = true)]
public partial class GiangVien
{
    [Column("ID_GiangVien")]
    public Guid? IdGiangVien { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaGiangVien { get; set; } = null!;

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

    [InverseProperty("MaGiangVienNavigation")]
    public virtual ICollection<LopHoc> LopHocs { get; set; } = new List<LopHoc>();
}
