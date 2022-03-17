using System.Security.Cryptography;
using System.Text;
using PasswordGeneratorApi.Domain.Interfaces;

namespace PasswordGeneratorApi.Domain.Service.Hashing;

public class Md5Hasher: IHasher
{
    public string Hash(string input)
    {
        using var md5Hasher = MD5.Create();
        return Encoding.UTF8.GetString(md5Hasher.ComputeHash(Encoding.UTF8.GetBytes(input)));    
    }
}