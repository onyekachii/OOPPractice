using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    public static class Functionalities
    {
        static void ErrorPrompt(string input)
        {            
            Console.WriteLine($"\nInvalid Entry... Enter a valid {input}.\n");
            Application.Run();            
        }

        public static void ValidateName(string text)
        {            
            var pattern = "^[a-zA-Z]+$";
            Regex regex = new Regex(pattern);

            if (string.IsNullOrEmpty(text) || !regex.IsMatch(text))
            {
                ErrorPrompt("name");
            }                                  
        }

        public static void ValidateMail(string text)
        {
            var email_pattern = "^[a-zA-Z]+$";
            Regex emailRegex = new Regex(email_pattern);    //pending email regex ... ... ... ... ... ... ...

            if (string.IsNullOrEmpty(text) || !emailRegex.IsMatch(text))
            {
                ErrorPrompt("email");
            }
        }

        public static DateTime ValidateBirthday(string text)
        {
            DateTime dateTime;
            if (!DateTime.TryParse(text, out dateTime) || string.IsNullOrEmpty(text))
            {
                ErrorPrompt($"MM/DD/YYYY Format");                
                Application.Run();                
            }
            return dateTime;                 
        }               
    }
}
