using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6_i_7
{
    class RegistrationInfo : IRegistrationValidator
    {
        EmailValidator emailValidator;
        PasswordValidator passwordValidator;

        public RegistrationInfo()
        {
            this.emailValidator = new EmailValidator();
            this.passwordValidator = new PasswordValidator(8);
        }

        internal EmailValidator EmailValidator { get => emailValidator;}
        internal PasswordValidator PasswordValidator { get => passwordValidator;}

        public bool IsUserEntryValid(UserEntry entry)
        {
            return (emailValidator.IsValidAdress(entry.Email) && passwordValidator.IsValidPassword(entry.Password));
        }
    }
}
