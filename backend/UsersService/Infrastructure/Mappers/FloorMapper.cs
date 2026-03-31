using UsersService.Domain.Entities;
using UsersService.DTOs.Events;

namespace UsersService.Infrastructure.Mappers;

public static class FloorMapper
{
    public static FloorDTO ToDto(this Floor floor)
    {
        return new FloorDTO()
        {
            Id = floor.Id,
            Title = floor.Title,
            Description = floor.Description,
            MapURL = floor.MapURL
        };
    }
}