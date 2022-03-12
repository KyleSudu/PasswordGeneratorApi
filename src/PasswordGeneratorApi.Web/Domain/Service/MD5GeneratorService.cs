using PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

namespace PasswordGeneratorApi.Domain.Service;

public class Md5Generator: IPasswordGenerator
{
    public ComputedPassword GeneratePassword()
    {
        Console.WriteLine("MD5 Password");
        throw new NotImplementedException("Not done yet");
        
    }
}