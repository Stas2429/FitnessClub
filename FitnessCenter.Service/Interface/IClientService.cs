using FitnessCenter.Data;
using FitnessCenter.Service.ModelRequest;

namespace FitnessCenter.Service.Interface;

public interface IClientService: IBaseService<Client, ClientsRequest>
{
    Task<Client> GetByClientName(string name, CancellationToken cancellationToken);
}