using System.Text.Json;
using portfolio_dotnet.ViewModels.Music;
using portfolio_dotnet.Models.Music;

namespace portfolio_dotnet.Services;

public class MusicService
{
    private readonly IWebHostEnvironment _env;

    public MusicService(IWebHostEnvironment env)
    {
        _env = env;
    }

    public MusicViewModel GetMusicPageContent()
    {
        var PageTitle = "My Music";
        var discography = LoadDiscograhpyFromJson();
        return new MusicViewModel
        {
            PageTitle = PageTitle,
            Discography = discography
        };
    }


    private List<DiscographySection> LoadDiscograhpyFromJson()
    {
        var path = Path.Combine(_env.WebRootPath, "data", "discography.json");

        if (!File.Exists(path))
        {
            return new List<DiscographySection>();
        }

        var json = File.ReadAllText(path);
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        return JsonSerializer.Deserialize<List<DiscographySection>>(json, options) ?? new List<DiscographySection>();
    }
}