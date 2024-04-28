using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window.UI.User
{
    public partial class UC_Item_Booking_User : UserControl
    {
        private Phong _phong;
        private string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        
        public UC_Item_Booking_User(int roomId, string roomType, string description, int? capacity, int? price, string imagePath)
        {
            InitializeComponent();
            lb_maphong.Text = roomId.ToString();
            lb_maloaiphong.Text = roomType.ToString();
            lb_mota.Text = description;
            lb_songuoi.Text = capacity?.ToString() ?? "N/A";
            lb_gia.Text = price?.ToString() ?? "N/A";

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                Image image = Image.FromFile(imagePath);
                pic_Anh.Image = image;
            }
        }
        private void btn_booking_Click(object sender, EventArgs e)
        {
            Information_Booking f = new Information_Booking();
            f.RoomId = int.Parse(lb_maphong.Text);
            f.roomType = lb_maloaiphong.Text;
            f.Capacity = lb_songuoi.Text;
            f.Price = lb_gia.Text;
            f.ShowDialog();
        }

    }
}
