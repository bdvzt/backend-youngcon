using YoungConService.Domain.Entities;

namespace YoungConService.Repositories.Events;

public interface IFloorRepository
{
    Task<Floor?> GetByIdAsync(Guid id);
    Task<IEnumerable<Floor>> GetAllAsync();
    Task<Floor> CreateAsync(Floor floor);
    Task<Floor?> UpdateAsync(Floor floor);
    Task<bool> DeleteAsync(Guid id);
}

