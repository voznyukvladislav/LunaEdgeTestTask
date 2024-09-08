using LunaEdgeTestTask.Constants;
using LunaEdgeTestTask.Interfaces;
using LunaEdgeTestTask.Models;
using System.Net.Mail;

namespace LunaEdgeTestTask.Data
{
    public static class Validator
    {
        public static bool ValidateEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                mailAddress = null;

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidatePassword(string password)
        {
            return Validator.ValidatePasswordLength(password.Length)
                && Validator.ValidatePasswordSymbols(password);
        }

        public static bool ValidateUsername(IRepository repository, string username)
        {
            User? user = repository.GetUser(username);

            if (user is null) return true;
            else return false;
        }

        private static bool ValidatePasswordLength(int length)
        {
            if (length >= ValidationConstants.PasswordMinLength &&
                length <= ValidationConstants.PasswordMaxLength)
            {
                return true;
            }
            else return false;
        }

        // Returns true if password has at least one capital symbol and at least one digit
        private static bool ValidatePasswordSymbols(string password)
        {
            bool isCapitalChar = false;
            bool isDigit = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsUpper(password[i])) isCapitalChar = true;
                if (Char.IsDigit(password[i])) isDigit = true;
            }

            return isCapitalChar && isDigit;
        }
    }
}
