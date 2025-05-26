using System.Runtime.CompilerServices;
using FitnessCenter.Data;

namespace FitnessCenter.Service.Interface;

public interface IBaseProvider<TEntity> where TEntity : BaseModel
{
    Task<Guid> AddAsync(TEntity entity, CancellationToken cancellationToken);

    Task DeleteAsync(TEntity entity, CancellationToken cancellationToken);

    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken);

    Task<TEntity> FindAsync(Guid id, CancellationToken cancellationToken);

    Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);
}