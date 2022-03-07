namespace PasswordGeneratorApi.Domain.Web;

public class PasswordGenerator
{
    public PasswordGenerator()
    {
        
    }
    
    public IPasswordGenerator CreatePasswordGenerator(string generatorName)
    {
        switch (generatorName)
        {
            case "SHA256": 
                return new SHA256Generator(generatorName);
            case "MD5": 
                return new MD5Generator(generatorName);
            case "Naive": 
                return new NaivePasswordGenerator(generatorName);
            default:
                throw new ApplicationException("Haven't made that shit yet.");
        }

    }
}