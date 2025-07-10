namespace portfolio_dotnet.ViewModels.Engineering;

public class EngineeringViewModel
{
    public string? PageTitle { get; set; }
    public required string Company { get; set; }
    public required string CurrentRole { get; set; }
    public required string Responsibilities { get; set; }
}
