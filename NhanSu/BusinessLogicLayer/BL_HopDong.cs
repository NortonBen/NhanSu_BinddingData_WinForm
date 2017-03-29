using NhanSu.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu.BusinessLogicLayer
{
    class BL_HopDong
    {
        private readonly DataContext db = new DataContext();

        public List<HopDong> getList()
        {
            return db.HopDong.ToList();
        }


        public bool add(HopDong HopDong)
        {

            try
            {
                db.HopDong.Add(HopDong);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return false;
        }

        public bool update(HopDong HopDong)
        {
            try
            {
                var item = db.HopDong.FirstOrDefault(t => t.SoHD == HopDong.SoHD);
                if (item == null)
                {
                    return false;
                }


                db.Entry(HopDong).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return false;
        }



        public bool delete(HopDong HopDong)

        {
            try
            {
                var item = db.HopDong.FirstOrDefault(t => t.SoHD == HopDong.SoHD);
                if (item == null)
                {

                    MessageBox.Show("Không thấy nhân viên");
                }

                db.HopDong.Remove(HopDong);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return false;
        }

        public List<NhanVien> getListNhanVien()
        {
            return db.NhanVien.ToList();
        }

    }
}
