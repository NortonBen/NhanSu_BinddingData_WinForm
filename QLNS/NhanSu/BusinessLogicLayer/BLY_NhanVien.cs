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
    public class BLY_NhanVien
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
                item.TenNV = NhanVien.TenNV;
                item.MaP = NhanVien.MaP;
                item.MaCV = NhanVien.MaCV;
                item.NgayVaoCty = NhanVien.NgayVaoCty;
                item.NamSinh = NhanVien.NamSinh;
                item.GioiTinh = NhanVien.GioiTinh;
                item.DiaChi = NhanVien.DiaChi;
                item.SDT = NhanVien.SDT;
               
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
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
                
                    Console.WriteLine("tra ve tin hieu cho presenter thông báo");
                    MessageBox.Show("Không thấy nhân viên");
                }
                
               
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
