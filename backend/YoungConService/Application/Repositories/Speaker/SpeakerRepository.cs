using Microsoft.EntityFrameworkCore;
using YoungConService.Domain.Entities;
using YoungConService.Infrastructure.Repositories;

namespace YoungConService.Repositories.Events;

public class SpeakerRepository(YoungConDbContext db) : ISpeakerRepository
{
    public async Task<Speaker?> GetByIdAsync(Guid id)
        => await db.Speakers.Include(s => s.Events).FirstOrDefaultAsync(s => s.Id == id);

    public async Task<IReadOnlyCollection<Speaker>> GetByIdsAsync(IEnumerable<Guid> ids)
    {
        var speakerIds = ids.Distinct().ToArray();
        if (speakerIds.Length == 0)
        {
            return [];
        }

        return await db.Speakers
            .Where(s => speakerIds.Contains(s.Id))
            .ToListAsync();
    }

    public async Task<IEnumerable<Speaker>> GetAllAsync()
        => await db.Speakers.Include(s => s.Events).OrderBy(s => s.FullName).ToListAsync();

    public async Task<Speaker> CreateAsync(Speaker speaker)
    {
        db.Speakers.Add(speaker);
        await db.SaveChangesAsync();
        return speaker;
    }

    public async Task<Speaker?> UpdateAsync(Speaker speaker)
    {
        var existing = await db.Speakers.FindAsync(speaker.Id);
        if (existing == null) return null;
        db.Entry(existing).CurrentValues.SetValues(speaker);
        await db.SaveChangesAsync();
        return existing;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var speaker = await db.Speakers.FindAsync(id);
        if (speaker == null) return false;
        db.Speakers.Remove(speaker);
        await db.SaveChangesAsync();
        return true;
    }
}

