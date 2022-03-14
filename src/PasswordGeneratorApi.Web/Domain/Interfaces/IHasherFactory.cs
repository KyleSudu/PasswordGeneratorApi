using PasswordGeneratorApi.Domain.Interfaces;

namespace PasswordGeneratorApi.Domain;

public interface IHasherFactory
{
    IHasher CreatePasswordGenerator(string schema);
}