using PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

namespace PasswordGeneratorApi.Domain.Service;

public class NaivePasswordGenerator: IPasswordGenerator
{
    public ComputedPassword GeneratePassword()
    {
        Console.WriteLine("Naive Password");
        throw new NotImplementedException("Not done yet");
    }
}