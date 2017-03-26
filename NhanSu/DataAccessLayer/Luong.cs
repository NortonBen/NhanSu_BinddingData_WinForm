namespace NhanSu.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class Luong
    {

        [Key]
        public int MaLuong { get; set; }

        [MaxLength(30)]
        public string MaNV { get; set; }
        [ForeignKey("MaNV")]
        public virtual NhanVien NhanVien { get; set; }

        public double Thuong { get; set; }

        public double Phat { get; set; }

        public double LuongCB { get; set; }
    }
}
