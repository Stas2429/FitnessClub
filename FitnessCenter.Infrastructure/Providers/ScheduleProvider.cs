using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using Microsoft.EntityFrameworkCore;
using FitnessCenter.Infrastructure;

namespace ClassLibrary.Providers;

public class ScheduleProvider : IBaseProvider<Schedule>
{
    private readonly ApplicationContext _applicationContext;

    public ScheduleProvider(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<Guid> AddAsync(Schedule entity, CancellationToken cancellationToken)
    {
        _applicationContext.Schedules.Add(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        return entity.Id;
    }

    public async Task DeleteAsync(Schedule entity, CancellationToken cancellationToken)
    {
        _applicationContext.Schedules.Remove(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
    }

    public async Task<Schedule> UpdateAsync(Schedule entity, CancellationToken cancellationToken)
    {
        _applicationContext.Schedules.Update(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        return entity;
    }

    public async Task<Schedule> FindAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _applicationContext.Schedules.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
    }

    public async Task<List<Schedule>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _applicationContext.Schedules.ToListAsync(cancellationToken);
    }
}