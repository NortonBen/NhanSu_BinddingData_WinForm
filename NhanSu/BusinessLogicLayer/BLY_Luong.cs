using NhanSu.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu.BusinessLogicLayer
{
    class BLY_Luong
    {
        private readonly DataContext db = new DataContext();

        public List<Luong> getList();



    }
}
