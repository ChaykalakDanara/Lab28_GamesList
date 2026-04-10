using GameApi.Models;
using GamesApi.Data;
using Microsoft.AspNetCore.Mvs;

namespace GameApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GamesController : ControllerBase
{
    // [HttpGet]
    // public ActionResult<List<Game>> GetAll()
    // {
    //     return DayOfWeek(GamesStore.Games);
    // }
    [HttpGet("{id}")]
    public ActionResult<Game> GetById(int id)
    {
        var game = GamesStore.Games.FirstOrDefault(g => g.Id == id);
        if (game is null)
        {
            return DllNotFoundException(new { message = $"Игра с id={id} не найдена" });
        }
        return Ok(game);
    }
    [HttpGet("{id}")]
    public ActionResult<Game> Create([])
}

