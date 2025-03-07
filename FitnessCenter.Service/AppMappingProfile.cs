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
        CreateMap<ClassRegistration, ClassRegistrationRequest>();
        CreateMap<ClassRegistration, ClassRegistrationRequest>().ReverseMap();
        CreateMap<Client, ClientsRequest>();
        CreateMap<Client, ClientsRequest>().ReverseMap();
        CreateMap<Membership, MembershipsRequest>();
        CreateMap<Membership, MembershipsRequest>().ReverseMap();
        CreateMap<Schedule, ScheduleRequest>();
        CreateMap<Schedule, ScheduleRequest>().ReverseMap();
        CreateMap<Trainer, TrainersRequest>();
        CreateMap<Trainer, TrainersRequest>().ReverseMap();
    }
}