using FitnessCenter.Data;

namespace FitnessCenter.Service.Interface;
public interface ISubscriptionProvider : IBaseProvider<Subscription>
{
    Task<List<Subscription>> GetAllAsync(CancellationToken cancellationToken);
    Task<Subscription?> FindAsync(Guid id, CancellationToken cancellationToken);
}