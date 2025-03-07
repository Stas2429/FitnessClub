using FitnessCenter.Data;
using FitnessCenter.Service.ModelRequest;

namespace FitnessCenter.Service.Interface;

public interface IBaseService<TEntityDb, TEntityRequest> where TEntityRequest: BaseModelRequest
{
    Task<Guid> CreateAsync(TEntityRequest entityRequest, CancellationToken cancellationToken);
    Task<TEntityDb?> GetAsync(Guid id, CancellationToken cancellationToken);
    Task<TEntityDb> UpdateAsync(TEntityRequest entityRequest, CancellationToken cancellationToken);
    Task<List<TEntityDb>> GetAllAsync(CancellationToken cancellationToken);
}