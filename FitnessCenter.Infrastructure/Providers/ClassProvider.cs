using System.Runtime.CompilerServices;
using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using Microsoft.EntityFrameworkCore;
using FitnessCenter.Infrastructure;

namespace ClassLibrary.Providers;

public class ClassProvider : IBaseProvider<Class>
{
    private readonly ApplicationContext _applicationContext;

    public ClassProvider(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<Guid> AddAsync(Class entity, CancellationToken cancellationToken)
    {
        _applicationContext.Add(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        return entity.Id;
    }

    public async Task DeleteAsync(Class entity, CancellationToken cancellationToken)
    {
        _applicationContext.Remove(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<Class> UpdateAsync(Class entity, CancellationToken cancellationToken)
    {
        _applicationContext.Update(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<Class> FindAsync(Guid id, CancellationToken cancellationToken)
    {
        return  await _applicationContext.Classes.FirstOrDefaultAsync(p => p.Id == id);
    }
    
    public async Task<List<Class>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _applicationContext.Classes.ToListAsync(cancellationToken: cancellationToken);
    }
}
