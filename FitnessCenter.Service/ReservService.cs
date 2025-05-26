using AutoMapper;
using FitnessCenter.Service.CustomException;
using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using FitnessCenter.Service.ModelRequest;

namespace FitnessCenter.Service;

public class ReservService : BaseService<Reserv, ReservRequest, IReservProvider>, IReservService
{
    private readonly IReservProvider _provider;
    private readonly IMapper _mapper;

    public ReservService(IReservProvider provider, IMapper mapper) : base(provider, mapper)
    {
        _provider = provider;
        _mapper = mapper;
    }
}