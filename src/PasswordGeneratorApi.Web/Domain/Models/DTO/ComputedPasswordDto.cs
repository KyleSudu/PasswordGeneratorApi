namespace PasswordGeneratorApi.Domain.Web.Domain.Models.DTO;

public record ComputedPassword
{
    // Show this to the user
    public string BasePassword {get; set; }
    // Save this in the database
    public string HashedPassword { get; set; }
}