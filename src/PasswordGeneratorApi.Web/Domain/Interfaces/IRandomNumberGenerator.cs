namespace PasswordGeneratorApi.Domain.Interfaces;

public interface IRandomNumberGenerator
{
    public int GetRandomInt(int min, int max);
}