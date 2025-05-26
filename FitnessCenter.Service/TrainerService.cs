using AutoMapper;
using FitnessCenter.Service.CustomException;
using FitnessCenter.Data;
using FitnessCenter.Service.Interface;
using FitnessCenter.Service.ModelRequest;

namespace FitnessCenter.Service;

public class TrainerService : BaseService<Trainer, TrainersRequest, ITrainerProvider>, ITrainerService
{
    private readonly ITrainerProvider _provider;
    private readonly IMapper _mapper;

    public TrainerService(ITrainerProvider provider, IMapper mapper) : base(provider, mapper)
    {
        _provider = provider;
        _mapper = mapper;
    }
}