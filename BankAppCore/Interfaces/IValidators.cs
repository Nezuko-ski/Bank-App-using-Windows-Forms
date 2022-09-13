namespace BankAppCore.Interfaces
{
    public interface IValidators
    {
        bool ValidateEmail(string email);
        bool ValidateName(string name);
        bool ValidatePassword(string password);
    }
}