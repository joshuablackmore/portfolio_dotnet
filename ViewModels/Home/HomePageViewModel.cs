namespace portfolio_dotnet.ViewModels.Home;

using portfolio_dotnet.Models.Shared;
public class HomePageViewModel
{
    public required string PageTitle { get; set; }
    public required string Name { get; set; }
    public required string Tagline { get; set; }
    public required string Intro { get; set; }
    public required List<CtaLink> CtaLinks { get; set; }
}