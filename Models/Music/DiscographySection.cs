namespace portfolio_dotnet.Models.Music;

public class DiscographySection
{
    public required string Heading { get; set; }
    public required string Category { get; set; }
    public required List<MusicAlbum> Albums { get; set; }
}