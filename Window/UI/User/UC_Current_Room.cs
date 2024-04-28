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
    public partial class UC_Current_Room : UserControl
    {
        private Phongdangdat phongdangdat;
        public UC_Current_Room()
        {
            InitializeComponent();
            phongdangdat = new Phongdangdat();
            string loggedInUsername = Giaodien.TenDangNhap_User.LoggedInUsername;
            Datphong datphong = new Datphong();
            int makh = phongdangdat.GetMaKHFromTenDangNhap(loggedInUsername);
            phongdangdat.DSCacphongdangdat(flowLayoutPanel1, makh);
        }
        
    }
}
