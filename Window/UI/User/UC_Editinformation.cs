using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window.BL_Layer;
using Window.UI_Giaodien;

namespace Window.UI.User
{
    public partial class UC_Editinformation : UserControl
    {
        private KhachHang existingCustomer;
        public UC_Editinformation()
        {
            InitializeComponent();

        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            txt_Name.Text = "";
            txt_Telephone.Text = "";
            txt_CCCD.Text = "";
            Datatime_Birthday.Value = DateTime.Now;
            cb_Gender.SelectedIndex = -1; 
            txt_Address.Text = "";
            txt_Name.Focus();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            Giaodien giaodien = new Giaodien();
            string anhPath;
            anhPath = giaodien.SaveImage(out anhPath);
            if (!string.IsNullOrEmpty(anhPath))
            {
                pic_User.Image = Image.FromFile(anhPath);
            }
        }
        

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Giaodien giaodien = new Giaodien();
            string loggedInUsername = Giaodien.TenDangNhap_User.LoggedInUsername;
            KhachHang existingCustomer = giaodien.GetCustomerByEmail(loggedInUsername);

            if (existingCustomer != null)
            {
                DateTime existingNgaySinh = existingCustomer.NgaySinh ?? DateTime.MinValue;
                Datatime_Birthday.Value = existingNgaySinh;
                int age = CalculateAge(Datatime_Birthday.Value);
                string sdt = txt_Telephone.Text;
                string cccd = txt_CCCD.Text;

                if (IsValidUsername(loggedInUsername) && age >= 18 && age <= 100 && IsValidPhoneNumber(sdt) && IsValidCCCD(cccd))
                {
                    string result = giaodien.EditInformation(loggedInUsername, new KhachHang
                    {
                        HoTen = txt_Name.Text,
                        DiaChi = txt_Address.Text,
                        SDT = sdt,
                        CCCD = cccd,
                        NgaySinh = Datatime_Birthday.Value,
                        GioiTinh = cb_Gender.Text,
                        Anh = pic_User.Text,
                    });
                    MessageBox.Show("Thông tin đã được cập nhật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }



        private bool IsValidUsername(string username)
        {
            return Regex.IsMatch(username, @"^[a-zA-Z0-9]+$");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        private bool IsValidCCCD(string cccd)
        {
            return Regex.IsMatch(cccd, @"^\d{12}$");
        }

        private int CalculateAge(DateTime birthDate)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - birthDate.Year;
            if (birthDate > now.AddYears(-age))
                age--;

            return age;
        }

    }
}
