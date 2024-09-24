using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Todolist
{
    public class ValidData
    {
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            string pattern = @"^[a-zA-Z][a-zA-Z0-9._%+-]*@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }

    }
}
