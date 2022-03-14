using System.Security.Cryptography;
using System.Text;
using PasswordGeneratorApi.Domain.Interfaces;
using PasswordGeneratorApi.Domain.Utils;
using PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

namespace PasswordGeneratorApi.Domain.Service;

public class Md5Generator: IPasswordGenerator
{
    private static int _passwordLength;
    private readonly Random _randomGenerator;
    private readonly BasePasswordGenerator _basePasswordGenerator;
    public Md5Generator(Random randomGenerator, BasePasswordGenerator basePasswordGenerator)
    {
        _randomGenerator = randomGenerator;
        _passwordLength = _randomGenerator.Next(10, 20);
        _basePasswordGenerator = basePasswordGenerator;
    }
    public ComputedPassword GeneratePassword()
    {
        var basePassword = _basePasswordGenerator.GenerateBasePassword(_passwordLength, _randomGenerator);
        using var md5Hasher = MD5.Create();
        byte[] hashValue;
        var objUtf8 = new UTF8Encoding();
        hashValue = md5Hasher.ComputeHash(objUtf8.GetBytes(basePassword));
        ComputedPassword generatedPassword =  new ComputedPassword
        {
            BasePassword = basePassword,
            HashedPassword = hashValue
        };
            
        return generatedPassword;
    }
}