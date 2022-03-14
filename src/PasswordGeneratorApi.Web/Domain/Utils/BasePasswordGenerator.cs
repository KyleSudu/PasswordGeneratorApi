namespace PasswordGeneratorApi.Domain.Utils;

public class BasePasswordGenerator
{
    public BasePasswordGenerator()
    {
        
    }
    
    public string GenerateBasePassword(int _passwordLength, Random _randomGenerator)
    {
        var guidObject = Guid.NewGuid().ToByteArray();

        var randomCharacters = new List<char>();
        for (var i = 0; i < _passwordLength; i++)
        {
            var position = _randomGenerator.Next(0, guidObject.Length);
            randomCharacters.Add((char)guidObject[position]);
        }

        return new string(randomCharacters.ToArray());
    }
}