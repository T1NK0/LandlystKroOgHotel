using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Web;

namespace LandlystKroOgHotel
{
    public class SQL
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LandlystConnectionString"].ToString());
        SqlCommand cmd = new SqlCommand();
        public void CreateRoomType()
        {
            cmd.Connection = conn;

            cmd.CommandText = @"INSERT INTO RoomType(RoomTypeID, RoomTypeName)
            VALUES
            (1, 'Single'),
            (2, 'Double'),
            (3, 'LuxuryDouble'),
            (4, 'Suite'),
            (5, 'ConferenceRoom')";

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        public void CreateEquipment()
        {
            cmd.Connection = conn;

            cmd.CommandText = @"INSERT INTO Equipment(EquipmentID, EquipmentName)
            VAlUES
            (1, 'Aircondition'),
            (2, 'Jacuzzi'),
            (3, 'Balchony')";

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        public void CreateRoom()
        {
            cmd.Connection = conn;

            cmd.CommandText = @"INSERT INTO Room (RoomID, RoomNumber, RoomPrice, RoomDescription, RoomTypeID, EquipmentID)
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
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        public void SelectSingleRoomWithAircon()
        {
            cmd.Connection = conn;

            cmd.CommandText = @"SELECT RoomNumber FROM Room
            INNER JOIN RoomType ON Room.RoomTypeID = RoomType.RoomTypeID
            INNER JOIN Equipment ON Room.EquipmentID = Equipment.EquipmentID
            WHERE RoomType.RoomTypeID = 1 AND Equipment.EquipmentID = 1";

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        public void SelectSingleRoomWithoutAircon()
        {
            cmd.Connection = conn;

            cmd.CommandText = @"SELECT RoomNumber FROM Room
            INNER JOIN RoomType ON Room.RoomTypeID = RoomType.RoomTypeID
            WHERE RoomType.RoomTypeID = 1 AND Room.EquipmentID IS NULL";

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        public void CreateCustomer(string UIFirstname, string UILastname, string UIAddress, string UIPostalNumb, string UICity, string UITelephone, string UIEmail) //UI = UserInput
        {
            cmd.Connection = conn;

            //Insert into user
            cmd.CommandText = @"INSERT INTO Customer (Firstname, Lastname, Address, PostalNumb, CityName, Telephone, Email) VALUES (@Firstname, @Lastname, @Address, @PostalNumb, @City, @Telephone,  @Email)";
            cmd.Parameters.AddWithValue("@Firstname", UIFirstname);
            cmd.Parameters.AddWithValue("@Lastname", UILastname);
            cmd.Parameters.AddWithValue("@Address", UIAddress);
            cmd.Parameters.AddWithValue("@PostalNumb", UIPostalNumb);
            cmd.Parameters.AddWithValue("@City", UICity);
            cmd.Parameters.AddWithValue("@Telephone", UITelephone);
            cmd.Parameters.AddWithValue("@Email", UIEmail);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }

        public void CreateBooking(string checkIn, string checkOut, string roomID, string customerID)
        {
            cmd.Connection = conn;

            //EXAMPLE
            //INSERT INTO Reservation(CheckIn, CheckOut, RoomID, CustomerID) VALUES('20200715', '20200720', 1, 1);

            //SELECT STRING_AGG (column, ',') AS column FROM Table;

            cmd.CommandText = @"INSERT INTO Customer (CheckIn, CheckOut, RoomID, CustomerID) VALUES (@CheckIn, @CheckOut, @RoomID, @CustomerID)";
            cmd.Parameters.AddWithValue("@CheckIn", checkIn);
            cmd.Parameters.AddWithValue("@CheckOut", checkOut);
            cmd.Parameters.AddWithValue("@RoomID", roomID);
            cmd.Parameters.AddWithValue("@CustomerID", customerID);


            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
        }
    }
}