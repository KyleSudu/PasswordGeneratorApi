using PasswordGeneratorApi.Domain.Interfaces;
using PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

namespace PasswordGeneratorApi.Domain.Service;

public class NaivePasswordGenerator: IPasswordGenerator
{
    internal static readonly char[] _validPasswordCharacters =
        "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray(); 
    private readonly Random _randomGenerator;

    public NaivePasswordGenerator(Random randomGenerator)
    {
        _randomGenerator = randomGenerator;
    }
    
    public ComputedPassword GeneratePassword()
    {
        var passwordLength = _randomGenerator.Next(8, _validPasswordCharacters.Length);
        var generatedPassword = new char[passwordLength];
        for (var i = 0; i < passwordLength; i++)
        {
            var randomPosition = _randomGenerator.Next(0, _validPasswordCharacters.Length);
            generatedPassword[i] = _validPasswordCharacters[randomPosition];
        }
        ComputedPassword newPassword =  new ComputedPassword
        {
            BasePassword = generatedPassword.ToString(),
            HashedPassword = null
        };
        return newPassword;
    }
}