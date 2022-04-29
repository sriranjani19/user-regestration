using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UserPassword
{
    class program
    {
        public class Pattern
        {
            public static string Regex_Pattern = "^[a-zA-Z]{8}[0-9]{1,4}$";
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