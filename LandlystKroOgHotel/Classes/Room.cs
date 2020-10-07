using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LandlystKroOgHotel
{
    public class Room
    {
        /*FIELDS*/
        private int roomNumber;
        private decimal price;
        private string roomDescription;

        /*CONSTRUCTOR*/
        public Room()
        {

        }
        
        /*PROPERTIES*/
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public string RoomDecsription
        {
            get { return roomDescription; }
            set { roomDescription = value; }
        }
    }
}