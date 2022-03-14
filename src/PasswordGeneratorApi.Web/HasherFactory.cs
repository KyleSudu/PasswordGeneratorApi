using PasswordGeneratorApi.Domain;
using PasswordGeneratorApi.Domain.Interfaces;
using PasswordGeneratorApi.Domain.Service;
using PasswordGeneratorApi.Domain.Service.Hashing;

namespace PasswordGeneratorApi;

public class HasherFactory: IPasswordGeneratorFactory
{
    private readonly IServiceProvider _service;
    public HasherFactory(IServiceProvider service)
    {
        _service = service;
    }
    
    public IHasher CreatePasswordGenerator(string generatorName)
    {
        switch (generatorName)
        {
            case "SHA256":
                return _service.GetRequiredService<SHA256Generator>();
            case "MD5": 
                return _service.GetRequiredService<Md5Generator>();
            case "Naive": 
                return _service.GetRequiredService<NaiveHasher>();
            default:
                throw new ApplicationException("Haven't made that shit yet.");
        }

    }
}