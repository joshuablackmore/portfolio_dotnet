using Microsoft.AspNetCore.Mvc;

namespace portfolio_dotnet.Controllers;

public class EngineeringController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}