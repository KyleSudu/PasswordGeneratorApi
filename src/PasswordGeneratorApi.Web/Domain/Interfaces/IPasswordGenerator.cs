using PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

namespace PasswordGeneratorApi.Domain;

public interface IPasswordGenerator
{
    ComputedPassword GeneratePassword();
}