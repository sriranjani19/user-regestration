
   
using System;
using System.Text.RegularExpressions;

namespace UserMobile
{
    class program
    {
        public class Pattern
        {
            public static string Regex_Pattern = "^[+91]{ }[7-9]{3}[0-9]{7}$";
            public bool DeterminingName(string Mobile_No)

            {
                return Regex.IsMatch(Regex_Pattern, Mobile_No);
            }

        }
        public static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter your Mobile Name");
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