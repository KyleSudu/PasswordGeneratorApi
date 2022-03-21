namespace PasswordGeneratorApi.Domain.Models.DTO;

public record PasswordParametersDto
{
    public bool UseNumericCharacters { get; set; }
    public bool UseSpecialCharacters { get; set; }
    public int? MinPasswordLength { get; set; }
    public int? MaxPasswordLength { get; set; }
    public string Scheme { get; set; }
    
}