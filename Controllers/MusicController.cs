using Microsoft.AspNetCore.Mvc;
using portfolio_dotnet.Models.Music;
using portfolio_dotnet.Services;
using portfolio_dotnet.ViewModels.Music;

namespace portfolio_dotnet.Controllers;

public class MusicController : Controller
{
    private readonly MusicService _service;

    private readonly ArtistService _artistService;

    public MusicController(IWebHostEnvironment env)
    {
        _service = new MusicService(env);
        _artistService = new ArtistService(env);
    }
    public IActionResult MyMusic()
    {
        var content = _service.GetMusicPageContent();
        return View(content);
    }


    public IActionResult WhatImListeningTo()
    {
        var content = _artistService.GetAristPageContent();
        return View(content);
    }
}