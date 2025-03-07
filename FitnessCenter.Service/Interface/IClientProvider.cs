using FitnessCenter.Data;

namespace FitnessCenter.Service.Interface;

public interface IClientProvider:IBaseProvider<Client>
{
    Task<Client?> FindAsync(string phone, CancellationToken cancellationToken);
    Task<List<Client>> GetAllAsync(CancellationToken cancellationToken); 
    Task<Client?> FindAsync(Guid id, CancellationToken cancellationToken);
}