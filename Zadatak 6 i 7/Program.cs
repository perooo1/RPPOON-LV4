using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6_i_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////// Zadatak 6
            /*
            string eMail = "petar.lenart@gmail.com";
            string password = "DummyPassword123";

            PasswordValidator passwordValidator = new PasswordValidator(8);
            EmailValidator emailValidator = new EmailValidator();

            if((passwordValidator.IsValidPassword(password)) && (emailValidator.IsValidAdress(eMail)))
            {
                Console.WriteLine("Logged in!");
            }
            else Console.WriteLine("Invalid Password or email!");
            */
            
            //////////////////////////////////////////////////////////////////////// Zadatak 7
            
            RegistrationInfo registrationInfo = new RegistrationInfo();

            while (!(registrationInfo.IsUserEntryValid(UserEntry.ReadUserFromConsole())))
            {
                Console.WriteLine("Incorrect eMail or Password! ");
                Console.WriteLine("Password must be at least 8 chars long and contain at least one number and uppercase character!\n");
            }

            Console.WriteLine("Login successful!\n");
            
        }
    }
}
