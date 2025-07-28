using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_EmailValidation
{
    public class EmailValidator
    {
        public bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            //^ - start of the string
            //[^@\s]+ : One or more char that are not @ or WhiteSpaces(\s)

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        }
    }
}
