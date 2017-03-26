using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanSu.DataAccessLayer
{
   public class ChucVu
    {
        public ChucVu()
        {
            this.NhanViens = new ObservableListSource<NhanVien>();
        }
        [Key]
        [MaxLength(30)]
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }

        public virtual ObservableListSource<NhanVien> NhanViens { get; set; }
    }
}
