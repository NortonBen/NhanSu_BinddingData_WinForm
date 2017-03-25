namespace NhanSu.Core.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Luong> Luong { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<Phong> Phong { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Luong>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<Luong>()
                .Property(e => e.Thuong)
                .IsFixedLength();

            modelBuilder.Entity<Luong>()
                .Property(e => e.Phat)
                .IsFixedLength();

            modelBuilder.Entity<Luong>()
                .Property(e => e.LuongCB)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaP)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.TenNV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.GioiTinh)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaCV)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.DiaChi)
                .IsFixedLength();

            modelBuilder.Entity<Phong>()
                .Property(e => e.Map)
                .IsFixedLength();

            modelBuilder.Entity<Phong>()
                .Property(e => e.TenP)
                .IsFixedLength();

            modelBuilder.Entity<Phong>()
                .Property(e => e.DiaChiP)
                .IsFixedLength();

            modelBuilder.Entity<Phong>()
                .Property(e => e.SDT)
                .IsFixedLength();
        }
    }
}
