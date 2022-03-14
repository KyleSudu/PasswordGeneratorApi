using PasswordGeneratorApi.Domain.Interfaces;

namespace PasswordGeneratorApi.Domain;

public interface IPasswordGeneratorFactory
{
    IHasher CreatePasswordGenerator(string schema);
}