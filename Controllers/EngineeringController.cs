using Microsoft.AspNetCore.Mvc;
using portfolio_dotnet.ViewModels.Engineering;

namespace portfolio_dotnet.Controllers;

public class EngineeringController : Controller
{
    public IActionResult Index()
    {
        var content = new EngineeringViewModel { PageTitle = "Engineering", Company = "Compare The Market", CurrentRole = "Junior Software Engineer", Responsibilities = "Contributing to full-stack development, testing, and architecture in a large-scale Node.js MVC environment." };
        return View(content);
    }
}