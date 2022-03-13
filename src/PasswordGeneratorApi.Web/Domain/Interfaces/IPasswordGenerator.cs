using PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

namespace PasswordGeneratorApi.Domain.Interfaces;

public interface IPasswordGenerator
{
    ComputedPassword GeneratePassword();
}