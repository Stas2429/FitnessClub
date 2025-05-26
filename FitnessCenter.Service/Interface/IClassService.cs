using FitnessCenter.Data;
using FitnessCenter.Service.ModelRequest;

namespace FitnessCenter.Service.Interface;

public interface IClassService : IBaseService<Class, ClassesRequest>
{
    Task DeleteAsync(Class entity, CancellationToken cancellationToken);
}
