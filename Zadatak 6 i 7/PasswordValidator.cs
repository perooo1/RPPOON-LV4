using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6_i_7
{
    class PasswordValidator : IPasswordValidatorService
    {
        public int MinLength { get; private set; }

        public PasswordValidator(int minLength)
        {
            this.MinLength = minLength;
        }


        public bool IsValidPassword(string candidate)
        {
            if (String.IsNullOrEmpty(candidate)) return false;
            return IsLongEnough(candidate) && ContainsDifferentCharacterTypes(candidate);
        }

        private bool IsLongEnough(string candidate)
        {
            return candidate.Length >= MinLength;
        }

        private bool ContainsDifferentCharacterTypes(string candidate)
        {
            bool hasLower = false, hasUpper = false, hasNumber = false;
            foreach (char c in candidate)
            {
                if (char.IsDigit(c)) hasNumber = true;
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
            }
            return (hasLower && hasUpper && hasNumber);
        }

    }
}
