namespace PasswordGeneratorApi.Domain.Utils;

public class BasePasswordGenerator
{
    public string GenerateBasePassword(int passwordLength, Random randomGenerator)
    {
        var guidObject = Guid.NewGuid().ToByteArray();

        var randomCharacters = new List<char>();
        for (var i = 0; i < passwordLength; i++)
        {
            var position = randomGenerator.Next(0, guidObject.Length);
            randomCharacters.Add((char)guidObject[position]);
        }

        return new string(randomCharacters.ToArray());
    }
}