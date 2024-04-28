using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window.UI.User;

namespace Window.BL_Layer
{
    internal class Giaodien
    {
        QLKSCKEntities1 db = new QLKSCKEntities1();
        public static class TenDangNhap_User
        {
            public static string LoggedInUsername { get; set; }
        }
        
        public string Check(DangNhap f)
        {
            var result = db.DangNhaps.FirstOrDefault(k => k.TenDangNhap == f.TenDangNhap && k.MatKhau == f.MatKhau);

            if (result != null)
            {
                if (result.ChucVu == "nv")
                {
                    return "nv"; 
                }
                else if (result.ChucVu == "kh")
                {
                    return "kh"; 
                }
            }

            return ""; 
        }
        public string RegisterAccount(string tenDangNhap, string matKhau, string hoTen, string diaChi, string sdt, string cccd, DateTime ngaySinh, string gioiTinh, string anh)
        {
            try
            {
                if (db.DangNhaps.Any(dn => dn.TenDangNhap == tenDangNhap))
                {
                    return "Tên đăng nhập đã được sử dụng. Vui lòng chọn tên đăng nhập khác.";
                }
                DangNhap dangNhap = new DangNhap
                {
                    TenDangNhap = tenDangNhap,
                    MatKhau = matKhau
                };
                db.DangNhaps.Add(dangNhap);
                db.SaveChanges();
                KhachHang khachHang = new KhachHang
                {
                    TenDangNhap = tenDangNhap,
                    HoTen = hoTen,
                    DiaChi = diaChi,
                    SDT = sdt,
                    CCCD = cccd,
                    NgaySinh = ngaySinh,
                    GioiTinh = gioiTinh,
                    Anh = anh
                };
                db.KhachHangs.Add(khachHang);
                db.SaveChanges();
                return "Đăng ký tài khoản thành công!";
            }
            catch (Exception ex)
            {
                return "Đăng ký tài khoản thất bại: " + ex.Message;
            }
        }

        public string EditInformation(string tenDangNhap, KhachHang f)
        {
            try
            {
                KhachHang existingCustomer = db.KhachHangs.FirstOrDefault(kh => kh.TenDangNhap == tenDangNhap);
                if (existingCustomer == null)
                {
                    return "Tài khoản không tồn tại!";
                }
                existingCustomer.HoTen = f.HoTen;
                existingCustomer.DiaChi = f.DiaChi;
                existingCustomer.SDT = f.SDT;
                existingCustomer.CCCD = f.CCCD;
                existingCustomer.NgaySinh = f.NgaySinh;
                existingCustomer.GioiTinh = f.GioiTinh;
                existingCustomer.Anh = f.Anh;
                db.SaveChanges();

                return "Cập nhật thông tin thành công!";
            }
            catch (Exception ex)
            {
                return "Cập nhật thông tin thất bại: " + ex.Message;
            }
        }


        public string SaveImage(out string filename)
        {
            filename = string.Empty;
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
                string dest = Path.Combine(appDirectory, Path.GetFileName(opf.FileName));
                File.Copy(opf.FileName, dest, true);
                filename = Path.GetFileName(opf.FileName);
                return dest;
            }
            return string.Empty;
        }
        public KhachHang GetCustomerByEmail(string TenDangNhap)
        {
            return db.KhachHangs.FirstOrDefault(kh => kh.TenDangNhap == TenDangNhap);
        }
        
    }
}
