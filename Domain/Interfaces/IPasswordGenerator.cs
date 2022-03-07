namespace PasswordGeneratorApi.Domain;

public interface IPasswordGenerator
{
    string GeneratorName { get;  }
    string GeneratePassword();
}