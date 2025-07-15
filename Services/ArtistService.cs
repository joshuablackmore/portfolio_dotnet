using System.Text.Json;
using portfolio_dotnet.ViewModels.Music;
using portfolio_dotnet.Models.Music;

namespace portfolio_dotnet.Services;

public class ArtistService
{
    private readonly IWebHostEnvironment _env;

    public ArtistService(IWebHostEnvironment env)
    {
        _env = env;
    }

    public ListeningViewModel GetAristPageContent()
    {
        var PageTitle = "What I'm Listening To";
        var ArtistCards = LoadArtists();

        return new ListeningViewModel
        {
            PageTitle = PageTitle,
            ArtistCards = ArtistCards
        };
    }

    private List<ArtistCard> LoadArtists()
    {
        var path = Path.Combine(_env.WebRootPath, "data", "ListeningList.json");

        if (!File.Exists(path))
        {
            return new List<ArtistCard>();
        }

        var json = File.ReadAllText(path);
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        return JsonSerializer.Deserialize<List<ArtistCard>>(json, options) ?? new List<ArtistCard>();
    }
}