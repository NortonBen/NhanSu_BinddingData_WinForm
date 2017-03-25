namespace NhanSu.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QL_NhanVien")]
    public partial class NhanVien
    {
        [StringLength(30)]
        public string MaNV { get; set; }

        [StringLength(30)]
        public string MaP { get; set; }

        [StringLength(40)]
        public string TenNV { get; set; }

        [Key]
        [Column(Order = 0, TypeName = "date")]
        public DateTime NamSinh { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string GioiTinh { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string MaCV { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime NgayVaoCty { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string SDT { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(30)]
        public string DiaChi { get; set; }
    }
}
