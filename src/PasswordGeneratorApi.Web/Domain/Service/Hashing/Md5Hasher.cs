using System.Security.Cryptography;
using System.Text;
using PasswordGeneratorApi.Domain.Interfaces;

namespace PasswordGeneratorApi.Domain.Service.Hashing;

public class Md5Hasher: IHasher
{
    public string Hash(string input)
    {
        using var md5Hasher = MD5.Create();
        return string.Join("", md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(input)).Select(b => b.ToString("X2")));    
    }
}