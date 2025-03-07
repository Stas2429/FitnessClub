using AutoMapper;
using FitnessCenter.Service.CustomException;
using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using FitnessCenter.Service.ModelRequest;

namespace FitnessCenter.Service;

public class ClientService : BaseService<Client, ClientsRequest, IClientProvider>, IClientService

{
    private readonly IClientProvider _clientProvider;
    private IMapper _mapper;
    public ClientService(IClientProvider provider, IMapper mapper) : base(provider, mapper)
    {
        _clientProvider = provider;
        _mapper = mapper;
    }

    public async Task<Client> GetByClientName(string name, CancellationToken cancellationToken)
    {
        var clients = await _clientProvider.GetAllAsync(new CancellationToken());
        var client = clients.FirstOrDefault(c => c.Name == name);
        return client;
    }
}