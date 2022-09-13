using System.Text.RegularExpressions;
using BankAppCore.Interfaces;


namespace BankAppCore.Helper
{
    public class Validators : IValidators
    {

        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, @"^[A-Z][a-z]+$");
        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, "^[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[A-Za-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?\\.)+[A-Za-z0-9](?:[A-Za-z0-9-]*[A-Za-z0-9])?");
        }
        /// <summary>
        /// To ensure password contains at least 6 characters including at least one number and special character
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidatePassword(string password)
        {
            return Regex.IsMatch(password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!%*?&])[A-Za-z0-9@$!%*?&]{6,}");
        }

    }
}
