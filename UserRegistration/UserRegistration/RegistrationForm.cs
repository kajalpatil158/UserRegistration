using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class RegistrationForms
    {
        string First_Name = "^[a-zA-Z]{1,}$";
        string Last_Name = "^[A-Z]{1}[A-Za-z]{2,}$";
        string Email_Id = "^[a-z0-9A-Z]+([.#_+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})*$";
        string Mobile_Number = "^[91]{2}[ ][0-9]{10,10}$";
        string PassWord = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&-+=()])(?=\\S+$).{8,}$";

        //public bool ValidFirstName(string firstname) => Regex.IsMatch(firstname, First_Name);
        //public bool ValidLastName(string lastname) => Regex.IsMatch(lastname, Last_Name);
        //public bool ValidEmail(string email) => Regex.IsMatch(email, Email_Id);
        //public bool ValidMobileNumber(string mobile_number) => Regex.IsMatch(mobile_number, Mobile_Number);
        //public bool ValidPassord(string password) => Regex.IsMatch(password, PassWord);
    

       public  bool ValidFirstName(string firstname)
        {
            try
            {
                if (Regex.IsMatch(firstname, First_Name))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistrationException.ExcetionType.InvalidFirstName, "Sorry Invalid First Name");
            }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }

        }

        public bool ValidLastName(string lastname)
        {
            try
            {
                if (Regex.IsMatch(lastname, Last_Name))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistrationException.ExcetionType.InvalidLastName, "Sorry Invalid Last Name");
            }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }

        }

        public bool ValidEmail(string email)
        {
            try
            {
                if (Regex.IsMatch(email, Email_Id))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistrationException.ExcetionType.InvalidEmail, "Sorry Invalid Email_Id");
            }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }

        }

        public bool ValidMobileNumber(string mobile_number)
        {
            try
            {
                if (Regex.IsMatch(mobile_number, Mobile_Number))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistrationException.ExcetionType.InvalidMobileNumber, "Sorry Invalid Mobile Number");
            }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }

        }

        public bool ValidPassord(string password)
        {
            try
            {
                if (Regex.IsMatch(password, PassWord))
                    return true;
                else
                    throw new UserRegistrationException(UserRegistrationException.ExcetionType.InvalidPassword, "Sorry Invalid Password");
            }
            catch (UserRegistrationException ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }

        }

    }
}