namespace NhanSu.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QL_Luong
    {
        [StringLength(30)]
        public string MaNV { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string Thuong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Phat { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string LuongCB { get; set; }
    }
}
