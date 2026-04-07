using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YoungConService.DTOs.Festivals;
using YoungConService.Services.Events.Festival;

namespace YoungConService.Controllers;

[ApiController]
[Route("api/festivals")]
public class FestivalsController(IFestivalService service) : ControllerBase
{
    /// <summary>
    /// Получить список фестивалей
    /// </summary>
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<FestivalDTO>>> GetAll()
        => Ok(await service.GetAllAsync());
    
    /// <summary>
    /// Получить последний фестиваль
    /// </summary>
    [HttpGet("last")]
    public async Task<IActionResult> GetLast()
    {
        var festival = await service.GetLastAsync();

        if (festival == null)
            return NotFound();

        return Ok(festival);
    }

    /// <summary>
    /// Получить фестиваль по идентификатору
    /// </summary>
    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<FestivalDTO>> GetById(Guid id)
    {
        var festival = await service.GetByIdAsync(id);
        return festival == null ? NotFound() : Ok(festival);
    }

    /// <summary>
    /// Создать фестиваль (доступно только сотруднику)
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<FestivalDTO>> Create([FromBody] CreateFestivalRequest request)
    {
        var created = await service.CreateAsync(request);
        return Ok(created);
    }

    /// <summary>
    /// Обновить фестиваль (доступно только сотруднику)
    /// </summary>
    [HttpPut("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<FestivalDTO>> Update(Guid id, [FromBody] UpdateFestivalRequest request)
    {
        var updated = await service.UpdateAsync(id, request);
        return updated == null ? NotFound() : Ok(updated);
    }

    /// <summary>
    /// Удалить фестиваль (доступно только сотруднику)
    /// </summary>
    [HttpDelete("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var deleted = await service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }

    // Добавлено поле StreamURL
}
