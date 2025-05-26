using AutoMapper;
using FitnessCenter.Service.CustomException;
using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using FitnessCenter.Service.ModelRequest;

namespace FitnessCenter.Service;

public class ScheduleService : BaseService<Schedule, SchedulesRequest, IScheduleProvider>, IScheduleService
{
    private readonly IScheduleProvider _provider;
    private readonly IMapper _mapper;

    public ScheduleService(IScheduleProvider provider, IMapper mapper) : base(provider, mapper)
    {
        _provider = provider;
        _mapper = mapper;
    }
}