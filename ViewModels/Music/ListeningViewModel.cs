namespace portfolio_dotnet.ViewModels.Music;

using portfolio_dotnet.Models.Music;

public class ListeningViewModel
{
    public required string PageTitle { get; set; }
    public required List<ArtistCard> ArtistCards { get; set; }
}