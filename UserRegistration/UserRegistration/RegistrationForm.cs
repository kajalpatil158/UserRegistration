using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class RegistrationForms
    {
        string First_Name = "^[A-Za-z]";
        public bool ValidFirstName(string firstname) => Regex.IsMatch(firstname, First_Name);

    }
}
