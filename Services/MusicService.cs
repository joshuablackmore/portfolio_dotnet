using System.Text.Json;
using portfolio_dotnet.Models;

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
        var bio = "I've recorded quite a bit of music, please check it out!";
        var discography = LoadDiscograhpyFromJson();
        return new MusicViewModel
        {
            Bio = bio,
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