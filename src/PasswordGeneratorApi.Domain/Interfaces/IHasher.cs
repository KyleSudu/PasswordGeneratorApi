namespace PasswordGeneratorApi.Domain.Interfaces;

public interface IHasher
{
    string Hash(string input);
}