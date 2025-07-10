namespace portfolio_dotnet.ViewModels.Music;

public class MusicViewModel
{
    public string? PageTitle { get; set; }
    public required List<portfolio_dotnet.Models.Music.DiscographySection> Discography { get; set; }
}