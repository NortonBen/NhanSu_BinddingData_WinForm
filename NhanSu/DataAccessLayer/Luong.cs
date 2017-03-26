namespace NhanSu.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class Luong
    {

       

        [MaxLength(30)]
        [Required]
        [Key, ForeignKey("NhanVien")]
        public string MaNV { get; set; }
        public virtual NhanVien NhanVien { get; set; }

        [Required]
        public double heso { get; set; }

        [Required]
        public double LuongCB { get; set; }
    }
}
