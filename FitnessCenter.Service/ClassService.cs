using AutoMapper;
using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using FitnessCenter.Service.ModelRequest;

namespace FitnessCenter.Service;

public class ClassService : BaseService<Class, ClassesRequest, IClassProvider>, IClassService
{
    private readonly IClassProvider _provider;
    private readonly IMapper _mapper;

    public ClassService(IClassProvider provider, IMapper mapper) : base(provider, mapper)
    {
        _provider = provider;
        _mapper = mapper;
    }

    public async Task DeleteAsync(Class entity, CancellationToken cancellationToken)
    {
        await _provider.DeleteAsync(entity, cancellationToken);
    }
}