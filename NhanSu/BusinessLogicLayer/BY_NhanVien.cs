using NhanSu.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu.BusinessLogicLayer
{
    public class BY_NhanVien
    {
        private readonly DataContext db = new DataContext();

        public List<NhanVien> getList()
        {
            return db.NhanVien.ToList();
        }

       
        public bool add(NhanVien NhanVien)
        {

            try
            {
                db.NhanVien.Add(NhanVien);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return false;
        }

        public bool update(NhanVien NhanVien)
        {
            try
            {
                var item = db.NhanVien.FirstOrDefault(t => t.MaNV == NhanVien.MaNV);
                if (item == null)
                {
                    return false;
                }
               
               
                db.Entry(NhanVien).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return false;
        }

      

        public bool delete ( NhanVien nhanvien)

        {
            NhanVien nv = new NhanVien();
            try
            {
                var item = db.NhanVien.FirstOrDefault(t => t.MaNV == nhanvien.MaNV);
                if (nv == null)
                {
                
                    MessageBox.Show("Không thấy nhân viên");
                }

                db.NhanVien.Remove(nhanvien);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return false;
        }

        public List<Phong> getListPhong()
        {
            return db.Phong.ToList();
        }

    }
}
