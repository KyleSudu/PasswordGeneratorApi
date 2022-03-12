using System.Security.Cryptography;
using System.Text;
using PasswordGeneratorApi.Domain;
using PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

namespace PasswordGeneratorApi;

public class SHA256Generator: IPasswordGenerator
{
    private static int _passwordLength;
    private readonly Random _randomGenerator;
    public SHA256Generator(Random randomGenerator)
    {
        _randomGenerator = randomGenerator;
        _passwordLength = _randomGenerator.Next(10, 20);
    }
    public ComputedPassword GeneratePassword()
    {
        var basePassword = GenerateBasePassword();
        using var mySHA256 = SHA256.Create();
        byte[] hashValue;
        var objUtf8 = new UTF8Encoding();
        hashValue = mySHA256.ComputeHash(objUtf8.GetBytes(basePassword));
        ComputedPassword generatedPassword =  new ComputedPassword
        {
            BasePassword = basePassword,
            HashedPassword = hashValue
        };
            
        return generatedPassword;
    }
    

    public string GenerateBasePassword()
    {
        var guidObject = Guid.NewGuid().ToByteArray();

        var randomCharacters = new List<char>();
        for (var i = 0; i < _passwordLength; i++)
        {
            var position = _randomGenerator.Next(0, guidObject.Length);
            randomCharacters.Add((char)guidObject[position]);
        }

        return randomCharacters.ToString();
    }
    
}