using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Window.UI.User
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            panelWidth = PanelSlide.Width;
            Hidden = false;
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            home = new UI_Giaodien.UC_Home();
            home.Dock = DockStyle.Fill;
            home.BringToFront();
            pnShow.Controls.Add(home);
        }

        int panelWidth;
        bool Hidden;
        int flag;
        UI_Giaodien.UC_Home home = new UI_Giaodien.UC_Home();
        UC_Booking booking = new UC_Booking();
        UC_Editinformation editinformation = new UC_Editinformation();
        UC_Current_Room curentroom = new UC_Current_Room();
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btn_Booking_Click(object sender, EventArgs e)
        {
            if (flag != 1) 
            {
                flag = 1;
                SidePanel.Height = btn_Booking.Height;
                SidePanel.Top = btn_Booking.Top;
                pnShow.Controls.Clear();
                booking = new UC_Booking();
                booking.Dock = DockStyle.Fill;
                booking.BringToFront();
                pnShow.Controls.Add(booking);
                pnShow.Width = 1000;
            }
            else 
            {
                booking.Refresh(); 
            }
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
        }

        private void btn_Editinformation_Click(object sender, EventArgs e)
        {
            flag = 1;
            SidePanel.Height = btn_Editinformation.Height;
            SidePanel.Top = btn_Editinformation.Top;
            pnShow.Controls.Clear();
            editinformation = new UC_Editinformation();
            editinformation.Dock = DockStyle.Fill;
            editinformation.BringToFront();
            pnShow.Controls.Add(editinformation);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            flag = 0;
            SidePanel.Height = btnHome.Height;
            SidePanel.Top = btnHome.Top;
            pnShow.Controls.Clear();
            home = new UI_Giaodien.UC_Home();
            home.Dock = DockStyle.Fill;
            home.BringToFront();
            pnShow.Controls.Add(home);
        }

        private void btn_Currentroom_Click(object sender, EventArgs e)
        {
            if (flag != 2) 
            {
                flag = 2;
                SidePanel.Height = btn_Currentroom.Height;
                SidePanel.Top = btn_Currentroom.Top;
                pnShow.Controls.Clear();
                curentroom = new UC_Current_Room();
                curentroom.Dock = DockStyle.Fill;
                curentroom.BringToFront();
                pnShow.Controls.Add(curentroom);
                pnShow.Width = 1000;
            }
            else 
            {
                curentroom.Refresh(); 
            }
        }
    }
}
