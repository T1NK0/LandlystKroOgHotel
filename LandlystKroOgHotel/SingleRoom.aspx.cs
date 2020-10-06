using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LandlystKroOgHotel.Classes;

namespace LandlystKroOgHotel
{
    public partial class SingleRoom : System.Web.UI.Page
    {
        BookingManager bm = new BookingManager();
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCreateReservation_Click(object sender, EventArgs e)
        {
            string customerFirstName = TextBoxFirstName.Text.ToString();
            string customerLastname = TextBoxLastName.Text.ToString();
            string customerAddress = TextBoxAddress.Text.ToString();
            string customerZipCode = TextBoxPostal.Text.ToString();
            string customerCity = TextBoxCity.Text.ToString();
            string customerTelephone = TextBoxTelephone.Text.ToString();
            string customerEmail = TextBoxEmail.Text.ToString();
            string roomChoice = DropDownListRoom.SelectedIndex.ToString();
            string checkIn = CalendarCheckIn.SelectedDate.ToString();
            string checkOut = CalendarCheckOut.SelectedDate.ToString();

            bm.CreateUser(customerFirstName, customerLastname, customerAddress, customerZipCode, customerCity, customerTelephone, customerEmail);

            bm.CreateBooking(customerFirstName, customerLastname, checkIn, checkOut);
        }

        protected void RadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}