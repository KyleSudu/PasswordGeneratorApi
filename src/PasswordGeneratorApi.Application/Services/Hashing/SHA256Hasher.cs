using System.Security.Cryptography;
using System.Text;
using PasswordGeneratorApi.Domain.Interfaces;

namespace PasswordGeneratorApi.Application.Services.Hashing;

public class SHA256Hasher: IHasher
{
    public string Hash(string input)
    {
        using var mySHA256 = SHA256.Create();
        return string.Join("", mySHA256.ComputeHash(Encoding.UTF8.GetBytes(input)).Select(b => b.ToString("X2")));    

    }
}