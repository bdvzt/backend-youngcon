using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YoungConService.DTOs.Zones;
using YoungConService.Services.Events.Zone;

namespace YoungConService.Controllers;

[ApiController]
[Route("api/zones")]
public class ZonesController(IZoneService service) : ControllerBase
{
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<ZoneDTO>>> GetAll()
        => Ok(await service.GetAllAsync());

    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<ZoneDTO>> GetById(Guid id)
    {
        var zone = await service.GetByIdAsync(id);
        return zone == null ? NotFound() : Ok(zone);
    }

    [HttpGet("by-floor/{floorId}")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<ZoneDTO>>> GetByFloorId(Guid floorId)
        => Ok(await service.GetByFloorIdAsync(floorId));

    [HttpPost]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<ZoneDTO>> Create([FromBody] CreateZoneRequest request)
    {
        var created = await service.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<ZoneDTO>> Update(Guid id, [FromBody] UpdateZoneRequest request)
    {
        var updated = await service.UpdateAsync(id, request);
        return updated == null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var deleted = await service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}

