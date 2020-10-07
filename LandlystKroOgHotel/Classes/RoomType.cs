using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LandlystKroOgHotel.Classes
{
    public class RoomType
    {
        /*FIELDS*/
        private int roomTypeID;
        private string roomTypeName;

        /*CONSTRUCTOR*/
        public RoomType()
        {

        }

        /*PROPERTIES*/
        public int RoomTypeID
        {
            get { return RoomTypeID; }
            set { roomTypeID = value; }
        }
        public string RoomTypeName
        {
            get { return roomTypeName; }
            set { roomTypeName = value; }
        }
    }
}