using PasswordGeneratorApi.Domain;
using PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

namespace PasswordGeneratorApi;

public class Md5Generator: IPasswordGenerator
{
    public ComputedPassword GeneratePassword()
    {
        Console.WriteLine("MD5 Password");
        throw new NotImplementedException("Not done yet");
        
    }
}