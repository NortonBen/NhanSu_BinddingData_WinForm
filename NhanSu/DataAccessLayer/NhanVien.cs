namespace NhanSu.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class NhanVien
    {
        public NhanVien()
        {
            this.HopDongs = new ObservableListSource<HopDong>();
            this.QuyetDinhs = new ObservableListSource<QuyetDinh>();
        }


        [Key]
        [MaxLength(10)]
        public string MaNV { get; set; }

        [Required]
        [MaxLength(40)]
        public string TenNV { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime NamSinh { get; set; }

        [Required]
        public string GioiTinh { get; set; }

        [MaxLength(10)]
        [Required]
        public string MaP { get; set; }
        [ForeignKey("MaP")]
        public virtual Phong Phong { get; set; }


        [StringLength(50)]
        public string quequan { get; set; }


        [StringLength(60)]
        [Required]
        public string dantoc { get; set; }

        [StringLength(60)]
        [Required]
        public string ngoaingu { get; set; }

        [StringLength(60)]
        [Required]
        public string trinhdo { get; set; }

        public virtual ObservableListSource<HopDong> HopDongs { get; set; }
        public virtual ObservableListSource<QuyetDinh> QuyetDinhs { get; set; }
    }
}

