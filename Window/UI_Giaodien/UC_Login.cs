using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window.BL_Layer;
using Window.UI.Admin;
using Window.UI.User;

namespace Window.UI_Giaodien
{
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }
        private bool isLoggedIn = false;

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
        }
        private void Cb_Showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Showpass.Checked)
            {
                txt_keyword.PasswordChar = '\0';
            }
            else
            {

                txt_keyword.PasswordChar = '*';
            }
        }

        private void lb_quenmk_Click(object sender, EventArgs e)
        {
            ForgetPass f = new ForgetPass();
            f.ShowDialog();


        }

        private void lb_dk_Click(object sender, EventArgs e)
        {
            Registeraccount f = new Registeraccount();
            f.ShowDialog();
        }



        private void Logindn_Click(object sender, EventArgs e)
        {
            if (txt_login.Text == "" || txt_keyword.Text == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu trống", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!rdo_NhanVien.Checked && !rdo_KhachHang.Checked)
            {
                MessageBox.Show("Vui lòng chọn vai trò", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tenDangNhap = txt_login.Text;
                string matKhau = txt_keyword.Text;

                Giaodien giaodien = new Giaodien();

                string role = "";
                if (rdo_NhanVien.Checked)
                {
                    role = "nv"; 
                }
                else if (rdo_KhachHang.Checked)
                {
                    role = "kh"; 
                }

                string result = giaodien.Check(new DangNhap { TenDangNhap = tenDangNhap, MatKhau = matKhau });

                if (result == role)
                {
                    if (result == "nv") 
                    {
                        Admin f = new Admin();
                        f.Show();
                        this.Hide();
                    }
                    else if (result == "kh") 
                    {
                        Giaodien.TenDangNhap_User.LoggedInUsername = txt_login.Text;
                        UI.User.User f = new UI.User.User();
                        f.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng hoặc không có quyền truy cập", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
