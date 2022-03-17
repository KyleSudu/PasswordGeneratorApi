namespace PasswordGeneratorApi.Domain.Interfaces;

public interface IHasherFactory
{
    IHasher CreatePasswordHasher(string schema);
}