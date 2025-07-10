using Microsoft.AspNetCore.Mvc;
using portfolio_dotnet.Services;

namespace portfolio_dotnet.Controllers;

public class MusicController : Controller
{
    private readonly MusicService _service;

    public MusicController(IWebHostEnvironment env)
    {
        _service = new MusicService(env);
    }
    public IActionResult MyMusic()
    {
        var content = _service.GetMusicPageContent();
        return View(content);
    }

    public IActionResult WhatImListeningTo()
    {
        return View();
    }
}