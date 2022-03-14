using PasswordGeneratorApi.Domain.Interfaces;
using PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

namespace PasswordGeneratorApi.Domain.Service;

public class PasswordGenerator: IPasswordGenerator
{
    private static int _passwordLength;
    private readonly Random _randomGenerator;
    private readonly IHasherFactory _hasherFactory;
   
    public PasswordGenerator(Random randomGenerator, IHasherFactory hasherFactory)
    {
        _randomGenerator = randomGenerator;
        _passwordLength = _randomGenerator.Next(10, 20);
        _hasherFactory = hasherFactory;
    }
    
    public ComputedPassword GeneratePassword(string hashingService)
    {
        var basePassword = GenerateBasePassword();
        var hasher = _hasherFactory.CreatePasswordGenerator(hashingService);
        var hashedPassword = hasher.Hash(basePassword);
        
        return new ComputedPassword
        {
            BasePassword = basePassword,
            HashedPassword = hashedPassword
        };
    }
    
    private string GenerateBasePassword()
    {
        var guidObject = Guid.NewGuid().ToByteArray();

        var randomCharacters = new List<char>();
        for (var i = 0; i < _passwordLength; i++)
        {
            var position = _randomGenerator.Next(0, guidObject.Length);
            randomCharacters.Add((char)guidObject[position]);
        }
        return new string(randomCharacters.ToArray());
    }
}