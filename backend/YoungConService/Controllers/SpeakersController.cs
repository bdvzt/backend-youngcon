using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YoungConService.DTOs.Speakers;
using YoungConService.Services.Events.Speaker;

namespace YoungConService.Controllers;

[ApiController]
[Route("api/speakers")]
public class SpeakersController(ISpeakerService service) : ControllerBase
{
    /// <summary>
    /// Получить список спикеров
    /// </summary>
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<SpeakerDTO>>> GetAll()
        => Ok(await service.GetAllAsync());

    /// <summary>
    /// Получить спикера по идентификатору
    /// </summary>
    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<SpeakerDTO>> GetById(Guid id)
    {
        var speaker = await service.GetByIdAsync(id);
        return speaker == null ? NotFound() : Ok(speaker);
    }

    /// <summary>
    /// Создать спикера (доступно только сотруднику)
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<SpeakerDTO>> Create([FromBody] CreateSpeakerRequest request)
    {
        var created = await service.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    /// <summary>
    /// Обновить спикера (доступно только сотруднику)
    /// </summary>
    [HttpPut("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<SpeakerDTO>> Update(Guid id, [FromBody] UpdateSpeakerRequest request)
    {
        var updated = await service.UpdateAsync(id, request);
        return updated == null ? NotFound() : Ok(updated);
    }

    /// <summary>
    /// Удалить спикера (доступно только сотруднику)
    /// </summary>
    [HttpDelete("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var deleted = await service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}

