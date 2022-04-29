using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace validate
{
    public class RegValidation
    {

        public static string VALIDNAMEPATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public static string EMAILPATTERN = "^[a-zA-Z0-9]{3,20}@gmail.com$";
        public static string MOBILEPATTERN = "^[0-9]{2}[ ][0-9]{10}$";
        public static string PASSWORDRULE = "^(?=.*[A-Z])(?=.*[@#$%&*!_.-=])(?=.*[0-9])[a-zA-Z0-9].{8,}$";

        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        }

        public bool validateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, VALIDNAMEPATTERN);
        }

        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, EMAILPATTERN);
        }

        public bool validateMobileFormat(string mobileFormat)
        {
            return Regex.IsMatch(mobileFormat, MOBILEPATTERN);
        }

        public bool validatePreDefinedPassword(string preDefinedPassword)
        {
            return Regex.IsMatch(preDefinedPassword, PASSWORDRULE);
        }

        public Func<string, bool> isValidFirstName = firstName => Regex.IsMatch(firstName, VALIDNAMEPATTERN);
        public Func<string, bool> isValidLastName = lastName => Regex.IsMatch(lastName, VALIDNAMEPATTERN);
        public Func<string, bool> isValidEmail = email => Regex.IsMatch(email, EMAILPATTERN);
        public Func<string, bool> isValidMobileNumber = mobileFormat => Regex.IsMatch(mobileFormat, MOBILEPATTERN);
        public Func<string, bool> isValidPassword = preDefinedPassword => Regex.IsMatch(preDefinedPassword, PASSWORDRULE);

    }
}

