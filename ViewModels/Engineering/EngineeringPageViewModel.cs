namespace portfolio_dotnet.ViewModels.Engineering;

using portfolio_dotnet.Models.Engineering;

public class EngineeringViewModel
{
    public string? PageTitle { get; set; }
    public required List<Position> Positions { get; set; }
}
