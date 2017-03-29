using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanSu.DataAccessLayer
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [MaxLength(20)]
        public string email { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
