namespace PasswordGeneratorApi.Domain.Web;

public class SHA256Generator: IPasswordGenerator
{
    public string GeneratorName { get; }

    public SHA256Generator(string generatorName)
    {
        GeneratorName = generatorName;
    }
    public string GeneratePassword()
    {
        throw new NotImplementedException();
    }
}