using System.Runtime.CompilerServices;
using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using Microsoft.EntityFrameworkCore;
using FitnessCenter.Infrastructure;

namespace ClassLibrary.Providers;

public class TrainerProvider : IBaseProvider<Trainer>
{
    private readonly ApplicationContext _applicationContext;

    public TrainerProvider(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<Guid> AddAsync(Trainer entity, CancellationToken cancellationToken)
    {
        _applicationContext.Add(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        return entity.Id;
    }

    public async Task DeleteAsync(Trainer entity, CancellationToken cancellationToken)
    {
        _applicationContext.Remove(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<Trainer> UpdateAsync(Trainer entity, CancellationToken cancellationToken)
    {
        _applicationContext.Update(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<Trainer> FindAsync(Guid id, CancellationToken cancellationToken)
    {

        return  await _applicationContext.Trainers.FirstOrDefaultAsync(p => p.Id == id);
    }
    
    public async Task<List<Trainer>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _applicationContext.Trainers.ToListAsync(cancellationToken: cancellationToken);
    }
}