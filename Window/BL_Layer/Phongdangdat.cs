using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window.UI.User;

namespace Window.BL_Layer
{
    public class ChiTietDatPhongInfo
    {
        public int MaPhong { get; set; }
        public string LoaiPhong { get; set; }
        public DateTime ThoiGianDat { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime NgayTra { get; set; }
        public int SoNguoi { get; set; }
        public int Gia { get; set; }
    }

    internal class Phongdangdat
    {
        QLKSCKEntities1 db = new QLKSCKEntities1();
        public static class MadatPhong_User
        {
            public static int MaDatPhong { get; set; }
        }
        public void DSCacphongdangdat(FlowLayoutPanel f, int maKH)
        {
            var currentRooms = db.DatPhongs
                                 .Where(dp => dp.MaKH == maKH && dp.TinhTrang == "unfinish")
                                 .ToList();
            foreach (var room in currentRooms)
            {
                UC_Item_Current_Room currentRoomItem = new UC_Item_Current_Room(room);
                f.Controls.Add(currentRoomItem);
            }
        }
        public ChiTietDatPhongInfo Chitietdatphong(int madatphong)
        {
            var datPhong = db.DatPhongs.FirstOrDefault(dp => dp.MaDatPhong == madatphong);

            if (datPhong != null)
            {
                return new ChiTietDatPhongInfo
                {
                    MaPhong = datPhong.MaPhong ?? 0,
                    LoaiPhong = datPhong.Phong.LoaiPhong,
                    ThoiGianDat = datPhong.ThoiGianDat ?? DateTime.MinValue,
                    NgayDat = datPhong.NgayDat ?? DateTime.MinValue,
                    NgayTra = datPhong.NgayTra ?? DateTime.MinValue,
                    SoNguoi = datPhong.Phong.LoaiPhong1.SoNguoi ?? 0,
                    Gia = datPhong.Phong.LoaiPhong1.Gia ?? 0
                };
            }

            return null;
        }


        public int GetMaKHFromTenDangNhap(string tenDangNhap)
        {
            var khachHang = db.KhachHangs.FirstOrDefault(kh => kh.TenDangNhap == tenDangNhap);
            return khachHang != null ? khachHang.MaKH : 0;
        }
        public bool Huydat(int maDatPhong)
        {
            var datPhong = db.DatPhongs.FirstOrDefault(dp => dp.MaDatPhong == maDatPhong);

            if (datPhong != null)
            {
                datPhong.TinhTrang = "finish";
                db.SaveChanges();
                var phong = db.Phongs.FirstOrDefault(p => p.MaPhong == datPhong.MaPhong);
                if (phong != null)
                {
                    phong.TinhTrang = "empty";
                    db.SaveChanges();
                    return true; 
                }
            }

            return false; 
        }
        public int GetMaPhongFromMaDatPhong(int MaDatPhong)
        {
            var datPhong = db.DatPhongs.FirstOrDefault(dp => dp.MaDatPhong == MaDatPhong);

            if (datPhong != null)
            {
                return datPhong.MaPhong??0;
            }
            else
            {
                return -1;
            }
        }


    }
}
