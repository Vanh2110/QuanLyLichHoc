using System;
using System.Collections.Generic;
using Agile.Model.DomainClass;
using Microsoft.EntityFrameworkCore;

namespace Agile.Model.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GiangVien> GiangViens { get; set; }

    public virtual DbSet<LichHoc> LichHocs { get; set; }

    public virtual DbSet<LopHoc> LopHocs { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    public virtual DbSet<ThanhVienLop> ThanhVienLops { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ADMIN;Initial Catalog=APPLICHHOC;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GiangVien>(entity =>
        {
            entity.HasKey(e => e.MaGiangVien).HasName("PK__GiangVie__C03BEEBA9693FB91");
        });

        modelBuilder.Entity<LichHoc>(entity =>
        {
            entity.HasKey(e => e.MaLopHoc).HasName("PK__LichHoc__FEE05784F42AC2E5");

            entity.HasOne(d => d.MaLopHocNavigation).WithOne(p => p.LichHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LichHoc__MaLopHo__35BCFE0A");
        });

        modelBuilder.Entity<LopHoc>(entity =>
        {
            entity.HasKey(e => e.MaLopHoc).HasName("PK__LopHoc__FEE05784B083A1B4");

            entity.HasOne(d => d.MaGiangVienNavigation).WithMany(p => p.LopHocs).HasConstraintName("FK__LopHoc__MaGiangV__2C3393D0");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.MaSv).HasName("PK__SinhVien__2725081A8AC0340C");

            entity.Property(e => e.IdSinhVien).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<ThanhVienLop>(entity =>
        {
            entity.HasKey(e => new { e.MaSv, e.MaLopHoc }).HasName("PK__ThanhVie__78CB0D621F39EE5F");

            entity.HasOne(d => d.MaLopHocNavigation).WithMany(p => p.ThanhVienLops)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ThanhVien__MaLop__31EC6D26");

            entity.HasOne(d => d.MaSvNavigation).WithOne(p => p.ThanhVienLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ThanhVienL__MaSV__30F848ED");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
