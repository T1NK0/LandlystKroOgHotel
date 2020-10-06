using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LandlystKroOgHotel
{
    public partial class SingleRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sessionValue = Session["AirconChoice"];

            //Checkker om der eksistere en session.
            if (sessionValue != null)
            {
                //parser session varibalen til en streng
                string value = (string)sessionValue;

                //Skal vælge alle værelser som har aircondition hvis knappen yes, er trykket af i listen. Hvis nej er trykket skal den vælge alle uden aircon.
                //SelectSingleRoomWithAircon();

                //Tøm sessionen via Session.Clear()
                Session.Clear();
            }
            else if (sessionValue == null)
            {
                //parser session varibalen til en streng
                string value = (string)sessionValue;

                //Skal vælge alle værelser som har aircondition hvis knappen yes, er trykket af i listen. Hvis nej er trykket skal den vælge alle uden aircon.
                //SelectSingleRoomWithoutAircon();

                //Tøm sessionen via Session.Clear()
                Session.Clear();
            }
        }

        protected void ButtonCreateReservation_Click(object sender, EventArgs e)
        {
            string customerFirstName = nameSingleRoom.Text.ToString();
            string customerLastname = customerLastname.Text.ToString();
            string customerAddress = addressSingleRoom.Text.ToString();
            int customerZipCode = int.Parse(zipCodeSingleRoom.Text);
            string customerCity = citySingleRoom.Text.ToString();
            int customerPhoneNumber = int.Parse(phoneNumberSingleRoom.Text);
            string customerEmailAddress = eMailAddressSingleRoom.Text.ToString();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LandlystConnectionString"].ToString());
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;

            //Insert into user
            cmd.CommandText = @"INSERT INTO Customer (Firstname, Lastname, Address, PostalNumb, CityName, Telephone, Email) VALUES (@Firstname, @Lastname, @Address, @PostalNumb, @City, @Telephone,  @Email)";
            cmd.Parameters.AddWithValue("@Firstname", TextBoxFirstName.Text);
            cmd.Parameters.AddWithValue("@Lastname", TextBoxLastName.Text);
            cmd.Parameters.AddWithValue("@Address", TextBoxAddress.Text);
            cmd.Parameters.AddWithValue("@PostalNumb", TextBoxPostal.Text);
            cmd.Parameters.AddWithValue("@City", TextBoxCity.Text);
            cmd.Parameters.AddWithValue("@Telephone", TextBoxTelephone.Text);
            cmd.Parameters.AddWithValue("@Email", TextBoxEmail.Text);

            cmd.CommandText = @"INSERT INTO Reservation () VALUES ()";

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
            Response.Redirect("Default.aspx");
        }

        protected void RadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["AirconChoice"] = RadioButtonList.ToString();
        }
    }
}