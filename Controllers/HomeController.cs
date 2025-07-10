using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using portfolio_dotnet.Models;
using portfolio_dotnet.Models.Shared;
using portfolio_dotnet.ViewModels.Home;

namespace portfolio_dotnet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var model = new HomePageViewModel
        {
            PageTitle = "Home",
            Name = "Joshua Blackmore",
            Tagline = "I build things and hit things.",
            Intro = "I’m a full-stack software engineer and professional drummer. During the day I help build scalable, accessible web apps. After hours, I write and perform experimental music.",
            CtaLinks = new List<CtaLink>
            {
                new CtaLink { Href = "/music", Label= "🎶 Explore My Music" },
                new CtaLink { Href = "/Engineering", Label = "💻 See My Engineering Work" }
            }
        };

        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
