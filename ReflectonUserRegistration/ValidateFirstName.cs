using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReflectonUserRegistration
{
    internal class ValidateFirstName
    {
        public static bool Validate_FirstName(string firstName)
        {
            return Regex.IsMatch(firstName, "^[A-Z][a-z]{2,}");
        }
    }
}
