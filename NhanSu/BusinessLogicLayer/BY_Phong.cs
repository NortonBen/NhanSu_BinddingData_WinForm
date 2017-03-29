using NhanSu.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NhanSu.BusinessLogicLayer
{
   public class BY_Phong
    {
        private  DataContext db = new DataContext();

        public List<Phong> getList()
        {
            return db.Phong.ToList();
        }

        public bool add(Phong phong)
        {
            var item = db.Phong.FirstOrDefault(t => t.Map.Equals(phong.Map));
            if (item != null)
            {
                return false;
            }
            try
            {

                db.Phong.Add(phong);
                db.SaveChanges();
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: "+ex.Message);
            }
            return false;
        }

        public bool update(Phong phong)
        {
            try
            {
                var item = db.Phong.FirstOrDefault(t => t.Map == phong.Map);
                if (item == null)
                {
                    return false;
                }

                item.TenP = phong.TenP;

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

        public bool delete(Phong phong)
        {
            try
            {
                var item = db.Phong.FirstOrDefault(t => t.Map == phong.Map);
                if(item == null)
                {
                    return false;
                }
                db.Phong.Remove(item);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
            return false;
        }
    }
}
