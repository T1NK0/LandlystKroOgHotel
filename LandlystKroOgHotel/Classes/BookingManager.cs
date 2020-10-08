using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LandlystKroOgHotel.Classes
{
    public class BookingManager
    {
        SQL sql = new SQL();

        public void CreateCustomer(string UIFirstname, string UILastname, string UIAddress, string UIPostalNumb, string UICity, string UITelephone, string UIEmail)
        {
            Customer addCustomer = new Customer(UIFirstname, UILastname, UIAddress, UIPostalNumb, UICity, UITelephone, UIEmail);
            sql.CreateCustomer(addCustomer.FirstName, addCustomer.LastName, addCustomer.Address, addCustomer.PostalNumber, addCustomer.City, addCustomer.TelephoneNumber, addCustomer.Email);
        }

        public void CreateBooking(string checkIn, string checkOut, string roomID, string customerID)
        {
            sql.CreateBooking(checkIn, checkOut, roomID, customerID);
        }


        DataTable logicDT;
        List<string> roomNumberList = new List<string>();

        public List<Room> SelectRoomsWithoutAircon()
        {
            if (logicDT != null)
                logicDT.Clear();
            if (roomNumberList.Count != 0)
                roomNumberList.Clear();
            logicDT = sql.SelectAllSingleRoomsWithoutAircon();
        }

        public List<string> FillDropDown()
        {
            foreach (DataRow row in logicDT.Rows)
            {
                roomNumberList.Add(row[1].ToString());
            }
            return roomNumberList;
        }

        public void SelectRoomsWithAircon()
        {
            sql.SelectAllSingleRoomsWithAircon();
        }
    }
}