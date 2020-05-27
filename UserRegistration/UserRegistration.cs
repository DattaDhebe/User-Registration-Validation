using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidation
    {
        public static String patterFor_Name = "^[A-Z]{1}[a-z]{3,}$";

        public Boolean FirstName(String firstName)
        {
            return Regex.Match(firstName, patterFor_Name).Success;
        }

        public Boolean LastName(String lastName)
        {
            return Regex.Match(lastName, patterFor_Name).Success;
        }
    }
}
