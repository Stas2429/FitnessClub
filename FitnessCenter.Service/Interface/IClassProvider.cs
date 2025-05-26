using FitnessCenter.Data;

namespace FitnessCenter.Service.Interface;

public interface IClassProvider : IBaseProvider<Class>
{
    Task<List<Class>> GetAllAsync(CancellationToken cancellationToken);
    Task<Class?> FindAsync(Guid id, CancellationToken cancellationToken);
}