using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Giao_Dien.Model.DomainClass;

[PrimaryKey("MaSv", "MaLopHoc")]
[Table("ThanhVienLop")]
[Index("MaSv", Name = "UQ__ThanhVie__2725081B8D79013C", IsUnique = true)]
[Index("IdThanhVienLop", Name = "UQ__ThanhVie__326EBCF4D348F1BB", IsUnique = true)]
public partial class ThanhVienLop
{
    [Column("ID_ThanhVienLop")]
    public Guid? IdThanhVienLop { get; set; }

    [Key]
    [Column("MaSV")]
    [StringLength(10)]
    [Unicode(false)]
    public string MaSv { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string MaLopHoc { get; set; } = null!;

    [ForeignKey("MaLopHoc")]
    [InverseProperty("ThanhVienLops")]
    public virtual LopHoc MaLopHocNavigation { get; set; } = null!;

    [ForeignKey("MaSv")]
    [InverseProperty("ThanhVienLop")]
    public virtual SinhVien MaSvNavigation { get; set; } = null!;
}
