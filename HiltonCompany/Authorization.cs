using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HiltonCompany
{
    public partial class Authorization : Form
    {
        private int x = 0;
        private int y = 0;

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
            DataTable dataTable = new DataTable();

            if (String.IsNullOrEmpty(login))
                MessageBox.Show("Для авторизации введите номер телефона или электронную почту", "Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (String.IsNullOrEmpty(password))
                MessageBox.Show("Для авторизации введите пароль", "Примечание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (login.Contains("@"))
                {
                    dataTable = GetData($"select AccountID from Accounts where Email = '{login}' and [Password] = '{password}'");
                }
                else
                {
                    dataTable = GetData($"select AccountID from Accounts where PhoneNumber = '{login}' and [Password] = '{password}'");
                    if (dataTable.Rows.Count != 0)
                    {
                        MainForm.UserID = dataTable.Rows[0][0].ToString();
                        dataTable = GetData($"select FirstName from Customers where AccountID = '{MainForm.UserID}'");
                        MainForm.UserName = dataTable.Rows[0][0].ToString();
                        goToBackForm();
                    }
                    else
                    {
                        MessageBox.Show("Для авторизации были введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private DataTable GetData(string cmd)
        {
            string connectionString = $@"Data Source={MainForm.DataSource};Initial Catalog={MainForm.InitialCatalog};Integrated Security=True";
            
            DataTable dataTable = new DataTable();
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    // Открываем асинхронное соединение с базой данных
                    Task connectionTask = connection.OpenAsync();
                    Task.WaitAll(connectionTask);

                    // Если соединение произвелось успешно
                    if (!connectionTask.IsFaulted)
                    {
                        SqlCommand command = connection.CreateCommand();
                        command.CommandText = cmd;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            SqlDataReader DataRead = null;
                            DataRead = reader;
                            dataTable.Load(DataRead);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }

        private void goToBack_Click(object sender, EventArgs e)
        {
            goToBackForm();
        }

        private void goToBackForm()
        {
            Form mainForm = new MainForm();
            this.Close();
            mainForm.Show();
        }

        private void goToExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void goToMaximizedApp_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
    }
}
