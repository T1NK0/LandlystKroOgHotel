using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Web;

namespace LandlystKroOgHotel
{
    public class SQL
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LandlystConnectionString"].ToString());
        SqlCommand sqlCommand = new SqlCommand();
        SqlDataReader dataReader;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt;

        public void CreateRoomType()
        {
            sqlCommand.Connection = conn;

            sqlCommand.CommandText = @"INSERT INTO RoomType(RoomTypeID, RoomTypeName)
            VALUES
            (1, 'Single'),
            (2, 'Double'),
            (3, 'LuxuryDouble'),
            (4, 'Suite'),
            (5, 'ConferenceRoom')";

            conn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            conn.Close();
        }

        public void CreateEquipment()
        {
            sqlCommand.Connection = conn;

            sqlCommand.CommandText = @"INSERT INTO Equipment(EquipmentID, EquipmentName)
            VAlUES
            (1, 'Aircondition'),
            (2, 'Jacuzzi'),
            (3, 'Balchony')";

            conn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            conn.Close();
        }

        public void CreateRoom()
        {
            sqlCommand.Connection = conn;

            sqlCommand.CommandText = @"INSERT INTO Room (RoomID, RoomNumber, RoomPrice, RoomDescription, RoomTypeID, EquipmentID)
            VALUES
            (1, 100, 795, 'Flot lækkert enkeltværelse', 1, NULL),
            (2, 101, 795, 'Flot lækkert enkeltværelse', 1, NULL),
            (3, 102, 795, 'Flot lækkert enkeltværelse', 1, NULL),
            (4, 103, 795, 'Flot lækkert enkeltværelse', 1, NULL),
            (5, 104, 795, 'Flot lækkert enkeltværelse', 1, NULL),
            (6, 105, 795, 'Flot lækkert enkeltværelse', 1, NULL),
            (7, 106, 845, 'Flot lækkert enkeltværelse', 1, 1),
            (8, 107, 845, 'Flot lækkert enkeltværelse', 1, 1),
            (9, 108, 845, 'Flot lækkert enkeltværelse', 1, 1),
            (10, 109, 845, 'Flot lækkert enkeltværelse', 1, 1),
            (11, 110, 845, 'Flot lækkert enkeltværelse', 1, 1),
            (12, 111, 845, 'Flot lækkert enkeltværelse', 1, 1)";

            conn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            conn.Close();
        }

        public void SelectAllSingleRoomsWithAircon()
        {
            sqlCommand.Connection = conn;

            sqlCommand.CommandText = @"SELECT RoomNumber FROM Room
            INNER JOIN RoomType ON Room.RoomTypeID = RoomType.RoomTypeID
            INNER JOIN Equipment ON Room.EquipmentID = Equipment.EquipmentID
            WHERE RoomType.RoomTypeID = 1 AND Equipment.EquipmentID = 1";

            conn.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            conn.Close();
        }

        public DataTable SelectAllSingleRoomsWithoutAircon()
        {
            sqlCommand.Connection = conn;

            sqlCommand.CommandText = @"SELECT RoomNumber FROM Room
            INNER JOIN RoomType ON Room.RoomTypeID = RoomType.RoomTypeID
            WHERE RoomType.RoomTypeID = 1 AND Room.EquipmentID IS NULL";

            conn.Open();
            da.SelectCommand = sqlCommand;
            dataReader = sqlCommand.ExecuteReader();
            dataReader.Close();
            da.Fill(dt);
            conn.Close();
            da.Dispose();
            return dt;
        }

        public void CreateCustomer(string UIFirstname, string UILastname, string UIAddress, string UIPostalNumb, string UICity, string UITelephone, string UIEmail) //UI = UserInput
        {
            sqlCommand.Connection = conn;

            sqlCommand.CommandText = @"INSERT INTO Customer (Firstname, Lastname, Address, PostalNumb, CityName, Telephone, Email) VALUES (@Firstname, @Lastname, @Address, @PostalNumb, @City, @Telephone,  @Email)";
            sqlCommand.Parameters.AddWithValue("@Firstname", UIFirstname);
            sqlCommand.Parameters.AddWithValue("@Lastname", UILastname);
            sqlCommand.Parameters.AddWithValue("@Address", UIAddress);
            sqlCommand.Parameters.AddWithValue("@PostalNumb", UIPostalNumb);
            sqlCommand.Parameters.AddWithValue("@City", UICity);
            sqlCommand.Parameters.AddWithValue("@Telephone", UITelephone);
            sqlCommand.Parameters.AddWithValue("@Email", UIEmail);

            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void CreateBooking(string checkIn, string checkOut, string roomID, string customerID)
        {
            sqlCommand.Connection = conn;

            //EXAMPLE
            //INSERT INTO Reservation(CheckIn, CheckOut, RoomID, CustomerID) VALUES('20200715', '20200720', 1, 1);

            //Find Customer ID
            //cmd.CommandText = "SELECT customerID FROM customer WHERE email = @email";

            //conn.Open();
            //SqlDataReader reader = sqlCommand.ExecuteReader();
            //while (reader.Read())
            //{
            //    Customer.CustomerID = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("customerID")));
            //}
            //conn.Close();
            //cmd.Parameters.Clear();

            sqlCommand.CommandText = @"INSERT INTO Customer (CheckIn, CheckOut, RoomID, CustomerID) VALUES (@CheckIn, @CheckOut, @RoomID, @CustomerID)";
            sqlCommand.Parameters.AddWithValue("@CheckIn", checkIn);
            sqlCommand.Parameters.AddWithValue("@CheckOut", checkOut);
            sqlCommand.Parameters.AddWithValue("@RoomID", roomID);
            sqlCommand.Parameters.AddWithValue("@CustomerID", customerID);


            conn.Open();
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public void SelectCustomerInfo()
        {
            sqlCommand.Connection = conn;

            sqlCommand.CommandText = @"SELECT * FROM Customer";
        }
    }
}