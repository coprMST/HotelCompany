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
using FontAwesome.Sharp;
using FontAwesome;

namespace HiltonCompany
{
    public partial class MyOrders : Form
    {
        public static string[] IDs = new string[3];

        public MyOrders()
        {
            InitializeComponent();
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

        private void Update()
        {
            DataTable dataTable = GetData($"select CustomerID from Customers where AccountID = '{MainForm.UserID}'");
            string CustomerID = dataTable.Rows[0][0].ToString();

            dataTable = GetData($"select Orders.HotelReservationID, Hotels.HotelName, HotelRooms.RoomName, Orders.CheckIn, Orders.CheckOut, FinalPrice, Paid, HotelRooms.RoomPhoto from Orders inner join HotelRooms on Orders.HotelRoomID = HotelRooms.HotelRoomID inner join Hotels on HotelRooms.HotelID = Hotels.HotelID where Orders.CustomerID = '{CustomerID}' and Paid = '0'");

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    if (dataTable.Rows[i][2] != null)
                    {
                        (Controls["nameHotel" + (i + 1).ToString()] as Label).Text = "Отель " + dataTable.Rows[i][1].ToString();
                        (Controls["nameRoom" + (i + 1).ToString()] as Label).Text = "комната " + dataTable.Rows[i][2].ToString();
                        (Controls["price" + (i + 1).ToString()] as Label).Text = "Стоимость " + dataTable.Rows[i][5].ToString() + " руб";
                        (Controls["photoRoom" + (i + 1).ToString()] as PictureBox).ImageLocation = @"Images\" + dataTable.Rows[i][7].ToString();
                        (Controls["time" + (i + 1).ToString()] as Label).Text = "от " + Convert.ToDateTime(dataTable.Rows[i][3].ToString()).ToShortDateString() + " до " + Convert.ToDateTime(dataTable.Rows[i][4].ToString()).ToShortDateString();

                        IDs[i] = dataTable.Rows[i][0].ToString();

                        (Controls["nameHotel" + (i + 1).ToString()] as Label).Visible = true;
                        (Controls["nameRoom" + (i + 1).ToString()] as Label).Visible = true;
                        (Controls["price" + (i + 1).ToString()] as Label).Visible = true;
                        (Controls["photoRoom" + (i + 1).ToString()] as PictureBox).Visible = true;
                        (Controls["time" + (i + 1).ToString()] as Label).Visible = true;
                        (Controls["select" + (i + 1).ToString()] as IconButton).Visible = true;
                    }
                }
                catch
                {
                    (Controls["nameHotel" + (i + 1).ToString()] as Label).Visible = false;
                    (Controls["nameRoom" + (i + 1).ToString()] as Label).Visible = false;
                    (Controls["price" + (i + 1).ToString()] as Label).Visible = false;
                    (Controls["photoRoom" + (i + 1).ToString()] as PictureBox).Visible = false;
                    (Controls["time" + (i + 1).ToString()] as Label).Visible = false;
                    (Controls["select" + (i + 1).ToString()] as IconButton).Visible = false;
                }
            }

            infoAboutError.ForeColor = ((Controls["nameHotel" + 1.ToString()] as Label).Visible == false) ? Color.FromArgb(17, 77, 151) : Color.FromArgb(211, 227, 252);

            ResetCheckBoxes();
        }

        private void select1_Click(object sender, EventArgs e)
        {
            IconButton btSender = (IconButton)sender;

            if (btSender.IconChar == IconChar.Square)
                btSender.IconChar = IconChar.CheckSquare;
            else
                btSender.IconChar = IconChar.Square;
        }

        private void MyOrders_Load(object sender, EventArgs e)
        {
            Update();
        }

        private void goToPay_Click(object sender, EventArgs e)
        {
            bool presence = false;

            for (int i = 0; i < 3; i++)
            {
                if ((Controls["select" + (i + 1).ToString()] as IconButton).IconChar == IconChar.CheckSquare)
                {
                    GetData($"UPDATE Orders set Paid = '1' where HotelReservationID = '{IDs[i]}'");
                    presence = true;
                }
            }

            if (presence)
            {
                Update();
                MessageBox.Show("Заказы были успешно оплачены", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Для оплаты не были выделены заказы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetCheckBoxes()
        {
            for (int i = 0; i < 3; i++)
                (Controls["select" + (i + 1).ToString()] as IconButton).IconChar = IconChar.Square;
        }

        private void goToDelete_Click(object sender, EventArgs e)
        {
            bool presence = false;

            for (int i = 0; i < 3; i++)
            {
                if ((Controls["select" + (i + 1).ToString()] as IconButton).IconChar == IconChar.CheckSquare)
                {
                    GetData($"delete from Orders where HotelReservationID = {IDs[i]}");
                    presence = true;
                }
            }

            if (presence)
            {
                Update();
                MessageBox.Show("Заказы были успешно удалены", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Для удаления не были указаны заказы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
