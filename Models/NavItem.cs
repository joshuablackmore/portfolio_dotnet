namespace portfolio_dotnet.Models;

public class NavItem
{
    public required string Text { get; set; }
    public required string Controller { get; set; }
    public string Action { get; set; } = "Index";
}