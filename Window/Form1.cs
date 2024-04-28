using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window.UI.User;
using Window.UI_Giaodien;

namespace Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            home = new UC_Home();
            home.Dock = DockStyle.Fill;
            home.BringToFront();
            pnShow.Controls.Add(home);
        }
        UC_Home home = new UC_Home();
        UI.User.UC_Booking booking = new UC_Booking();
        UC_Login login = new UC_Login();
        private void btnHome_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            pnShow.Controls.Clear();
            home = new UC_Home();
            home.Dock = DockStyle.Fill;
            home.BringToFront();
            pnShow.Controls.Add(home);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnbooking_Click(object sender, EventArgs e)
        {

            UC_Login loginControl = new UC_Login();

            if (loginControl.IsLoggedIn)
            {
                SidePanel.Height = btnbooking.Height;
                SidePanel.Top = btnbooking.Top;
                pnShow.Controls.Clear();
                UC_Booking booking = new UC_Booking();
                booking.Dock = DockStyle.Fill;
                booking.BringToFront();
                pnShow.Controls.Add(booking);
                pnShow.Width = 1000;
            }
            else
            {
                btnlogin_Click(sender, e);
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnlogin.Height;
            SidePanel.Top = btnlogin.Top;
            pnShow.Controls.Clear();
            UC_Login login = new UC_Login();
            login.Dock = DockStyle.Fill;
            pnShow.Controls.Add(login);
            login.Show();
        }
    }
}
