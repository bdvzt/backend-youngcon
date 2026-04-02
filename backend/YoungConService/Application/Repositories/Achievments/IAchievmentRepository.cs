using YoungConService.Domain.Entities;

namespace YoungConService.Repositories.Achievments;

public interface IAchievmentRepository
{
    Task<Achievment?> GetByIdAsync(Guid id);
    Task<IEnumerable<Achievment>> GetAllAsync();
    Task<Achievment> CreateAsync(Achievment achievment);
    Task<Achievment?> UpdateAsync(Achievment achievment);
    Task<bool> DeleteAsync(Guid id);
}

