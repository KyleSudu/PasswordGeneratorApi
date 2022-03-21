using PasswordGeneratorApi.Domain.Models.DTO;

namespace PasswordGeneratorApi.Domain.Interfaces;

public interface IPasswordGenerator
{
    ComputedPassword GeneratePassword(string hashingService);
}