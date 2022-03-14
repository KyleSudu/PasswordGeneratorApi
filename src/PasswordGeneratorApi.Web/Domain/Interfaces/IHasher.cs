using PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

namespace PasswordGeneratorApi.Domain.Interfaces;

public interface IHasher
{
    string Hash(string input);
}