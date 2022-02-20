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
        public string HotelID { get; set; }
        public string HotelRoomID { get; set; }
        public string HotelSite { get; set; }
        string SelectedHotelRoomID { get; set; }
        decimal SelectedPriceHotelRoom { get; set; }

        public Rooms()
        {
            InitializeComponent();
            UpdateCountries();
            hotelPanel.Size = new Size(1128, 102);
            roomPanel.Size = new Size(1128, 170);
            datePicker2.Value = DateTime.Today.AddDays(1);
            datePicker1.Value = DateTime.Today;
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
            DataTable dataTable = GetData($"select HotelName, StarsAmount from Hotels where Country = '{goToSelectCountry.SelectedItem}' and City = '{goToSelectCity.SelectedItem}'");

            goToSelectHotel.SelectedIndex = -1;
            goToSelectHotel.Items.Clear();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                string temp = dataTable.Rows[i][1].ToString() + " ★ " +  dataTable.Rows[i][0].ToString();
                goToSelectHotel.Items.Add(temp);
            }
            goToSelectHotel.Enabled = true;
        }

        private void goToSelectHotel_SelectedValueChanged(object sender, EventArgs e)
        {
            goToUpDownHotel.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleUp;

            if (goToSelectHotel.SelectedIndex != -1)
            {
                // Получение ID гостиницы
                DataTable dataTable = GetData($"select HotelID from Hotels where HotelName = '{goToSelectHotel.SelectedItem.ToString().Substring(4)}'");
                HotelID = dataTable.Rows[0][0].ToString();

                // Работа с основной информацией о гостинице
                dataTable = GetData($"select HotelName, StarsAmount, RoomsAmount, Phone, Email, FullAddress, [Site] from Hotels where HotelID = '{HotelID}'");
                addressLabel.Text = "по адресу: " + dataTable.Rows[0][5].ToString();
                aboutHotelLabel.Text = "";
                aboutHotelLabel.Text += $"Общее количество комнат: {dataTable.Rows[0][2]}\nТелефон: {dataTable.Rows[0][3]}\nЭлектронная почта: {dataTable.Rows[0][4]}";
                siteHotel.Text = "Узнать подробнее о гостинице (кликабельно)";
                HotelSite = dataTable.Rows[0][6].ToString();
                // Графический расчет количества звёзд гостиницы по 5-ой шкале
                int countStars = Convert.ToInt32(dataTable.Rows[0][1].ToString());
                string stars = string.Empty;
                for (int i = 0; i < 5; i++)
                {
                    if (countStars >= i + 1)
                        stars += "★";
                    else
                        stars += "☆";
                }
                firstLineAboutHotel.Text = "Гостиница «" + goToSelectHotel.SelectedItem.ToString().Substring(4) + "» с рейтингом " + stars + $" ({countStars}/5)";
                // Получение минимальной цены за номер в отеле 
                dataTable = GetData($"select min(Price) from HotelRooms where HotelID = '{HotelID}'");
                minPrice.Text = "От " + dataTable.Rows[0][0].ToString().Substring(0, dataTable.Rows[0][0].ToString().Length - 3) + " руб";

                // Получение информации об услугах гостиницы
                dataTable = GetData($"select ServiceName, StandartPrice from HotelServices inner join [Services] on HotelServices.ServiceID = [Services].ServiceID where HotelServices.HotelID = '{HotelID}'");
                if (dataTable.Rows.Count != 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                        servicesList.Text += "✔ " + dataTable.Rows[i][0].ToString() + "   ";
                    
                    label4.Visible = true;
                    servicesList.Visible = true;
                }
                else
                {
                    label4.Visible = false;
                    servicesList.Visible = false;
                }


                // Получение фотографий о гостинице
                dataTable = GetData($"select [Source], Comment from HotelPhotos where HotelID = '{HotelID}'");
                if (dataTable.Rows.Count != 0)
                {
                    photoPanel.Controls.Clear();
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        var pn = new Panel();
                        pn.BackColor = Color.FromArgb(140, 179, 247);
                        pn.Size = new Size(345, 240);
                        photoPanel.Controls.Add(pn);

                        var pb = new PictureBox();
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Size = new Size(345, 200);
                        pb.LoadAsync(@"Images\" + dataTable.Rows[i][0].ToString());
                        pn.Controls.Add(pb);

                        var lb = new Label();
                        lb.Text = dataTable.Rows[i][1].ToString();
                        lb.Dock = DockStyle.Bottom;
                        lb.Height = 40;
                        lb.TextAlign = ContentAlignment.MiddleCenter;
                        lb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                        lb.ForeColor = Color.FromArgb(17, 77, 151);
                        lb.Margin = new Padding(0, 0, 0, -10);
                        pn.Controls.Add(lb);
                    }

                    photoPanel.Visible = true;
                }
                else
                {
                    photoPanel.Visible = false;
                }

                infoPanel.Visible = true;
                hotelPanel.Size = new Size(1128, 1024);
                goToUpDownHotel.Visible = true;
                roomPanel.Size = new Size(1128, 170);
                goToUpDownRoom.Visible = false;

                OpenChooseRoom();
            }
            else
            {
                hotelPanel.Size = new Size(1128, 102);
                goToUpDownHotel.Visible = false;
                infoPanel.Visible = false;
                roomPanel.Visible = false;
            }
        }

        private void OpenChooseRoom()
        {
            roomPanel.Location = new Point(12, 1070);
            roomPanel.Visible = true;
        }

        private void goToUpDownHotel_Click(object sender, EventArgs e)
        {
            if (goToUpDownHotel.IconChar == FontAwesome.Sharp.IconChar.AngleDoubleUp)
            {
                goToUpDownHotel.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleDown;
                hotelPanel.Size = new Size(1128, 162);
                infoPanel.Visible = false;
                roomPanel.Location = new Point(12, 100);
            }
            else
            {
                goToUpDownHotel.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleUp;
                hotelPanel.Size = new Size(1128, 1024);
                goToUpDownHotel.Visible = true;
                infoPanel.Visible = true;
                roomPanel.Location = new Point(12, 770);
            }
        }

        private void siteHotel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(HotelSite);
        }

        private void datePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (datePicker2.Value <= datePicker1.Value)
            {
                datePicker2.Value = DateTime.Today.AddDays(1);
                datePicker1.Value = DateTime.Today;
                MessageBox.Show("Указана некорректная дата", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateRooms();
        }

        private void UpdateRooms()
        {
            // Получение фотографий о гостинице
            DataTable dataTable = GetData($"select HotelRoomID, RoomName, NumberOfBeds, NumberOfFloors, NumberOfRooms, RoomPhoto, Price from HotelRooms where HotelID = '{HotelID}'");
            if (dataTable.Rows.Count != 0)
            {
                List<string> banList = new List<string>();
                roomsPanel.Controls.Clear();
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    var pn = new Panel();
                    pn.BackColor = Color.FromArgb(140, 179, 247);
                    pn.Size = new Size(345, 280);
                    roomsPanel.Controls.Add(pn);

                    var pb = new PictureBox();
                    pb.Dock = DockStyle.Top;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Size = new Size(345, 200);
                    pb.LoadAsync(@"Images\" + dataTable.Rows[i][5].ToString());
                    pn.Controls.Add(pb);

                    var lb = new Label();
                    lb.Text = dataTable.Rows[i][1].ToString();
                    lb.Dock = DockStyle.Top;
                    lb.Height = 40;
                    lb.TextAlign = ContentAlignment.MiddleCenter;
                    lb.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                    lb.ForeColor = Color.FromArgb(17, 77, 151);
                    lb.Margin = new Padding(0, 0, 0, -10);
                    pn.Controls.Add(lb);

                    var bt = new Button();
                    decimal money = Convert.ToDecimal(dataTable.Rows[i][6]);
                    TimeSpan daysAmount = datePicker2.Value - datePicker1.Value;
                    bt.Text = "Забронировать от " + money * Convert.ToInt32(daysAmount.Days.ToString()) + " руб";
                    bt.Click += Bt_Click;
                    bt.Height = 40;
                    bt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
                    bt.ForeColor = Color.FromArgb(17, 77, 151);
                    SelectedHotelRoomID = dataTable.Rows[i][0].ToString();
                    SelectedPriceHotelRoom = money * Convert.ToInt32(daysAmount.Days.ToString());
                    bt.Dock = DockStyle.Bottom;
                    bt.Enabled = MainForm.UserID != null ? true : false;
                    pn.Controls.Add(bt);
                }

                UpDownRooms("down");
            }
        }

        private void goToCheckRooms_Click(object sender, EventArgs e)
        {
            UpdateRooms();
        }

        private void Bt_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = GetData($"select CustomerID from Customers where AccountID = '{MainForm.UserID}'");
                string CustomerID = dataTable.Rows[0][0].ToString();

                GetData($"insert into Orders(HotelRoomID, CustomerID, CheckIn, CheckOut, FinalPrice, Paid) values ('{SelectedHotelRoomID}', '{CustomerID}', '{datePicker1.Value}', '{datePicker2.Value}', '{SelectedPriceHotelRoom.ToString().Replace(',', '.')}', '0')");
                MessageBox.Show("Комната была успешно добавлена в корзину", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Button bt = (Button)sender;
                bt.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Не удалось оформить заказ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void goToUpDownRoom_Click(object sender, EventArgs e)
        {
            UpDownRooms();
        }

        private void UpDownRooms(string move = null)
        {
            goToUpDownRoom.Visible = true;

            if (goToUpDownRoom.Location == new Point(12, 100))
                roomPanel.Size = new Size(1128, 326);
            else
                roomPanel.Size = new Size(1128, 818);

            if (goToUpDownRoom.IconChar == FontAwesome.Sharp.IconChar.AngleDoubleUp)
            {
                goToUpDownRoom.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleDown;
                roomPanel.Size = new Size(1128, 230);
                roomsPanel.Visible = false;
            }
            else
                MoveDown();

            if (move == "down")
                MoveDown();

            void MoveDown()
            {
                goToUpDownRoom.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleUp;
                roomPanel.Size = new Size(1128, 818);
                roomsPanel.Visible = true;
            }
        }
    }
}
