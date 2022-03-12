using PasswordGeneratorApi.Domain;
using PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

namespace PasswordGeneratorApi;

public class NaivePasswordGenerator: IPasswordGenerator
{
    public ComputedPassword GeneratePassword()
    {
        Console.WriteLine("Naive Password");
        throw new NotImplementedException("Not done yet");
    }
}