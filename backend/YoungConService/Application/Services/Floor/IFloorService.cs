using YoungConService.DTOs.Floors;

namespace YoungConService.Services.Events.Floor;

public interface IFloorService
{
    Task<FloorDTO?> GetByIdAsync(Guid id);
    Task<IEnumerable<FloorDTO>> GetAllAsync();
    Task<FloorDTO> CreateAsync(CreateFloorRequest request);
    Task<FloorDTO?> UpdateAsync(Guid id, UpdateFloorRequest request);
    Task<bool> DeleteAsync(Guid id);
}

