using System.Runtime.CompilerServices;
using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Providers;

public class MembershipProvider : IBaseProvider<Membership>
{
    private readonly ApplicationContext _applicationContext;

    public MembershipProvider(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<Guid> AddAsync(Membership entity, CancellationToken cancellationToken)
    {
        _applicationContext.Add(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        return entity.Id;
    }

    public async Task DeleteAsync(Membership entity, CancellationToken cancellationToken)
    {
        _applicationContext.Remove(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<Membership> UpdateAsync(Membership entity, CancellationToken cancellationToken)
    {
        _applicationContext.Update(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<Membership> FindAsync(Guid id, CancellationToken cancellationToken)
    {

        return  await _applicationContext.Memberships.FirstOrDefaultAsync(p => p.Id == id);
    }
    
    public async Task<List<Membership>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _applicationContext.Memberships.ToListAsync(cancellationToken: cancellationToken);
    }
}