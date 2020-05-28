using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidation
    {
        private static String patternFor_Name = "^[A-Z]{1}[a-z]{3,}$";
        private static String patternFor_Email = "^[a-zA-Z0-9]+([.][a-zA-Z0-9]+)?@[a-zA-Z0-9]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2})?$";
        private static String patternFor_Mobile = "^([0-9]{2}[ ]+)?[0-9]{10}$";
        private static String patternFor_Password = "^([A-Z]{1,})*[a-zA-Z0-9]{7,}$";

        public Boolean FirstName(String firstName)
        {
            return Regex.Match(firstName, patternFor_Name).Success;
        }

        public Boolean LastName(String lastName)
        {
            return Regex.Match(lastName, patternFor_Name).Success;
        }

        public Boolean Email(String email)
        {
            return Regex.Match(email, patternFor_Email).Success;
        }

        public Boolean Mobile(String mobile)
        {
            return Regex.Match(mobile, patternFor_Mobile).Success;
        }

        public Boolean Password(String password)
        {
            return Regex.Match(password, patternFor_Password).Success;
        }
    }
}
