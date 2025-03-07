using FitnessCenter.Data;

namespace FitnessCenter.Service.Interface;

public interface IScheduleProvider : IBaseProvider<Schedule>
{
    Task<List<Schedule>> GetAllAsync(CancellationToken cancellationToken); 
    Task<Schedule?> FindAsync(Guid id, CancellationToken cancellationToken);
}