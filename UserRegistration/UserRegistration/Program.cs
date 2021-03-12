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
            Console.WriteLine("First Name is= {0}", registration.ValidFirstName("kajal"));

            Console.WriteLine("Enter Last Name");
            string Lastname = Console.ReadLine();
            Console.WriteLine("Last Name is= {0}", registration.ValidLastName("patil"));

            Console.WriteLine("Enter Email_Id");
            string email = Console.ReadLine();
            Console.WriteLine("Email_ID is= {0}", registration.ValidEmail("kajal158@gmail.com"));

            Console.WriteLine("Enter Mobile Number");
            string mobile_number = Console.ReadLine();
            Console.WriteLine("Mobile Number is= {0}", registration.ValidEmail("8600208238"));

            Console.WriteLine("Enter Password");
            string Password = Console.ReadLine();
            Console.WriteLine("Password is= {0}", registration.ValidPassord("K@jal@2018"));

        }
    }
}
