using YoungConService.Domain.Entities;
using YoungConService.DTOs.Events;
using YoungConService.DTOs.Floors;

namespace YoungConService.Infrastructure.Mappers;

public static class FloorMapper
{
    public static FloorDTO ToDto(this Floor floor)
    {
        return new FloorDTO()
        {
            Id = floor.Id,
            Title = floor.Title,
            MapURL = floor.MapURL
        };
    }
}