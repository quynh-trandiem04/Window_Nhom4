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
using Window.UI_Giaodien;

namespace Window.UI.User
{
    public partial class UC_Booking : UserControl
    {
        private Datphong datphong;

        public UC_Booking()
        {
            InitializeComponent();
            datphong = new Datphong();
            LoadRooms();
            flowLayoutPanel1.Scroll += flowLayoutPanel1_Scroll;
        }

        private void LoadRooms()
        {
            datphong.Booking(flowLayoutPanel1);
        }

        private void LoadMoreRooms()
        {
            datphong.Booking(flowLayoutPanel1);
        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll && flowLayoutPanel1.VerticalScroll.Value + flowLayoutPanel1.Height >= flowLayoutPanel1.VerticalScroll.Maximum)
            {
                LoadMoreRooms();
            }
        }

        private void UC_Booking_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
