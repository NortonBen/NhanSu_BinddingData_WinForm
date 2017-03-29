using NhanSu.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhanSu.BusinessLogicLayer
{
    class BLY_DangNhap
    {
        private readonly DataContext db = new DataContext();

        public bool login(User user)
        {
            var _user = db.User.FirstOrDefault(t => t.email.ToLower() == user.email.ToLower() && t.password == user.password);
            if(_user != null)
            {
                return true;
            } 

            return false;
        }
    }
}
