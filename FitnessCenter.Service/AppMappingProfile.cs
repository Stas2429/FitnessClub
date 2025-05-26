using FitnessCenter.Data;
using FitnessCenter.Service.ModelRequest;
using Profile = AutoMapper.Profile;

namespace FitnessCenter.Service;

public class AppMappingProfile:Profile
{
    public AppMappingProfile()
    {			
        CreateMap<Class, ClassesRequest>();
        CreateMap<Class, ClassesRequest>().ReverseMap();
        CreateMap<Client, ClientsRequest>();
        CreateMap<Client, ClientsRequest>().ReverseMap();
        CreateMap<Schedule, SchedulesRequest>();
        CreateMap<Schedule, SchedulesRequest>().ReverseMap();
        CreateMap<Trainer, TrainersRequest>();
        CreateMap<Trainer, TrainersRequest>().ReverseMap();
    }
}