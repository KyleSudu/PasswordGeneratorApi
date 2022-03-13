using PasswordGeneratorApi.Domain.Interfaces;

namespace PasswordGeneratorApi.Domain;

public interface IPasswordGeneratorFactory
{
    IPasswordGenerator CreatePasswordGenerator(string schema);
}