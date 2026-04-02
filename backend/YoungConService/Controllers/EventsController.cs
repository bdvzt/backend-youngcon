using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using YoungConService.DTOs.Events;
using YoungConService.Services.Events.Event;

namespace YoungConService.Controllers;

[ApiController]
[Route("api/events")]
public class EventsController(IEventService service) : ControllerBase
{
    /// <summary>
    /// Получить событие по идентификатору
    /// </summary>
    [HttpGet("{id}")]
    [AllowAnonymous]
    public async Task<ActionResult<EventDTO>> GetById(Guid id)
    {
        var @event = await service.GetByIdAsync(id);
        return @event == null ? NotFound() : Ok(@event);
    }

    /// <summary>
    /// Получить список спикеров события
    /// </summary>
    [HttpGet("{id}/speakers")]
    [AllowAnonymous]
    public async Task<ActionResult<EventSpeakersDTO>> GetSpeakersByEventId(Guid id)
    {
        var speakers = await service.GetSpeakersByEventIdAsync(id);
        return speakers == null ? NotFound() : Ok(speakers);
    }

    /// <summary>
    /// Получить события фестиваля
    /// </summary>
    [HttpGet("by-festival/{festivalId}")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<EventDTO>>> GetByFestivalId(Guid festivalId)
        => Ok(await service.GetByFestivalIdAsync(festivalId));

    /// <summary>
    /// Получить события зоны
    /// </summary>
    [HttpGet("by-zone/{zoneId}")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<EventDTO>>> GetByZoneId(Guid zoneId)
        => Ok(await service.GetByZoneIdAsync(zoneId));

    /// <summary>
    /// Получить события спикера
    /// </summary>
    [HttpGet("by-speaker/{speakerId}")]
    [AllowAnonymous]
    public async Task<ActionResult<IEnumerable<EventDTO>>> GetBySpeakerId(Guid speakerId)
        => Ok(await service.GetBySpeakerIdAsync(speakerId));

    /// <summary>
    /// Поставить или снять лайк у события для текущего пользователя
    /// </summary>
    [HttpPost("{id}/like")]
    [Authorize]
    public async Task<ActionResult<EventLikeDTO>> ToggleLike(Guid id)
        => Ok(await service.ToggleLikeAsync(id));

    /// <summary>
    /// Создать событие
    /// </summary>
    [HttpPost]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<EventDTO>> Create([FromBody] CreateEventRequest request)
    {
        var created = await service.CreateAsync(request);
        return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
    }

    /// <summary>
    /// Обновить событие
    /// </summary>
    [HttpPut("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<ActionResult<EventDTO>> Update(Guid id, [FromBody] UpdateEventRequest request)
    {
        var updated = await service.UpdateAsync(id, request);
        return updated == null ? NotFound() : Ok(updated);
    }

    /// <summary>
    /// Удалить событие
    /// </summary>
    [HttpDelete("{id}")]
    [Authorize(Roles = "Employee")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var deleted = await service.DeleteAsync(id);
        return deleted ? NoContent() : NotFound();
    }
}

