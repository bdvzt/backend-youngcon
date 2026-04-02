using YoungConService.DTOs.Speakers;

namespace YoungConService.Services.Events.Speaker;

public interface ISpeakerService
{
    Task<SpeakerDTO?> GetByIdAsync(Guid id);
    Task<IEnumerable<SpeakerDTO>> GetAllAsync();
    Task<SpeakerDTO> CreateAsync(CreateSpeakerRequest request);
    Task<SpeakerDTO?> UpdateAsync(Guid id, UpdateSpeakerRequest request);
    Task<bool> DeleteAsync(Guid id);
}

