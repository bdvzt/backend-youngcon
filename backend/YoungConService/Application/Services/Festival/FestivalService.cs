using YoungConService.DTOs.Festivals;
using YoungConService.Infrastructure.Mappers;
using YoungConService.Repositories.Events;
using FestivalEntity = YoungConService.Domain.Entities.Festival;

namespace YoungConService.Services.Events.Festival;

public class FestivalService(IFestivalRepository repository) : IFestivalService
{
    private static DateTime NormalizeToUtc(DateTime value)
    {
        return value.Kind switch
        {
            DateTimeKind.Utc => value,
            DateTimeKind.Local => value.ToUniversalTime(),
            _ => DateTime.SpecifyKind(value, DateTimeKind.Utc)
        };
    }

    public async Task<FestivalDTO?> GetByIdAsync(Guid id)
    {
        var festival = await repository.GetByIdAsync(id);
        return festival?.ToDto();
    }
    
    public async Task<FestivalDTO?> GetLastAsync()
    {
        var festival = await repository.GetLastAsync();
        return festival?.ToDto();
    }
    
    public async Task<IEnumerable<FestivalDTO>> GetAllAsync()
        => (await repository.GetAllAsync()).Select(f => f.ToDto());

    public async Task<FestivalDTO> CreateAsync(CreateFestivalRequest request)
    {
        var festival = new FestivalEntity
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
            Description = request.Description,
            StartDateTime = NormalizeToUtc(request.StartDateTime),
            EndDateTime = NormalizeToUtc(request.EndDateTime)
        };

        var created = await repository.CreateAsync(festival);
        return created.ToDto();
    }

    public async Task<FestivalDTO?> UpdateAsync(Guid id, UpdateFestivalRequest request)
    {
        var existing = await repository.GetByIdAsync(id);
        if (existing == null)
        {
            return null;
        }

        if (request.Title != null) existing.Title = request.Title;
        if (request.Description != null) existing.Description = request.Description;
        if (request.StartDateTime.HasValue) existing.StartDateTime = NormalizeToUtc(request.StartDateTime.Value);
        if (request.EndDateTime.HasValue) existing.EndDateTime = NormalizeToUtc(request.EndDateTime.Value);

        var updated = await repository.UpdateAsync(existing);
        return updated?.ToDto();
    }

    public Task<bool> DeleteAsync(Guid id) => repository.DeleteAsync(id);
}

