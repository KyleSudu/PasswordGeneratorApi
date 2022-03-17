using PasswordGeneratorApi.Domain.Interfaces;

namespace PasswordGeneratorApi.Domain.Utils;

public class RandomNumberGenerator: IRandomNumberGenerator
{
    public int GetRandomInt(int min, int max)
    {
        return 5;
    }
}