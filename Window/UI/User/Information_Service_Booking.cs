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

namespace Window.UI.User
{
    public partial class Information_Service_Booking : Form
    {
        string loggedInUsername = Giaodien.TenDangNhap_User.LoggedInUsername;
        int madatPhong = Phongdangdat.MadatPhong_User.MaDatPhong;
        string madichvu = Dichvu.Dichvu_User.dichvu;
        Datphong datphong = new Datphong();
        Dichvu dichvu = new Dichvu();
        Tinhtien tinhtien = new Tinhtien();
        public Information_Service_Booking()
        {
            InitializeComponent();
            Phongdangdat phongdangdat = new Phongdangdat();
            string hoTen = datphong.HoTen(loggedInUsername);
            int maphong = phongdangdat.GetMaPhongFromMaDatPhong(madatPhong);
            lb_tenkh.Text = hoTen;
            lb_maphong.Text = maphong.ToString();
            lb_tendichvu.Text = dichvu.GetTenDichVuFromMaDV(madichvu);
            lb_tongtien.Text = tinhtien.tiendichvu(madichvu, 1).ToString();
        }
        private void btn_mua_Click(object sender, EventArgs e)
        {
            int soLuong = (int)num_soluong.Value;
            bool muaThanhCong = dichvu.Mua(madichvu, soLuong);
            if (muaThanhCong)
            {
                MessageBox.Show("Đã mua thành công dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể mua dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void num_soluong_ValueChanged(object sender, EventArgs e)
        {
            int soLuong = (int)num_soluong.Value;
            int tongTien = tinhtien.tiendichvu(madichvu, soLuong);
            lb_tongtien.Text = tongTien.ToString();
        }
    }
}
