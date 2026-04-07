using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YoungConService.DTOs.Floors;
using YoungConService.Services.Events.Floor;

namespace YoungConService.Controllers;

[ApiController]
[Route("api/floors")]
public class FloorsController(IFloorService service) : ControllerBase
{
    /// <summary>
    /// Получить список этажей
    /// </summary>
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<FloorDTO>>> GetAll()
        => Ok(await service.GetAllAsync());

    /// <summary>
    /// Получить этаж по идентификатору
    /// </summary>
    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<FloorDTO>> GetById(Guid id)
    {
        var floor = await service.GetByIdAsync(id);
        return floor == null ? NotFound() : Ok(floor);
    }

    /// <summary>
    /// Создать этаж (доступно только сотруднику)
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<FloorDTO>> Create([FromBody] CreateFloorRequest request)
    {
        var created = await service.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    /// <summary>
    /// Обновить этаж (доступно только сотруднику)
    /// </summary>
    [HttpPut("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<FloorDTO>> Update(Guid id, [FromBody] UpdateFloorRequest request)
    {
        var updated = await service.UpdateAsync(id, request);
        return updated == null ? NotFound() : Ok(updated);
    }

    /// <summary>
    /// Удалить этаж (доступно только сотруднику)
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
