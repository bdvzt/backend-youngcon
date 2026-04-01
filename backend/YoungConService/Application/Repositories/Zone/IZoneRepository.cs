using YoungConService.Domain.Entities;

namespace YoungConService.Repositories.Events;

public interface IZoneRepository
{
    Task<Zone?> GetByIdAsync(Guid id);
    Task<IEnumerable<Zone>> GetAllAsync();
    Task<IEnumerable<Zone>> GetByFloorIdAsync(Guid floorId);
    Task<Zone> CreateAsync(Zone zone);
    Task<Zone?> UpdateAsync(Zone zone);
    Task<bool> DeleteAsync(Guid id);
}

