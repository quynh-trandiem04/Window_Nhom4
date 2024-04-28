using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window.BL_Layer;
using Window.UI_Giaodien;

namespace Window.UI.User
{
    public partial class Information_Booking : Form
    {
        public int RoomId { get; set; }
        public string roomType { get; set; }

        public string Capacity { get; set; }
        public string Price { get; set; }
        
        public Information_Booking()
        {
            InitializeComponent();
        }
        string loggedInUsername = Giaodien.TenDangNhap_User.LoggedInUsername;
        private void Information_Booking_Load(object sender, EventArgs e)
        {
            BL_Layer.Datphong datphong = new Datphong();
            string hoTen = datphong.HoTen(loggedInUsername);
            lb_tenkh.Text = hoTen;
            lb_maphong.Text = RoomId.ToString();
            lb_maloaiphong.Text = roomType.ToString();
            lb_gia.Text = Price;
            lb_thoigiandat.Text = DateTime.Now.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_datphong_Click_1(object sender, EventArgs e)
        {
            DateTime ngayDat = time_ngaydat.Value;
            DateTime ngayTra = time_ngaytra.Value;
            int songuoidat;
            if (!int.TryParse(txt_songuoi.Text, out songuoidat))
            {
                MessageBox.Show("Vui lòng nhập số người hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Datphong datphong = new Datphong();
            Datphong.Madatphong_User.Madatphong = RoomId.ToString();
            int result = datphong.DatPhongUser(loggedInUsername, RoomId, ngayDat,ngayTra, songuoidat);
            if (result == 1)
            {
                this.Close();
            }
        }

    }
}
