using YoungConService.DTOs.Zones;
using YoungConService.Infrastructure.Mappers;
using YoungConService.Repositories.Events;

namespace YoungConService.Services.Events.Zone;

public class ZoneService(IZoneRepository repository) : IZoneService
{
    public async Task<ZoneDTO?> GetByIdAsync(Guid id)
    {
        var zone = await repository.GetByIdAsync(id);
        return zone?.ToDto();
    }

    public async Task<IEnumerable<ZoneDTO>> GetAllAsync()
        => (await repository.GetAllAsync()).Select(z => z.ToDto());

    public async Task<IEnumerable<ZoneDTO>> GetByFloorIdAsync(Guid floorId)
        => (await repository.GetByFloorIdAsync(floorId)).Select(z => z.ToDto());

    public async Task<ZoneDTO> CreateAsync(CreateZoneRequest request)
    {
        var zone = new YoungConService.Domain.Entities.Zone
        {
            Id = Guid.NewGuid(),
            FloorId = request.FloorId,
            Title = request.Title,
            Description = request.Description,
            Icon = request.Icon,
            Color = request.Color
        };

        var created = await repository.CreateAsync(zone);
        return created.ToDto();
    }

    public async Task<ZoneDTO?> UpdateAsync(Guid id, UpdateZoneRequest request)
    {
        var existing = await repository.GetByIdAsync(id);
        if (existing == null) return null;

        if (request.FloorId.HasValue) existing.FloorId = request.FloorId.Value;
        if (request.Title != null) existing.Title = request.Title;
        if (request.Description != null) existing.Description = request.Description;
        if (request.Icon != null) existing.Icon = request.Icon;
        if (request.Color != null) existing.Color = request.Color;

        var updated = await repository.UpdateAsync(existing);
        return updated?.ToDto();
    }

    public Task<bool> DeleteAsync(Guid id) => repository.DeleteAsync(id);
}
