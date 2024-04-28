using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Window.UI.User;

namespace Window.BL_Layer
{
    internal class Dichvu
    {
        QLKSCKEntities1 db = new QLKSCKEntities1();
        public static class Dichvu_User
        {
            public static string dichvu { get; set; }
        }
        public string GetTenDichVuFromMaDV(string maDV)
        {
            using (var dbContext = new QLKSCKEntities1())
            {
                var dichVu = dbContext.DichVus.FirstOrDefault(dv => dv.MaDV == maDV);

                if (dichVu != null)
                {
                    return dichVu.TenDV;
                }
                else
                {
                    return "Không xác định";
                }
            }
        }

        public void SaveImage(PictureBox image, out string filename)
        {
            filename = string.Empty;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                image.Image = Image.FromFile(opf.FileName);
                filename = Path.GetFileName(opf.FileName);
                string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string dest = Path.Combine(appDirectory, filename);
                File.Copy(opf.FileName, dest, true);
            }
        }
        public void DScacdichvu(FlowLayoutPanel f)
        {
            var services = db.DichVus.ToList(); 

            foreach (var service in services)
            {
                UC_Item_Service serviceItem = new UC_Item_Service(service);
                f.Controls.Add(serviceItem); 
            }
        }
        public bool Mua(string madv, int soluong)
        {
            if (string.IsNullOrEmpty(madv))
            {
                return false;
            }
            var dichVu = db.DichVus.FirstOrDefault(dv => dv.MaDV == madv);
            if (dichVu == null)
            {
                return false;
            }
            var tongDichVu = db.TongDichVus.FirstOrDefault(td => td.MaDV == madv);
            if (tongDichVu != null)
            {
                tongDichVu.SoLuong += soluong;
            }
            else
            {
                tongDichVu = new TongDichVu()
                {
                    MaDV = madv,
                    SoLuong = soluong
                };
                db.TongDichVus.Add(tongDichVu);
            }
            db.SaveChanges();

            return true;
        }

    }
}
