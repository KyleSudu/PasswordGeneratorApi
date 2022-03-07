namespace PasswordGeneratorApi.Domain.Web;

public class PasswordGenerator: IPasswordGeneratorFactory
{
    private readonly IServiceProvider _service;
    public PasswordGenerator(IServiceProvider service)
    {
        _service = service;
    }
    
    public IPasswordGenerator CreatePasswordGenerator(string generatorName)
    {
        switch (generatorName)
        {
            case "SHA256":
                return _service.GetRequiredService<SHA256Generator>();
            case "MD5": 
                return _service.GetRequiredService<Md5Generator>();
            case "Naive": 
                return _service.GetRequiredService<NaivePasswordGenerator>();
            default:
                throw new ApplicationException("Haven't made that shit yet.");
        }

    }
}