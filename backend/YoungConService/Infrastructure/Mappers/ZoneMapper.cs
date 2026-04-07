using YoungConService.Domain.Entities;
using YoungConService.DTOs.Events;
using YoungConService.DTOs.Zones;

namespace YoungConService.Infrastructure.Mappers;

public static class ZoneMapper
{
    public static ZoneDTO ToDto(this Zone zone)
    {
        return new ZoneDTO()
        {
            Id = zone.Id,
            FloorId = zone.FloorId,
            Title = zone.Title,
            Description = zone.Description,
            CoordX = zone.CoordX,
            CoordY = zone.CoordY,
            Icon = zone.Icon,
            Color = zone.Color,
        };
    }
}