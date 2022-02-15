using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HiltonCompany
{
    public partial class MainForm : Form
    {
        public static string UserName { get; set; }
        public static string UID { get; set; }

        private int x = 0; 
        private int y = 0;

        public MainForm()
        {
            InitializeComponent();
            OpenMainPage();
        }

        private void headPanel_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void headPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }

        private void goToExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToMaximizedApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void OpenMainPage()
        {
            ColorSwitcher(goToHome);
            OpenChildForm(new Home());
        }

        private void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            workPanel.AutoScroll = true;
            workPanel.Controls.Add(childForm);
            workPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ColorSwitcher(object sender)
        {
            Button btSender = (Button)sender;

            goToHome.BackColor = Color.FromArgb(140, 179, 247);
            goToHome.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            goToHotelRooms.BackColor = Color.FromArgb(140, 179, 247);
            goToHotelRooms.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            goToOrders.BackColor = Color.FromArgb(140, 179, 247);
            goToOrders.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            goToGuests.BackColor = Color.FromArgb(140, 179, 247);
            goToGuests.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            goToEmployees.BackColor = Color.FromArgb(140, 179, 247);
            goToEmployees.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            goToLogIn.BackColor = Color.FromArgb(17, 77, 151);
            goToLogIn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            goToLogIn.ForeColor = Color.FromArgb(255, 255, 255);
            goToLogIn.IconColor = Color.FromArgb(255, 255, 255);

            btSender.BackColor = Color.FromArgb(211, 227, 252);
            btSender.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            if (btSender.Text == "Войти")
            {
                goToLogIn.ForeColor = Color.FromArgb(17, 77, 151);
                goToLogIn.IconColor = Color.FromArgb(17, 77, 151);
            }
        }

        private void mainLogo_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 800);
            ColorSwitcher(goToHome);
            OpenChildForm(new Home());
        }

        private void goToHome_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 800);

            ColorSwitcher(sender);
            OpenChildForm(new Home());
        }

        private void goToHotelRooms_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 800);

            ColorSwitcher(sender);
        }

        private void goToOrders_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 800);

            ColorSwitcher(sender);
        }

        private void goToGuests_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 800);

            ColorSwitcher(sender);
        }

        private void goToEmployees_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1200, 800);

            ColorSwitcher(sender);
        }

        private void goToLogIn_Click(object sender, EventArgs e)
        {
            this.Size = new Size(830, 740);

            ColorSwitcher(sender);
            OpenChildForm(new Authorization());
        }
    }
}
