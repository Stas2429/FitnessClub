using FitnessCenter.Data;

namespace FitnessCenter.Service.Interface;

public interface IMembershipProvider:IBaseProvider<Membership>
{
    Task<Membership?> FindAsync(string name, CancellationToken cancellationToken);
    Task<List<Membership>> GetAllAsync(CancellationToken cancellationToken); 
    Task<Membership?> FindAsync(Guid id, CancellationToken cancellationToken);
}