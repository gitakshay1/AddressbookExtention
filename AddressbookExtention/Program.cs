using System.Net;

namespace AddressbookExtention
{
    public class Program
    {
        static void Main(string[] args)
        {
            Addressbook book= new Addressbook();
            Console.WriteLine("Enter Choise number\n1 Csv File");
            int choise=Convert.ToInt32(Console.ReadLine());
            switch(choise)
            {
                case 1:
                    Console.WriteLine("Enter FirstName");
                    string FirstName = Console.ReadLine();
                    Console.WriteLine("Enter LastName");
                    string LastName = Console.ReadLine();
                    Console.WriteLine("Enter Address");
                    string Address = Console.ReadLine();
                    Console.WriteLine("Enter City");
                    string City = Console.ReadLine();
                    Console.WriteLine("Enter State");
                    string State = Console.ReadLine();
                    Console.WriteLine("Enter Zip");
                    int Zip = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Eamil");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Enter PhoneNumber");
                    int PhoneNum = Convert.ToInt32(Console.ReadLine());
                    book.CreateContact(FirstName, LastName, Address, City, State, Email, Zip, PhoneNum);
                    CsvFileOperations csvFileOperations=new CsvFileOperations();
                    csvFileOperations.WriteToFile(book.addressbook);
                    csvFileOperations.ReadFromFile();
                    break;

            }
        }
    }
}
