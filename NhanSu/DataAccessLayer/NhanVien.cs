namespace NhanSu.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class NhanVien
    {
        [Key]
        [MaxLength(30)]
        public string MaNV { get; set; }

        [StringLength(40)]
        public string TenNV { get; set; }

        [DataType(DataType.Date)]
        public DateTime NamSinh { get; set; }

        public string GioiTinh { get; set; }

        [MaxLength(30)]
        public string MaCV { get; set; }
        [ForeignKey("MaCV")]
        public virtual ChucVu ChucVu { get; set; }

        [MaxLength(30)]
        public string MaP { get; set; }
        [ForeignKey("MaP")]
        public virtual Phong Phong { get; set; }

        [DataType(DataType.Date)]
        public DateTime NgayVaoCty { get; set; }

        [StringLength(20)]
        public string SDT { get; set; }


        [StringLength(60)]
        public string DiaChi { get; set; }
    }
}
