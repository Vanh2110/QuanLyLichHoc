using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Giao_Dien.Model.DomainClass;

[Table("LopHoc")]
[Index("IdLopHoc", Name = "UQ__LopHoc__5C25E9AFB9E437B3", IsUnique = true)]
public partial class LopHoc
{
    [Column("ID_LopHoc")]
    public Guid? IdLopHoc { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? MaGiangVien { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaLopHoc { get; set; } = null!;

    [StringLength(20)]
    public string? Ten { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayBatDau { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgayKetThuc { get; set; }

    [InverseProperty("MaLopHocNavigation")]
    public virtual LichHoc? LichHoc { get; set; }

    [ForeignKey("MaGiangVien")]
    [InverseProperty("LopHocs")]
    public virtual GiangVien? MaGiangVienNavigation { get; set; }

    [InverseProperty("MaLopHocNavigation")]
    public virtual ICollection<ThanhVienLop> ThanhVienLops { get; set; } = new List<ThanhVienLop>();
}
