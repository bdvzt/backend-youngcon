using YoungConService.DTOs.Festivals;

namespace YoungConService.Services.Events.Festival;

public interface IFestivalService
{
    Task<FestivalDTO?> GetByIdAsync(Guid id);
    Task<IEnumerable<FestivalDTO>> GetAllAsync();
    Task<FestivalDTO> CreateAsync(CreateFestivalRequest request);
    Task<FestivalDTO?> UpdateAsync(Guid id, UpdateFestivalRequest request);
    Task<bool> DeleteAsync(Guid id);
    Task<FestivalDTO?> GetLastAsync();
}

