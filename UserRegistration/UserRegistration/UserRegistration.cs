using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    class UserRegistrationException : Exception
    {
        public enum ExcetionType
        {
            InvalidFirstName,
            InvalidLastName,
            InvalidEmail,
            InvalidMobileNumber,
            InvalidPassword
        }
        private readonly ExcetionType type;
        public UserRegistrationException(ExcetionType Type,string message) : base(message)
        {
            this.type = Type;
        }
    }
}


   
        
        
      
