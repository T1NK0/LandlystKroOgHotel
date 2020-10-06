using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LandlystKroOgHotel
{
    public class Customer
    {
        /*FIELDS*/
        private string firstName;
        private string lastName;
        private string address;
        private string postalNumber;
        private string telephoneNumber;
        private string email;

        /*CONSTRUCTOR*/
        public Customer()
        {
            
        }

        /*PROPERTIES*/
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
    }
}