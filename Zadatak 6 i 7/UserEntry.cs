using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6_i_7
{
    class UserEntry
    {
        public string Email { get; set; }
        public string Password{ get; set; }

        private UserEntry() { }

        public static UserEntry ReadUserFromConsole()
        {
            UserEntry entry = new UserEntry();
            Console.WriteLine("Enter your email: ");
            entry.Email = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            entry.Password = Console.ReadLine();
            return entry;
        }

    }
}
