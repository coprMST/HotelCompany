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
        public static string UserID { get; set; }
        public static string UserName { get; set; }
        public static int UserAccess { get; set; }

        public static string DataSource = "localhost";
        public static string InitialCatalog = "HiltonCompany";
        Button lastUsedButton { get; set; }

        private int x = 0; 
        private int y = 0;

        public MainForm()
        {
            InitializeComponent();
            lastUsedButton = goToHome;
            OpenMainPage();
        }

        private void headPanel_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void headPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Location = new Point(Location.X + (e.X - x), Location.Y + (e.Y - y));
            }
        }

        private void goToExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToMaximizedApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
            workPanel.Controls.Add(childForm);
            workPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ColorSwitcher(object sender)
        {
            Button btSender = (Button)sender;

            if (Size != new Size (1200, 800)) 
                Size = new Size(1200, 800);
            lastUsedButton.BackColor = Color.FromArgb(140, 179, 247);
            lastUsedButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            lastUsedButton.Enabled = true;

            btSender.BackColor = Color.FromArgb(211, 227, 252);
            btSender.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            btSender.Enabled = false;
            if (btSender.Name == "goToSettings")
                Size = new Size(600, 800);
            if (btSender.Name == "goToHotelRooms")
                Size = new Size(1393, 800);

            lastUsedButton = btSender;
        }

        private void mainLogo_Click(object sender, EventArgs e)
        {
            ColorSwitcher(goToHome);
            OpenChildForm(new Home());
        }

        private void goToHome_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
            OpenChildForm(new Home());
        }

        private void goToHotelRooms_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Rooms());
            ColorSwitcher(sender);
        }

        private void goToOrders_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
        }

        private void goToGuests_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
        }

        private void goToEmployees_Click(object sender, EventArgs e)
        {
            ColorSwitcher(sender);
        }

        private void goToLogIn_Click(object sender, EventArgs e)
        {
            Form authorization = new Authorization();
            this.Hide();
            authorization.Show();

            UserID = null;
            UserName = null;
            UserAccess = 0;
        }

        private void goToLogOut_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            goToLogIn.Visible = true;
            UserID = null;
            UserName = null;
            UserAccess = 0;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = DateTime.Now.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (UserID != null)
            {
                goToLogIn.Visible = false;
                loginPanel.Visible = true;
                myName.Text = UserName;
                
                if (UserAccess == 1)
                {
                    goToEmployees.Visible = true;
                    goToGuests.Visible = true;
                    goToOrders.Visible = true;
                }
                else
                {
                    goToEmployees.Visible = false;
                    goToGuests.Visible = false;
                    goToOrders.Visible = false;
                }
            }
            else
            {
                goToLogIn.Visible = true;
                loginPanel.Visible = false;
            }
        }

        private void goToSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Settings());
            ColorSwitcher(sender);
        }
    }
}
