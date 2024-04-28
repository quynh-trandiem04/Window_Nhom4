using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window.BL_Layer
{
    internal class Tinhtien
    {
        QLKSCKEntities1 db = new QLKSCKEntities1();
        public int tienphong(int maDatPhong)
        {
            var datPhong = db.DatPhongs.FirstOrDefault(dp => dp.MaDatPhong == maDatPhong);

            if (datPhong != null)
            {
                var phong = db.Phongs.FirstOrDefault(p => p.MaPhong == datPhong.MaPhong);

                if (phong != null)
                {
                    var loaiPhong = db.LoaiPhongs.FirstOrDefault(lp => lp.MaLoaiPhong == phong.LoaiPhong);

                    if (loaiPhong != null)
                    {
                        TimeSpan thoiGianDat = (DateTime)datPhong.NgayTra - (DateTime)datPhong.NgayDat;
                        int soNgayDat = (int)thoiGianDat.TotalDays;
                        int tienPhong = soNgayDat * loaiPhong.Gia??0;
                        return tienPhong;
                    }
                }
            }
            return -1;
        }

        public int tiendichvu(string maDichVu, int soLuong)
        {
            int tongTienDichVu = 0;
            var dichVu = db.DichVus.FirstOrDefault(dv => dv.MaDV == maDichVu);

            if (dichVu != null)
            {
                tongTienDichVu = soLuong * Convert.ToInt32(dichVu.Gia);
            }
            return tongTienDichVu;
        }

    }
}
