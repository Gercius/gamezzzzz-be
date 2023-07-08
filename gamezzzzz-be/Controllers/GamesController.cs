using gamezzzzz_be.Models;
using gamezzzzz_be.Services;
using Microsoft.AspNetCore.Mvc;

namespace gamezzzzz_be.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GamesController: ControllerBase
{
    private readonly GamesService _gamesService;

    public GamesController(GamesService gamesService) =>
        _gamesService = gamesService;

    //[HttpGet]
    //public async Task<List<Game>> Get() =>
    //    await _gamesService.GetAsync();

    [HttpGet]
    public async Task<IActionResult> GetGames(int page = 1, int pageSize = 25)
    {
        List<Game> games = await _gamesService.GetGames(page, pageSize);

        if (games is null)
        {
            return NotFound();
        }

        return Ok(games);
    }


    [HttpGet("{id:length(24)}")]
    public async Task<ActionResult<Game>> Get(string id)
    {
        var game = await _gamesService.GetAsync(id);

        if (game is null)
        {
            return NotFound();
        }

        return game;
    }
}
