namespace portfolio_dotnet.Models.Music;

public class ArtistCard
{
    public required string ArtistName { get; set; }
    public required string Image { get; set; }
    public required string Genre { get; set; }
    public string? Reason { get; set; }
    public Dictionary<string, string>? Links { get; set; }
}