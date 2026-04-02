using YoungConService.DTOs.Achievments;

namespace YoungConService.Services.Achievments;

public interface IAchievmentService
{
    Task<AchievmentDTO?> GetByIdAsync(Guid id);
    Task<IEnumerable<AchievmentDTO>> GetAllAsync();
    Task<AchievmentDTO> CreateAsync(CreateAchievmentRequest request);
    Task<AchievmentDTO?> UpdateAsync(Guid id, UpdateAchievmentRequest request);
    Task<bool> DeleteAsync(Guid id);
}

