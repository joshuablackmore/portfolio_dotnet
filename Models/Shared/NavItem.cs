namespace portfolio_dotnet.Models.Shared;

public class NavItem
{
    public required string Text { get; set; }
    public string? Controller { get; set; }
    public string Action { get; set; } = "Index";

    // External links (GitHub, LinkedIn, etc.)
    public string? Href { get; set; }

    // Optional: icon name or CSS class
    public string? Icon { get; set; }
}