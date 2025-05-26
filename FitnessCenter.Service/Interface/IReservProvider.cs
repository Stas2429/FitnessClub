using FitnessCenter.Data;

namespace FitnessCenter.Service.Interface;

public interface IReservProvider : IBaseProvider<Reserv>
{
    Task<List<Reserv>> GetAllAsync(CancellationToken cancellationToken);
    Task<Reserv?> FindAsync(Guid id, CancellationToken cancellationToken);
}