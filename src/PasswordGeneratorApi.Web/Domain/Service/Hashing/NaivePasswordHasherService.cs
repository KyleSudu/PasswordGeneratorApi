using PasswordGeneratorApi.Domain.Interfaces;
namespace PasswordGeneratorApi.Domain.Service.Hashing;

public class NaiveHasher: IHasher
{
    public string Hash(string input)
    {
        return input;
    }
}