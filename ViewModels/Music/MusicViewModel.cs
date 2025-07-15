namespace portfolio_dotnet.ViewModels.Music;

using portfolio_dotnet.Models.Music;

public class MusicViewModel
{
    public string? PageTitle { get; set; }
    public required List<DiscographySection> Discography { get; set; }
}