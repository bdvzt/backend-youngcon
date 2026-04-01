using YoungConService.Domain.Entities;

namespace YoungConService.Repositories.Events;

public interface IFestivalRepository
{
    Task<Festival?> GetByIdAsync(Guid id);
    Task<IEnumerable<Festival>> GetAllAsync();
    Task<Festival> CreateAsync(Festival festival);
    Task<Festival?> UpdateAsync(Festival festival);
    Task<bool> DeleteAsync(Guid id);
}

