using AutoMapper;
using FitnessCenter.Data;
using FitnessCenter.Service.CustomException;
using FitnessCenter.Service.Interface;
using FitnessCenter.Service.ModelRequest;

namespace FitnessCenter.Service;

public class MembershipService : BaseService<Membership,MembershipsRequest,IMembershipProvider> ,IMembershipService

{
    private readonly IMembershipProvider _membershipProvider;
    
    private IMapper _mapper;
    public MembershipService(IMembershipProvider provider, IMapper mapper) : base(provider, mapper)
    {
        _membershipProvider = provider;
        _mapper = mapper;
    }
    
}
