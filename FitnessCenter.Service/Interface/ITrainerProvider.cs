using FitnessCenter.Data;

namespace FitnessCenter.Service.Interface;

public interface ITrainerProvider : IBaseProvider<Trainer>
{
    Task<List<Trainer>> GetAllAsync(CancellationToken cancellationToken); 
    Task<Trainer?> FindAsync(Guid id, CancellationToken cancellationToken);
}