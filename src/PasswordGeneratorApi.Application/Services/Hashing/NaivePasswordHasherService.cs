using PasswordGeneratorApi.Domain.Interfaces;

namespace PasswordGeneratorApi.Application.Services.Hashing;

public class NaiveHasher: IHasher
{
    public string Hash(string input)
    {
        // Not hashing anything
        return input;
    }
}