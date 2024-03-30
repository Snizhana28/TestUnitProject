using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace TestUnitProject
{
    public static class UserValidation
    {

        public static bool isNicknameValid(string nickname)
        {
            if (string.IsNullOrWhiteSpace(nickname))
            {
                throw new ArgumentException("Nickname cannot be null or whitespace.", nameof(nickname));
            }
            string nicknamePattern = @"^[a-zA-Z0-9_]+$";
            Match match = Regex.Match(nickname, nicknamePattern);
            return match.Success;

        }

        public static bool isNameValid(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
            }
            return !name.Any(char.IsDigit);

        }

        public static bool isEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Email cannot be null or whitespace.", nameof(email));
            }
            string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Match match = Regex.Match(email, emailPattern);
            return match.Success;

        }

        public static bool isPasswordValid(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password cannot be null or whitespace.", nameof(password));
            }
            if (password.Length <= 8)
            {
                return false;
            }

            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                return false;
            }

            if (!Regex.IsMatch(password, "[0-9]"))
            {
                return false;
            }
            return true;

        }
    }
}
