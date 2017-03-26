namespace NhanSu.DataAccessLayer
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
        public virtual DbSet<ChucVu> ChucVu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          

        }
    }
}
