using FitnessCenter.Data;
using FitnessCenter.Service.ModelRequest;

namespace FitnessCenter.Service.Interface;

public interface IClassRegistrationService: IBaseService<ClassRegistration, ClassRegistrationRequest>
{
    Task<List<ClassRegistration>> GetByRegistration(Guid clientId, CancellationToken cancellationToken);
}