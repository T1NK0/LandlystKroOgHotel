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
            string checkIn = CalendarCheckIn.SelectedDate.ToShortDateString();
            //string checkInDate;
            //string checkOutDate;
            //bm.checkInDate = CalendarCheckIn.SelectedDate.ToString("yyyy-MM-dd hh:mm:ss");
            //bm.checkOutDate = CalendarCheckOut.SelectedDate.ToString("yyyy-MM-dd hh:mm:ss");
            //string checkOut = CalendarCheckOut.SelectedDate.ToShortDateString();

            bm.CreateCustomer(customerFirstName, customerLastname, customerAddress, customerZipCode, customerCity, customerTelephone, customerEmail);

            //bm.CreateBooking(checkIn, checkOut, roomID, customerID);
        }

        protected void ACChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ACChoice.SelectedValue == "Yes")
            {
                bm.SelectRoomsWithAircon();
            }
            else if (ACChoice.SelectedValue == "No")
            {
                bm.SelectRoomsWithoutAircon();
            }
        }
    }
}