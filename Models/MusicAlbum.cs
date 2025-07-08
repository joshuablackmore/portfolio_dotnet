namespace portfolio_dotnet.Models;

public class MusicAlbum
{
    public required string Title { get; set; }
    public int Year { get; set; }
    public required string Genre { get; set; }
    public string? Description { get; set; }
    public string? Artwork { get; set; }
    public string? Role { get; set; }
    public Dictionary<string, string>? Links { get; set; }
}