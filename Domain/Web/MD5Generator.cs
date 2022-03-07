namespace PasswordGeneratorApi.Domain.Web;

public class MD5Generator: IPasswordGenerator
{
    public string GeneratorName { get; }

    public MD5Generator(string generatorName)
    {
        GeneratorName = generatorName;

    }
    public string GeneratePassword()
    {
        throw new NotImplementedException();
    }
}