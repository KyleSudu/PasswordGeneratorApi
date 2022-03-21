using PasswordGeneratorApi.Domain.Interfaces;
using PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

namespace PasswordGeneratorApi.Domain.Service;

public class PasswordGenerator: IPasswordGenerator
{
    private static int _passwordLength;
    private readonly IHasherFactory _hasherFactory;
    private readonly IRandomNumberGenerator _randomNumberGenerator;
    private static string _validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

    public PasswordGenerator(IHasherFactory hasherFactory, IRandomNumberGenerator randomNumberGenerator)
    {
        _randomNumberGenerator = randomNumberGenerator;
        _passwordLength = _randomNumberGenerator.GetRandomInt(10, 20);
        _hasherFactory = hasherFactory;
    }
    
    public ComputedPassword GeneratePassword(string hashingService)
    {
        var basePassword = GenerateBasePassword();
        var hasher = _hasherFactory.CreatePasswordHasher(hashingService);
        var hashedPassword = hasher.Hash(basePassword);
        
        return new ComputedPassword
        {
            BasePassword = basePassword,
            HashedPassword = hashedPassword
        };
    }
    
    private string GenerateBasePassword()
    {
        var buffer = new char[_passwordLength];

        for (var i = 0; i < _passwordLength; i++)
        {
            buffer[i] = _validChars[_randomNumberGenerator.GetRandomInt(0, _passwordLength)];
        }
        return new string(buffer);
    }
}