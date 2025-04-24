using FitnessCenter.Data;

namespace FitnessCenter.Service.ModelRequest;

public class ScheduleRequest : BaseModelRequest
{
    public Class Class { get; set; }
    public DateTime Begin { get; set; }
    public DateTime End { get; set; }
}