using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUnitProject
{
    public static class UserValidation
    {
        public static bool isNameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
            }
            return !name.Any(char.IsDigit);

        }

        public static bool isEmailValid(string password)
        {
            throw new NotImplementedException();
        }

        public static bool isPasswordValid(string password)
        {
            throw new NotImplementedException();
        }
    }
}
