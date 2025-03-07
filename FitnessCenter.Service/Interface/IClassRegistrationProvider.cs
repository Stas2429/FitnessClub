using FitnessCenter.Data;

namespace FitnessCenter.Service.Interface;

public interface IClassRegistrationProvider:IBaseProvider<ClassRegistration>
{
    Task<List<ClassRegistration>> GetAllAsync(CancellationToken cancellationToken); 
    Task<ClassRegistration?> FindAsync(Guid id, CancellationToken cancellationToken);
}