using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkProprtyTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserMessages.WelcomeMessage("Welcome to the client address collection application");

            ClientAddress address = new ClientAddress();
            Console.Write("What street do you live on: ");
            address.StreetAddress = Console.ReadLine();
            Console.Write("What city do you live in: ");
            address.City = Console.ReadLine();
            Console.Write("What state do you live in: ");
            address.State = Console.ReadLine();
            Console.Write("What is your zip code: ");
            address.ZipCode = int.Parse(Console.ReadLine());

            Console.WriteLine(address.FullAddress);


            // This work but I need to add program functionality to it, so can get a person name, and also test the zipcode
            Console.ReadLine();
        }
    }
}
