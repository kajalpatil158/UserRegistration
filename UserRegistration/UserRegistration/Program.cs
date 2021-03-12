using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationForms registration = new RegistrationForms();
            Console.WriteLine("Enter First Name");
            string Firstname = Console.ReadLine();
            Console.WriteLine("First Name is= {0}", registration.ValidFirstName("Kajal"));

            Console.WriteLine("Enter Last Name");
            string Lastname = Console.ReadLine();
            Console.WriteLine("Last Name is= {0}", registration.ValidFirstName("Kajal"));
        }
    }
}
