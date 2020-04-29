using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_6_i_7
{
    class EmailValidator : IEmailValidator
    {

        public bool IsValidAdress(string candidate)
        {
            return HasMonkeySign(candidate) && EndsWithValidString(candidate);
        }

        private bool HasMonkeySign(string candidate)
        {
            return candidate.Contains('@');
        }

        private bool EndsWithValidString(string candidate)
        {
            return (candidate.EndsWith(".com") || candidate.EndsWith(".hr"));
        }

    }
}
