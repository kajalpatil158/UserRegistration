using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class RegistrationForms
    {
        string First_Name = "^[A-Za-z]";
        string Last_Name = "^[A-Za-z]";
        string Email_Id = "^[a-z0-9A-Z]+([.#_+-][a-z0-9A-Z]+)*[@][a-z0-9A-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})*$";
        public bool ValidFirstName(string firstname) => Regex.IsMatch(firstname, First_Name);
        public bool ValidLastName(string lastname) => Regex.IsMatch( lastname, Last_Name);
        public bool ValidEmail(string email) => Regex.IsMatch(email, Email_Id);

    }
}
