ss
   
using System;
using System.Text.RegularExpressions;

namespace UserPassword
{
    class program
    {
        public class Pattern
        {
            public static string Regex_Pattern = "^[A-Z]{1}[a-z0-9]{4,9}$";
            public bool DeterminingName(string Password)

            {
                return Regex.IsMatch(Regex_Pattern, Password);
            }

        }
        public static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter your Password");
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