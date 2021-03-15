using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class RegistrationForms
    {
        string First_Name = "^[A-Z]{1}[A-Za-z]{2,}$";
        string Last_Name = "^[A-Z]{1}[A-Za-z]{2,}$";
        string Email_Id = "^[a-z0-9A-Z]+([.#_+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})*$";
        string Mobile_Number = "^[91]{2}[ ][0-9]{10,10}$";

        string PassWord = "^[\\S]{8,}$";
        public bool ValidFirstName(string firstname) => Regex.IsMatch(firstname, First_Name);
        public bool ValidLastName(string lastname) => Regex.IsMatch( lastname, Last_Name);
        public bool ValidEmail(string email) => Regex.IsMatch(email, Email_Id);
        public bool ValidMobileNumber(string mobile_number) => Regex.IsMatch(mobile_number, Mobile_Number);
        public bool ValidPassord(string password) => Regex.IsMatch(password, PassWord);
    }
}
