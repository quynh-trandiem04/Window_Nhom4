using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window.UI_Giaodien
{
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }
        Image[] iHome = new Image[3];
        Image[] iButton = new Image[3];
        int dem = 0;
        private void HienThi(int dem)
        {
            picHome.BackgroundImage = iHome[dem];
            btnPic1.BackgroundImage = iButton[1];
            btnPic2.BackgroundImage = iButton[1];
            btnPic3.BackgroundImage = iButton[1];
            if (dem == 0)
                btnPic1.BackgroundImage = iButton[0];
            else if (dem == 1)
                btnPic2.BackgroundImage = iButton[0];
            else
                btnPic3.BackgroundImage = iButton[0];
        }
        private void UC_Home_Load(object sender, EventArgs e)
        {
            iButton[0] = global::Window.Properties.Resources.circle1;
            iButton[1] = global::Window.Properties.Resources.circle2;

            iHome[0] = global::Window.Properties.Resources.Homes1;
            iHome[1] = global::Window.Properties.Resources.Homes2;
            iHome[2] = global::Window.Properties.Resources.Homes3;

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dem %= 3;
            HienThi(dem);
            dem++;
        }

        private void btnPic1_Click(object sender, EventArgs e)
        {
            dem = 0;
            HienThi(dem);
        }

        private void btnPic2_Click(object sender, EventArgs e)
        {
            dem = 1;
            HienThi(dem);
        }

        private void btnPic3_Click(object sender, EventArgs e)
        {
            dem = 2;
            HienThi(dem);
        }
    }
}
