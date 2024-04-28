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
    public partial class UC_Item_Current_Room : UserControl
    {
        Tinhtien tinhtien = new Tinhtien();
        
        public UC_Item_Current_Room(DatPhong f)
        {
            InitializeComponent();
            Phongdangdat.MadatPhong_User.MaDatPhong = f.MaDatPhong;
            lb_maphong.Text = f.MaPhong.ToString();
            lb_ngaydat.Text = f.NgayDat.ToString();
            lb_ngaytra.Text = f.NgayTra.ToString();
            lb_thoigiandat.Text = f.ThoiGianDat.ToString();
            lb_tongtienphong.Text = tinhtien.tienphong(f.MaDatPhong).ToString();
        }

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            Detail_Current_Room_Booked f = new Detail_Current_Room_Booked();
            f.ShowDialog();
        }
    }
}
