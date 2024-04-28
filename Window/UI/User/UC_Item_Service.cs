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
using Window.BL_Layer;

namespace Window.UI.User
{
    public partial class UC_Item_Service : UserControl
    {
        private string appDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
       
        public UC_Item_Service(DichVu f)
        {
            InitializeComponent();
            Dichvu.Dichvu_User.dichvu = f.MaDV;
            lb_madichvu.Text = f.MaDV;
            lb_tendichvu.Text = f.TenDV;
            lb_gia.Text = f.Gia.ToString();
            string image1 = Path.Combine(appDirectory, f.Anh);
            pic_dichvu.Image = Image.FromFile(image1);
        }

        private void btn_mua_Click(object sender, EventArgs e)
        {
            Information_Service_Booking f = new Information_Service_Booking();
            f.Show();
        }
    }
}
