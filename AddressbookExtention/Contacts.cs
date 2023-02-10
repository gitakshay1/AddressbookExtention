using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookExtention
{
    public class Contacts
    {
        public Contacts(string firstName, string lastName, string address, string city, string state, string email, int zip, int phoneNum)
        {
            Firstname = firstName;
            Lastname = lastName;
            Address = address;
            City = city;
            State = state;
            Email = email;
            Zip = zip;
            Phone= phoneNum;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
    }
}
