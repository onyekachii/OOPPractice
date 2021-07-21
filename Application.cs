using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment
{
    public static class Application
    {
        public static void Run()
        {
           var menu = new StringBuilder();
            menu.Append("Hello, welcome to my App:\n");
            menu.AppendLine("Enter your FirstName");
            Console.WriteLine(menu.ToString());
            var firstName = Console.ReadLine();
            Functionalities.ValidateName(firstName);

            Console.WriteLine("Enter Lastname");
            var lastName = Console.ReadLine();
            Functionalities.ValidateName(lastName);

            Console.WriteLine("Enter email");
            var email = Console.ReadLine();
            Functionalities.ValidateMail(email);

            Console.WriteLine("Enter birthday: MM/DD/YYYY Format");
            var birthday = Console.ReadLine();            
            var DOB = Functionalities.ValidateBirthday(birthday);
                        
            Console.WriteLine("Select your Gender: \n 1. male \n 2. Female \n 3. Prefer not to say");
            var gender = Console.ReadLine();
            if (gender != "1" && gender != "2" && gender != "3")
            {
                Console.WriteLine("Invalid Gender Selection");
            }            
            var selectedGender = GenderSelection(gender);

            Console.WriteLine("Enter Password");
            var password = Console.ReadLine();
            Console.WriteLine("Confirm Password");
            var confirmPassword = Console.ReadLine();

            var formData = new Register
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Birthday = DOB,
                Password = password,
                ConfirmPassword = confirmPassword,
                Gender = selectedGender
            };
            AccountService.Register(formData);
        }
        public static Gender GenderSelection(string gender)
        {
            switch (gender)
            {
                case "1":
                    return Gender.Male;
                case "2":
                    return Gender.Female;
                case "3":
                    return Gender.PreferNotToSay;
                default:
                    return Gender.SelectGender;
            }
        }
        
    }
}
