using System;
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
    public partial class Rooms : Form
    {
        public static string HotelID { get; set; }
        public static string HotelRoomID { get; set; }

        public Rooms()
        {
            InitializeComponent();
            UpdateCountries();
            panel2.Size = new Size(1128, 102);
        }

        private void UpdateCountries()
        {
            DataTable dataTable = GetData("select distinct Country from Hotels");

            goToSelectCountry.SelectedIndex = -1;
            goToSelectCountry.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string temp = dataTable.Rows[i][0].ToString();
                goToSelectCountry.Items.Add(temp);
            }
        }

        private DataTable GetData(string cmd)
        {
            string connectionString = $@"Data Source={MainForm.DataSource};Initial Catalog={MainForm.InitialCatalog};Integrated Security=True";

            DataTable dataTable = new DataTable();
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

            return dataTable;
        }

        private void goToSelectCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dataTable = GetData("select distinct City from Hotels");

            goToSelectCity.SelectedIndex = -1;
            goToSelectCity.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string temp = dataTable.Rows[i][0].ToString();
                goToSelectCity.Items.Add(temp);
            }
            goToSelectCity.Enabled = true;
        }

        private void goToSelectCity_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable dataTable = GetData($"select HotelName from Hotels where Country = '{goToSelectCountry.SelectedItem}' and City = '{goToSelectCity.SelectedItem}'");

            goToSelectHotel.SelectedIndex = -1;
            goToSelectHotel.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string temp = dataTable.Rows[i][0].ToString();
                goToSelectHotel.Items.Add(temp);
            }
            goToSelectHotel.Enabled = true;
        }

        private void goToSelectHotel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (goToSelectHotel.SelectedIndex != -1)
            {
                DataTable dataTable = GetData($"select HotelName, StarsAmount, RoomsAmount, MinPrice, Phone, Email, FullAddress, Image1, Image2, Image3 from Hotels where HotelName = '{goToSelectHotel.SelectedItem}'");

                hotelPhoto1.ImageLocation = @"Images\" + dataTable.Rows[0][7].ToString();
                hotelPhoto2.ImageLocation = @"Images\" + dataTable.Rows[0][8].ToString();
                hotelPhoto3.ImageLocation = @"Images\" + dataTable.Rows[0][9].ToString();
                starsAmount.Text = "Количество звёзд: " + dataTable.Rows[0][1].ToString();
                addressLabel.Text = "Адрес: " + dataTable.Rows[0][6].ToString();
                infoPanel.Visible = true;
                panel2.Size = new Size(1128, 604);
                goToUpDownHotel.Visible = true;
            }
            else
            {
                panel2.Size = new Size(1128, 102);
                goToUpDownHotel.Visible = false;
                infoPanel.Visible = false;
            }
        }

        private void goToUpDownHotel_Click(object sender, EventArgs e)
        {

        }
    }
}
