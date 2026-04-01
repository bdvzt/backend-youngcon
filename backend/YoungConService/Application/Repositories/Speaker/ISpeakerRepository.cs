using YoungConService.Domain.Entities;

namespace YoungConService.Repositories.Events;

public interface ISpeakerRepository
{
    Task<Speaker?> GetByIdAsync(Guid id);
    Task<IEnumerable<Speaker>> GetAllAsync();
    Task<Speaker> CreateAsync(Speaker speaker);
    Task<Speaker?> UpdateAsync(Speaker speaker);
    Task<bool> DeleteAsync(Guid id);
}

