namespace BankAppCore.Interfaces
{
    public interface IUtilities
    {
        string ComputeSha256Hash(string rawData);
        string GenerateRandom(int len);
    }
}