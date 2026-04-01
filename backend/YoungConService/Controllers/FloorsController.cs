using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YoungConService.DTOs.Floors;
using YoungConService.Services.Events.Floor;

namespace YoungConService.Controllers;

[ApiController]
[Route("api/floors")]
public class FloorsController(IFloorService service) : ControllerBase
{
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<FloorDTO>>> GetAll()
        => Ok(await service.GetAllAsync());

    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<FloorDTO>> GetById(Guid id)
    {
        var floor = await service.GetByIdAsync(id);
        return floor == null ? NotFound() : Ok(floor);
    }

    [HttpPost]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<FloorDTO>> Create([FromBody] CreateFloorRequest request)
    {
        var created = await service.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<FloorDTO>> Update(Guid id, [FromBody] UpdateFloorRequest request)
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

