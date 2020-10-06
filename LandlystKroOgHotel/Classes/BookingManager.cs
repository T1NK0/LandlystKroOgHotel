using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LandlystKroOgHotel.Classes
{
    public class BookingManager
    {
        SQL sql = new SQL();

        public void CreateUser(string UIFirstname, string UILastname, string UIAddress, string UIPostalNumb, string UICity, string UITelephone, string UIEmail)
        {
            sql.CreateUser(UIFirstname, UILastname, UIAddress, UIPostalNumb, UICity, UITelephone, UIEmail);
        }

        public void CreateBooking(string customerFirstName, string customerLastname, string checkIn, string checkOut)
        {
            sql.CreateBooking(customerFirstName, customerLastname, checkIn, checkOut);
        }
    }
}