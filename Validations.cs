using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegestration
{
    internal class Validations
    {
        static string firstNamePattern = "^[A-Z]{1}[a-z]{3,}$";
        
        public static bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, firstNamePattern);
        }
    }
}
