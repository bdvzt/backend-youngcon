using YoungConService.Domain.Entities;
using YoungConService.DTOs;
using YoungConService.DTOs.Events;
using YoungConService.DTOs.Festivals;

namespace YoungConService.Infrastructure.Mappers;

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