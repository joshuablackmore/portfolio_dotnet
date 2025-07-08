namespace portfolio_dotnet.Models;

public class MusicViewModel
{
    public required string Bio { get; set; }
    public required List<DiscographySection> Discography { get; set; }
}