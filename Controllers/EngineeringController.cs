using Microsoft.AspNetCore.Mvc;
using portfolio_dotnet.Models.Engineering;
using portfolio_dotnet.ViewModels.Engineering;

namespace portfolio_dotnet.Controllers;

public class EngineeringController : Controller
{
    public IActionResult Index()
    {
        var content = new EngineeringViewModel
        {
            PageTitle = "Engineering",
            Positions = new List<Position>
        {
            new Position
            {
            Period = "09/2024 - Ongoing",
            Company = "Compare The Market",
            Role = "Junior Software Engineer",
            Responsibilities = "Contributing to full-stack development, testing, and architecture in a large-scale Node.js MVC environment.",
            TechStack = "Typescript, Node.js, C#, .net"
            },
            new Position
            {
                Period = "09/2024 - 01/2025",
                Company = "Makers Academy",
                Role = "Full Time Student",
                Responsibilities = "Team project based learning.",
                TechStack = "Python, Javascript, React, MongoDB, SQL"

            },
            new Position
            {
                Period = "01/2023 - 09/2024",
                Role = "Self Learning",
                Responsibilities = "Enquisitive learning by building. Tentative to aggressive job hunting.",
                TechStack = "Javascript, Typescript, React"
            }
        }
        };
        return View(content);
    }
}