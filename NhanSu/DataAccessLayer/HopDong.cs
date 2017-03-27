using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanSu.DataAccessLayer
{
    public class HopDong
    {
        [Key]
        public string SoHD { get; set; }

        [MaxLength(50)]
        [Required]
        public string TenHD { get; set; }

        [Required]
        public double luongcb { get; set; }

        [Required]
        public double phucap { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ngayHD { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ngayKT { get; set; }

        [MaxLength(10)]
        public string MaNV { get; set; }
        [ForeignKey("MaNV")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
