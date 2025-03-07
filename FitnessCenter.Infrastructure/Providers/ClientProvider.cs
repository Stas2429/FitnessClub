using System.Runtime.CompilerServices;
using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace ClassLibrary.Providers;

public class ClientProvider : IBaseProvider<Client>
{
    private readonly ApplicationContext _applicationContext;

    public ClientProvider(ApplicationContext applicationContext)
    {
        _applicationContext = applicationContext;
    }

    public async Task<Guid> AddAsync(Client entity, CancellationToken cancellationToken)
    {
        _applicationContext.Add(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
        return entity.Id;
    }

    public async Task DeleteAsync(Client entity, CancellationToken cancellationToken)
    {
        _applicationContext.Remove(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<Client> UpdateAsync(Client entity, CancellationToken cancellationToken)
    {
        _applicationContext.Update(entity);
        await _applicationContext.SaveChangesAsync(cancellationToken);
        return entity;
    }

    public async Task<Client> FindAsync(Guid id, CancellationToken cancellationToken)
    {

        return  await _applicationContext.Clients.FirstOrDefaultAsync(p => p.Id == id);
    }
    
    public async Task<List<Client>> GetAllAsync(CancellationToken cancellationToken)
    {
        return await _applicationContext.Clients.ToListAsync(cancellationToken: cancellationToken);
    }
}