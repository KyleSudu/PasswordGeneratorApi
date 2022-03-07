namespace PasswordGeneratorApi.Domain.Web;

public class NaivePasswordGenerator: IPasswordGenerator
{
    public string GeneratorName { get; }

    public NaivePasswordGenerator(string generatorName)
    {
        GeneratorName = generatorName;
    }
    public string GeneratePassword()
    {
        throw new NotImplementedException();
    }
}