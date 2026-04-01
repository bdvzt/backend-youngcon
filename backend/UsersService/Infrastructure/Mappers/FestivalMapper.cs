using UsersService.Domain.Entities;
using UsersService.DTOs;
using UsersService.DTOs.Events;

namespace UsersService.Infrastructure.Mappers;

public static class FestivalMapper
{
    public static FestivalDTO ToDto(this Festival festival)
    {
        return new FestivalDTO
        {
            Id = festival.Id,
            Title = festival.Title,
            Description = festival.Description,
            StartDateTime = festival.StartDateTime,
            EndDateTime = festival.EndDateTime
        };
    }
}