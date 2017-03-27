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
        [Required]
        public string MaNV { get; set; }

        [Required]
        [MaxLength(40)]
        public string TenNV { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NamSinh { get; set; }

        [Required]
        public string GioiTinh { get; set; }

        [MaxLength(30)]
        public string MaCV { get; set; }
        [ForeignKey("MaCV")]
        public virtual ChucVu ChucVu { get; set; }

        [MaxLength(30)]
        [Required]
        public string MaP { get; set; }
        [ForeignKey("MaP")]
        public virtual Phong Phong { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime NgayVaoCty { get; set; }

        [StringLength(20)]
        [Required]
        public string SDT { get; set; }


        [StringLength(60)]
        [Required]
        public string DiaChi { get; set; }
    }
}
