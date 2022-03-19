using PasswordGeneratorApi.Domain.Interfaces;

namespace PasswordGeneratorApi.Domain.Utils;

public class RandomNumberGenerator: IRandomNumberGenerator
{
    public int GetRandomInt(int min, int max)
    {
        var r = new Random();
        var randomValue = min + (max - min) * r.NextDouble();
        return (int)randomValue;
    }
}