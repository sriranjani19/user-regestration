
   
using System;
using System.Text.RegularExpressions;

namespace UserLastName
{
    class program
    {
        public class Pattern
        {
            public static string Regex_Pattern = "^[A-Z]{1}[a-z]{4}$";
            public bool DeterminingName(string LastName)
            {
                return Regex.IsMatch(Regex_Pattern, LastName);
            }
        }
        public static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter your Last Name");
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

