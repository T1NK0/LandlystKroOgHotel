using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LandlystKroOgHotel.Classes
{
    public class Equipment
    {
        /*FIELDS*/
        private int equipmentID;
        private string equipmentName;

        /*CONSTRUCTOR*/
        public Equipment()
        {
            
        }


        /*PROPERTIES*/
        public int EquipmentID
        {
            get { return equipmentID; }
            set { equipmentID = value; }
        }
        public string EquipmentName
        {
            get { return equipmentName; }
            set { equipmentName = value; }
        }
    }
}