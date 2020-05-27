using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserValidation
    {

        public static String patterFor_firstName = "^[A-Z]{1}[a-z]{3,}$";

        public Boolean FirstName(String firstName)
        {
            return Regex.Match(firstName, patterFor_firstName).Success;
        }
    }
}
