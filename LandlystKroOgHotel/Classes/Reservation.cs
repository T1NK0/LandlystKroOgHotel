using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LandlystKroOgHotel
{
    public class Reservation
    {
        /*FIELDS*/
        private string checkinDate;
        private string checkoutDate;

        

        /*CONSTRUCTOR*/
        public Reservation()
        {
            
        }

        /*PROPERTIES*/
        public string CheckinDate
        {
            get { return checkinDate; }
            set { checkinDate = value; }
        }
        public string CheckoutDate
        {
            get { return checkoutDate; }
            set { checkoutDate = value; }
        }
    }
}