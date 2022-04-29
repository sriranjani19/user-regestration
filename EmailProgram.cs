
   
using System;
using System.Text.RegularExpressions;

namespace UserEmail
{
    class program
    {
        public class Pattern
        {
            public static string Regex_Pattern = "^[A-Z]{1,10}(@)(gmail/outlook/yahoo)(.com)$";
            public bool DeterminingName(string Email)
            {
                return Regex.IsMatch(Email, Regex_Pattern);
            }
        }
        public static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter your Email Name");
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

