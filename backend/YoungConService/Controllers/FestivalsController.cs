using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YoungConService.DTOs.Festivals;
using YoungConService.Services.Events.Festival;

namespace YoungConService.Controllers;

[ApiController]
[Route("api/festivals")]
public class FestivalsController(IFestivalService service) : ControllerBase
{
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<FestivalDTO>>> GetAll()
        => Ok(await service.GetAllAsync());

    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<FestivalDTO>> GetById(Guid id)
    {
        var festival = await service.GetByIdAsync(id);
        return festival == null ? NotFound() : Ok(festival);
    }

    [HttpPost]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<FestivalDTO>> Create([FromBody] CreateFestivalRequest request)
    {
        var created = await service.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<FestivalDTO>> Update(Guid id, [FromBody] UpdateFestivalRequest request)
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

