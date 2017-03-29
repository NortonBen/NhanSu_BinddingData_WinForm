using NhanSu.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu.BusinessLogicLayer
{
    class BY_QuyetDinh
    {
        private readonly DataContext db = new DataContext();

        public List<QuyetDinh> getList()
        {
            return db.QuyetDinh.ToList();
        }


        public bool add(QuyetDinh QuyetDinh)
        {

            try
            {
                db.QuyetDinh.Add(QuyetDinh);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return false;
        }

        public bool update(QuyetDinh QuyetDinh)
        {
            try
            {
                var item = db.QuyetDinh.FirstOrDefault(t => t.SoQD == QuyetDinh.SoQD);
                if (item == null)
                {
                    return false;
                }


                db.Entry(QuyetDinh).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return false;
        }



        public bool delete(QuyetDinh QuyetDinh)

        {
            try
            {
                var item = db.QuyetDinh.FirstOrDefault(t => t.SoQD == QuyetDinh.SoQD);
                if (item == null)
                {

                    MessageBox.Show("Không thấy nhân viên");
                }

                db.QuyetDinh.Remove(QuyetDinh);
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
