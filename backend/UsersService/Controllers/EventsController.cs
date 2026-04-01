using Microsoft.AspNetCore.Mvc;
using UsersService.DTOs.Events;
using UsersService.Services.Events;

namespace UsersService.Controllers;

/// <summary>
/// Контроллер для управления событиями (Event), фестивалями, этажами, зонами и спикерами
/// </summary>
[ApiController]
[Route("api/events")]
public class EventsController(IEventService eventService) : ControllerBase
{
    /// <summary>
    /// Получить фестиваль по ID
    /// </summary>
    [HttpGet("festivals/{id}")]
    public async Task<ActionResult<FestivalDTO>> GetFestivalById(Guid id)
    {
        var festival = await eventService.GetFestivalByIdAsync(id);
        if (festival == null)
        {
            return NotFound($"Фестиваль с ID {id} не найден");
        }
        return Ok(festival);
    }

    /// <summary>
    /// Получить все фестивали
    /// </summary>
    [HttpGet("festivals")]
    public async Task<ActionResult<IEnumerable<FestivalDTO>>> GetAllFestivals()
    {
        var festivals = await eventService.GetAllFestivalsAsync();
        return Ok(festivals);
    }

    /// <summary>
    /// Получить событие по ID
    /// </summary>
    [HttpGet("{id}")]
    public async Task<ActionResult<EventDTO>> GetEventById(Guid id)
    {
        var @event = await eventService.GetEventByIdAsync(id);
        if (@event == null)
        {
            return NotFound($"Событие с ID {id} не найдено");
        }
        return Ok(@event);
    }

    /// <summary>
    /// Получить события по ID фестиваля
    /// </summary>
    [HttpGet("festivals/{festivalId}/events")]
    public async Task<ActionResult<IEnumerable<EventDTO>>> GetEventsByFestivalId(Guid festivalId)
    {
        var events = await eventService.GetEventsByFestivalIdAsync(festivalId);
        return Ok(events);
    }

    /// <summary>
    /// Получить события по ID зоны
    /// </summary>
    [HttpGet("zones/{zoneId}/events")]
    public async Task<ActionResult<IEnumerable<EventDTO>>> GetEventsByZoneId(Guid zoneId)
    {
        var events = await eventService.GetEventsByZoneIdAsync(zoneId);
        return Ok(events);
    }

    /// <summary>
    /// Получить события по ID спикера
    /// </summary>
    [HttpGet("speakers/{speakerId}/events")]
    public async Task<ActionResult<IEnumerable<EventDTO>>> GetEventsBySpeakerId(Guid speakerId)
    {
        var events = await eventService.GetEventsBySpeakerIdAsync(speakerId);
        return Ok(events);
    }

    /// <summary>
    /// Получить все события
    /// </summary>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<EventDTO>>> GetAllEvents()
    {
        var events = await eventService.GetAllEventsAsync();
        return Ok(events);
    }

    /// <summary>
    /// Получить этаж по ID
    /// </summary>
    [HttpGet("floors/{id}")]
    public async Task<ActionResult<FloorDTO>> GetFloorById(Guid id)
    {
        var floor = await eventService.GetFloorByIdAsync(id);
        if (floor == null)
        {
            return NotFound($"Этаж с ID {id} не найден");
        }
        return Ok(floor);
    }

    /// <summary>
    /// Получить все этажи
    /// </summary>
    [HttpGet("floors")]
    public async Task<ActionResult<IEnumerable<FloorDTO>>> GetAllFloors()
    {
        var floors = await eventService.GetAllFloorsAsync();
        return Ok(floors);
    }

    /// <summary>
    /// Получить зону по ID
    /// </summary>
    [HttpGet("zones/{id}")]
    public async Task<ActionResult<ZoneDTO>> GetZoneById(Guid id)
    {
        var zone = await eventService.GetZoneByIdAsync(id);
        if (zone == null)
        {
            return NotFound($"Зона с ID {id} не найдена");
        }
        return Ok(zone);
    }

    /// <summary>
    /// Получить зоны по ID этажа
    /// </summary>
    [HttpGet("floors/{floorId}/zones")]
    public async Task<ActionResult<IEnumerable<ZoneDTO>>> GetZonesByFloorId(Guid floorId)
    {
        var zones = await eventService.GetZonesByFloorIdAsync(floorId);
        return Ok(zones);
    }

    /// <summary>
    /// Получить все зоны
    /// </summary>
    [HttpGet("zones")]
    public async Task<ActionResult<IEnumerable<ZoneDTO>>> GetAllZones()
    {
        var zones = await eventService.GetAllZonesAsync();
        return Ok(zones);
    }

    /// <summary>
    /// Получить спикера по ID
    /// </summary>
    [HttpGet("speakers/{id}")]
    public async Task<ActionResult<SpeakerDTO>> GetSpeakerById(Guid id)
    {
        var speaker = await eventService.GetSpeakerByIdAsync(id);
        if (speaker == null)
        {
            return NotFound($"Спикер с ID {id} не найден");
        }
        return Ok(speaker);
    }

    /// <summary>
    /// Получить всех спикеров
    /// </summary>
    [HttpGet("speakers")]
    public async Task<ActionResult<IEnumerable<SpeakerDTO>>> GetAllSpeakers()
    {
        var speakers = await eventService.GetAllSpeakersAsync();
        return Ok(speakers);
    }
}

