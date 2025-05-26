using AutoMapper;
using FitnessCenter.Service.CustomException;
using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using FitnessCenter.Service.ModelRequest;

namespace FitnessCenter.Service;

public class SubscriptionService : BaseService<Subscription, SubscriptionRequest, ISubscriptionProvider>, ISubscriptionService
{
    private readonly ISubscriptionProvider _provider;
    private readonly IMapper _mapper;

    public SubscriptionService(ISubscriptionProvider provider, IMapper mapper) : base(provider, mapper)
    {
        _provider = provider;
        _mapper = mapper;
    }
}