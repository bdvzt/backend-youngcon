using YoungConService.DTOs.Speakers;
using YoungConService.Infrastructure.Mappers;
using YoungConService.Repositories.Events;

namespace YoungConService.Services.Events.Speaker;

public class SpeakerService(ISpeakerRepository repository) : ISpeakerService
{
    public async Task<SpeakerDTO?> GetByIdAsync(Guid id)
    {
        var speaker = await repository.GetByIdAsync(id);
        return speaker?.ToDto();
    }

    public async Task<IEnumerable<SpeakerDTO>> GetAllAsync()
        => (await repository.GetAllAsync()).Select(s => s.ToDto());

    public async Task<SpeakerDTO> CreateAsync(CreateSpeakerRequest request)
    {
        var speaker = new YoungConService.Domain.Entities.Speaker
        {
            Id = Guid.NewGuid(),
            FullName = request.FullName,
            Job = request.Job,
            Bio = request.Bio,
            AvatarURL = request.AvatarURL
        };

        var created = await repository.CreateAsync(speaker);
        return created.ToDto();
    }

    public async Task<SpeakerDTO?> UpdateAsync(Guid id, UpdateSpeakerRequest request)
    {
        var existing = await repository.GetByIdAsync(id);
        if (existing == null) return null;

        if (request.FullName != null) existing.FullName = request.FullName;
        if (request.Job != null) existing.Job = request.Job;
        if (request.Bio != null) existing.Bio = request.Bio;
        if (request.AvatarURL != null) existing.AvatarURL = request.AvatarURL;

        var updated = await repository.UpdateAsync(existing);
        return updated?.ToDto();
    }

    public Task<bool> DeleteAsync(Guid id) => repository.DeleteAsync(id);
}
