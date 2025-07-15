namespace portfolio_dotnet.Models.Engineering;

public class Position
{
    public required string Period { get; set; }
    public string? Company { get; set; }
    public required string Role { get; set; }
    public required string Responsibilities { get; set; }
    public string? TechStack { get; set; }
}