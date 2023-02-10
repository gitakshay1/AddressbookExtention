using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace AddressbookExtention
{
    public class CsvFileOperations
    {
        private string filePath = @"C:\Users\aksha\Assignments\AddressbookExtention\AddressbookExtention\Contact.csv";
        public void WriteToFile(Dictionary<string, Contacts> addressbook)
        {
            using StreamWriter writer = new StreamWriter(filePath, true);
            foreach (KeyValuePair<string, Contacts> item in addressbook)
            {
                writer.WriteLine(item.Value.Firstname);
                writer.WriteLine(item.Value.Lastname);
                writer.WriteLine(item.Value.Address);
                writer.WriteLine(item.Value.City);
                writer.WriteLine(item.Value.State);
                writer.WriteLine(item.Value.Zip);
                writer.WriteLine(item.Value.Email);
                writer.WriteLine(item.Value.Phone);

            }
            Console.WriteLine("\nSuccessfully added to Csv file.");
            writer.Close();
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of Csv File");
            string lines = File.ReadAllText(filePath);
            Console.WriteLine(lines);
        }
    }
}
