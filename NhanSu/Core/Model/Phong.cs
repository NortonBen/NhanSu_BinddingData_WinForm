namespace NhanSu.Core.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QL_Phong")]
    public partial class Phong
    {
        [StringLength(30)]
        public string Map { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string TenP { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string DiaChiP { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string SDT { get; set; }
    }
}
