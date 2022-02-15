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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private async void goToCheckPassword_Click(object sender, EventArgs e)
        {
            goToCheckPassword.Enabled = false;
            passwordBox.UseSystemPasswordChar = false;
            await Task.Delay(2000);
            passwordBox.UseSystemPasswordChar = true;
            goToCheckPassword.Enabled = true;
        }

        private void goToLogIn_Click(object sender, EventArgs e)
        {
            string login = loginBox.Text.ToLower();
            string password = passwordBox.Text.ToLower();
        }

        private void CheckCorrectInsert(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Space) { }
            else e.Handled = true;
        }

        private void goToClear_Click(object sender, EventArgs e)
        {
            loginBox.Text = string.Empty;
            passwordBox.Text = string.Empty;
        }
    }
}
