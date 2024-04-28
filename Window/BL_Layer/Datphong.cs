using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Window.UI.User;
using Window.UI_Giaodien;

namespace Window.BL_Layer
{
    internal class Datphong
    {

        QLKSCKEntities1 db = new QLKSCKEntities1();
        string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public static class Madatphong_User
        {
            public static string Madatphong { get; set; }
        }
        public void Booking(FlowLayoutPanel f)
        {
            var roomsDetails = from room1 in db.Phongs
                               join room2 in db.DatPhongs
                               on room1.MaPhong equals room2.MaPhong into room2Group
                               from room2 in room2Group.DefaultIfEmpty()
                               where room1.TinhTrang == "empty" && (room2 == null || room2.TinhTrang == "finish")
                               select new
                               {
                                   RoomId = room1.MaPhong,
                                   RoomType = room1.LoaiPhong1.MaLoaiPhong,
                                   Description = room1.LoaiPhong1.MoTa,
                                   Capacity = room1.LoaiPhong1.SoNguoi,
                                   Price = room1.LoaiPhong1.Gia,
                                   Picture = room1.LoaiPhong1.Anh
                               };
            foreach (var roomDetail in roomsDetails)
            {
                string imagePath = Path.Combine(appDirectory, roomDetail.Picture);
                UI.User.UC_Item_Booking_User bookingItem = new UC_Item_Booking_User(roomDetail.RoomId,
                                                                   roomDetail.RoomType,
                                                                   roomDetail.Description,
                                                                   roomDetail.Capacity,
                                                                   roomDetail.Price,
                                                                   imagePath);
                f.Controls.Add(bookingItem);
            }
        }

        public int DatPhongUser(string tenDangNhap, int maPhong, DateTime ngayDat, DateTime ngayTra, int songuoidat)
        {
            KhachHang khachHang = db.KhachHangs.FirstOrDefault(kh => kh.TenDangNhap == tenDangNhap);
            if (khachHang == null)
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            Phong phong = db.Phongs.FirstOrDefault(p => p.MaPhong == maPhong);
            if (phong == null)
            {
                MessageBox.Show("Không tìm thấy thông tin phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            LoaiPhong loaiPhong = db.LoaiPhongs.FirstOrDefault(lp => lp.MaLoaiPhong == phong.LoaiPhong);
            if (loaiPhong == null)
            {
                MessageBox.Show("Không tìm thấy thông tin loại phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            if (songuoidat > loaiPhong.SoNguoi)
            {
                MessageBox.Show("Số người đặt phòng vượt quá sức chứa của phòng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            DatPhong datPhong = new DatPhong
            {
                MaKH = khachHang.MaKH,
                MaPhong = maPhong,
                NgayDat = ngayDat,
                NgayTra = ngayTra,
                ThoiGianDat = DateTime.Now
            };
            db.DatPhongs.Add(datPhong);
            phong.TinhTrang = "wait";
            datPhong.TinhTrang = "unfinish";
            db.SaveChanges();
            MessageBox.Show("Đặt phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 1;
        }

        public string HoTen(string tenDangNhap)
        {
            KhachHang khachHang = db.KhachHangs.FirstOrDefault(kh => kh.TenDangNhap == tenDangNhap);
            return khachHang != null ? khachHang.HoTen : null;
        }

    }
}
