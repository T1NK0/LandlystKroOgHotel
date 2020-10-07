using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LandlystKroOgHotel.Classes
{
    public class BookingManager
    {
        SQL sql = new SQL();
        //public List<Customer> customers = new List<Customer>();

        public /*Customer*/ void CreateCustomer(string UIFirstname, string UILastname, string UIAddress, string UIPostalNumb, string UICity, string UITelephone, string UIEmail)
        {
            Customer addCustomer = new Customer(UIFirstname, UILastname, UIAddress, UIPostalNumb, UICity, UITelephone, UIEmail);
            sql.CreateCustomer(addCustomer.FirstName, addCustomer.LastName, addCustomer.Address, addCustomer.PostalNumber, addCustomer.City, addCustomer.TelephoneNumber, addCustomer.Email);
        }

        public void CreateBooking(string checkIn, string checkOut, string roomID, string customerID)
        {
            sql.CreateBooking(checkIn, checkOut, roomID, customerID);
        }

        public void SelectRoomsWithAircon()
        {
            sql.SelectSingleRoomWithAircon();
        }

        public void SelectRoomsWithoutAircon()
        {
            sql.SelectSingleRoomWithoutAircon();
        }
    }
}