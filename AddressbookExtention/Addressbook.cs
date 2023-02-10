using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AddressbookExtention
{
    public class Addressbook
    {
        public Dictionary<string, Contacts> addressbook = new Dictionary<string, Contacts>();
        public void CreateContact(string firstName, string lastName, string address, string city, string state, string email, int zip, int phoneNum)
        {
            Contacts contact = new Contacts(firstName, lastName, address, city, state, email, zip, phoneNum);

            addressbook.Add(contact.Firstname, contact);
            Console.WriteLine("Added Succesfully");

        }
    }
}
