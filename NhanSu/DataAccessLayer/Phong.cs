namespace NhanSu.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public  class Phong
    {
        public Phong()
        {
            this.NhanViens = new ObservableListSource<NhanVien>();
        }
        [Key]
        [MaxLength(10)]
        [Required]
        public string Map { get; set; }

        [Required]
        [MaxLength(30)]
        public string TenP { get; set; }

         
        public virtual ObservableListSource<NhanVien> NhanViens { get; set; }
    }
}
