using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;

namespace LandlystKroOgHotel
{
    public class Customer
    {
        #region fields
        private string firstName;
        private string lastName;
        private string address;
        private string postalNumber;
        private string city;
        private string telephoneNumber;
        private string email;
        #endregion

        #region constructors
        public Customer()
        {

        }

        public Customer(string FirstNameInput, string LastNameInput, string AddressFamilyInput, string PostalNumberInput, string CityInput, string TelephoneNumberInput, string EmailInput)
        {
            FirstName = FirstNameInput;
            LastName = LastNameInput;
            Address = AddressFamilyInput;
            PostalNumber = PostalNumberInput;
            City = CityInput;
            TelephoneNumber = TelephoneNumberInput;
            Email = EmailInput;          
        }
        #endregion

        #region properties
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string PostalNumber
        {
            get { return postalNumber; }
            set { postalNumber = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string TelephoneNumber
        {
            get { return telephoneNumber; }
            set { telephoneNumber = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion
    }
}