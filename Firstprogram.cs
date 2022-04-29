
using System;
using System.Text.RegularExpressions;

namespace UserFirstName
{
    class program
    {
        public class Pattern
        {
            public static string Regex_Pattern = "^[A-Z]{1}[a-z]{4}$";
            public bool DeterminingName(string firstName)
            {
                return Regex.IsMatch(Regex_Pattern, firstName);
            }
        }
        public static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter your First Name");
            string Value = Console.ReadLine();
            bool match = pattern.DeterminingName(Value);
            if (match)
                Console.WriteLine("Pattern Matched");
            else
            {
                Console.WriteLine("Pattern not matched");
            }
        }
    }
}
