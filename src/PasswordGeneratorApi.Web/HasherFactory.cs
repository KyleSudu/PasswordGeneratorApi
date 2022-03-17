using PasswordGeneratorApi.Domain.Interfaces;
using PasswordGeneratorApi.Domain.Service.Hashing;

namespace PasswordGeneratorApi;

public class HasherFactory: IHasherFactory
{
    private readonly IServiceProvider _service;
    public HasherFactory(IServiceProvider service)
    {
        _service = service;
    }
    
    public IHasher CreatePasswordHasher(string generatorName)
    {
        return generatorName switch
        {
            "SHA256" => _service.GetRequiredService<SHA256Hasher>(),
            "MD5" => _service.GetRequiredService<Md5Hasher>(),
            "Naive" => _service.GetRequiredService<NaiveHasher>(),
            _ => throw new ApplicationException("Haven't made that shit yet.")
        };
    }
}