using YoungConService.DTOs.Zones;

namespace YoungConService.Services.Events.Zone;

public interface IZoneService
{
    Task<ZoneDTO?> GetByIdAsync(Guid id);
    Task<IEnumerable<ZoneDTO>> GetAllAsync();
    Task<IEnumerable<ZoneDTO>> GetByFloorIdAsync(Guid floorId);
    Task<ZoneDTO> CreateAsync(CreateZoneRequest request);
    Task<ZoneDTO?> UpdateAsync(Guid id, UpdateZoneRequest request);
    Task<bool> DeleteAsync(Guid id);
}

