namespace PasswordGeneratorApi.Domain;

public interface IPasswordGeneratorFactory
{
    IPasswordGenerator CreatePasswordGenerator(string schema);
}