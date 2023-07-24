using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Giao_Dien.Model.DomainClass;

[Table("LichHoc")]
[Index("IdLopHoc", Name = "UQ__LichHoc__5C25E9AF7EDC7115", IsUnique = true)]
public partial class LichHoc
{
    [Column("ID_LopHoc")]
    public Guid? IdLopHoc { get; set; }

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaLopHoc { get; set; } = null!;

    [StringLength(50)]
    public string? NgayTrongTuan { get; set; }

    public TimeSpan? GioBatDau { get; set; }

    public TimeSpan? GioKetThuc { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Phong { get; set; }

    [ForeignKey("MaLopHoc")]
    [InverseProperty("LichHoc")]
    public virtual LopHoc MaLopHocNavigation { get; set; } = null!;
}
