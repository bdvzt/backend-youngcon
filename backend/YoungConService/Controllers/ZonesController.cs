using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YoungConService.Application.Services.Zone;
using YoungConService.DTOs.Zones;

namespace YoungConService.Controllers;

[ApiController]
[Route("api/zones")]
public class ZonesController(IZoneService service) : ControllerBase
{
    /// <summary>
    /// Получить список зон
    /// </summary>
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<ZoneDTO>>> GetAll()
        => Ok(await service.GetAllAsync());

    /// <summary>
    /// Получить зону по идентификатору
    /// </summary>
    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<ZoneDTO>> GetById(Guid id)
    {
        var zone = await service.GetByIdAsync(id);
        return zone == null ? NotFound() : Ok(zone);
    }

    /// <summary>
    /// Получить зоны по идентификатору этажа
    /// </summary>
    [HttpGet("by-floor/{floorId}")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<ZoneDTO>>> GetByFloorId(Guid floorId)
        => Ok(await service.GetByFloorIdAsync(floorId));

    /// <summary>
    /// Создать зону
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<ZoneDTO>> Create([FromBody] CreateZoneRequest request)
    {
        var created = await service.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    /// <summary>
    /// Обновить зону
    /// </summary>
    [HttpPut("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<ZoneDTO>> Update(Guid id, [FromBody] UpdateZoneRequest request)
    {
        var updated = await service.UpdateAsync(id, request);
        return updated == null ? NotFound() : Ok(updated);
    }

    /// <summary>
    /// Удалить зону
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
