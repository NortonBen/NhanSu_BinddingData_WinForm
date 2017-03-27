using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanSu.DataAccessLayer
{
    public class QuyetDinh
    {
        [Key]
        [MaxLength(10)]
        public string SoQD { get; set; }

        [MaxLength(30)]
        public string TenQD { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string NoiDung { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ngayQD { get; set; }

        [MaxLength(10)]
        public string MaNV { get; set; }
        [ForeignKey("MaNV")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
