using YoungConService.Domain.Entities;
using YoungConService.DTOs.Achievments;
using YoungConService.Repositories.Achievments;

namespace YoungConService.Services.Achievments;

public class AchievmentService(IAchievmentRepository repository) : IAchievmentService
{
    public async Task<AchievmentDTO?> GetByIdAsync(Guid id)
    {
        var achievment = await repository.GetByIdAsync(id);
        return achievment == null ? null : ToDto(achievment);
    }

    public async Task<IEnumerable<AchievmentDTO>> GetAllAsync()
        => (await repository.GetAllAsync()).Select(ToDto);

    public async Task<AchievmentDTO> CreateAsync(CreateAchievmentRequest request)
    {
        var achievment = new Achievment
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Description = request.Description,
            Icon = request.Icon,
            Color = request.Color
        };

        var created = await repository.CreateAsync(achievment);
        return ToDto(created);
    }

    public async Task<AchievmentDTO?> UpdateAsync(Guid id, UpdateAchievmentRequest request)
    {
        var existing = await repository.GetByIdAsync(id);
        if (existing == null) return null;

        if (request.Name != null) existing.Name = request.Name;
        if (request.Description != null) existing.Description = request.Description;
        if (request.Icon != null) existing.Icon = request.Icon;
        if (request.Color != null) existing.Color = request.Color;

        var updated = await repository.UpdateAsync(existing);
        return updated == null ? null : ToDto(updated);
    }

    public Task<bool> DeleteAsync(Guid id) => repository.DeleteAsync(id);

    private static AchievmentDTO ToDto(Achievment achievment)
    {
        return new AchievmentDTO
        {
            Id = achievment.Id,
            Name = achievment.Name,
            Description = achievment.Description,
            Icon = achievment.Icon,
            Color = achievment.Color
        };
    }
}

