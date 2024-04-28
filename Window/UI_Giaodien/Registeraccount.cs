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

namespace Window.UI_Giaodien
{
    public partial class Registeraccount : Form
    {
        public Registeraccount()
        {
            InitializeComponent();
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
        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            Giaodien giaodien = new Giaodien();
            string tenDangNhap = txt_login.Text;
            string matKhau = txt_password.Text; 
            DateTime ngaySinh = Datatime_Birthday.Value;
            int age = CalculateAge(ngaySinh);
            string sdt = txt_Telephone.Text;
            string cccd = txt_CCCD.Text;

            if (IsValidUsername(tenDangNhap) && age >= 18 && age <= 100 && IsValidPhoneNumber(sdt) && IsValidCCCD(cccd))
            {
                string result = giaodien.RegisterAccount(tenDangNhap, matKhau, txt_Name.Text, txt_Address.Text, sdt, cccd, ngaySinh, cb_Gender.Text, pic_User.Text);

                if (result.Contains("Thành công"))
                {
                    MessageBox.Show("Thông tin đã được lưu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin đã nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_Upload_Click_1(object sender, EventArgs e)
        {
            Giaodien giaodien = new Giaodien();
            string anhPath;
            anhPath = giaodien.SaveImage(out anhPath);
            if (!string.IsNullOrEmpty(anhPath))
            {
                pic_User.Image = Image.FromFile(anhPath);
            }
        }

        private void btn_Exit_Click_1(object sender, EventArgs e)
        {
            txt_login.Text = "";
            txt_password.Text = "";
            txt_Name.Text = "";
            txt_Telephone.Text = "";
            txt_CCCD.Text = "";
            Datatime_Birthday.Value = DateTime.Now;
            cb_Gender.SelectedIndex = -1;
            txt_Address.Text = "";
            txt_login.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
