using YoungConService.DTOs.Floors;
using YoungConService.Infrastructure.Mappers;
using YoungConService.Repositories.Events;

namespace YoungConService.Services.Events.Floor;

public class FloorService(IFloorRepository repository) : IFloorService
{
    public async Task<FloorDTO?> GetByIdAsync(Guid id)
    {
        var floor = await repository.GetByIdAsync(id);
        return floor?.ToDto();
    }

    public async Task<IEnumerable<FloorDTO>> GetAllAsync()
        => (await repository.GetAllAsync()).Select(f => f.ToDto());

    public async Task<FloorDTO> CreateAsync(CreateFloorRequest request)
    {
        var floor = new YoungConService.Domain.Entities.Floor
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
            MapURL = request.MapURL
        };

        var created = await repository.CreateAsync(floor);
        return created.ToDto();
    }

    public async Task<FloorDTO?> UpdateAsync(Guid id, UpdateFloorRequest request)
    {
        var existing = await repository.GetByIdAsync(id);
        if (existing == null)
        {
            return null;
        }

        if (request.Title != null) existing.Title = request.Title;
        if (request.MapURL != null) existing.MapURL = request.MapURL;

        var updated = await repository.UpdateAsync(existing);
        return updated?.ToDto();
    }

    public Task<bool> DeleteAsync(Guid id) => repository.DeleteAsync(id);
}

