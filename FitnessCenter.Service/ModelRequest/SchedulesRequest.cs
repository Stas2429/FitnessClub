using FitnessCenter.Data;

namespace FitnessCenter.Service.ModelRequest;

public class SchedulesRequest : BaseModelRequest
{
    public DateTime Date { get; set; }
    public DateTime DateBegin { get; set; }
    public DateTime DateEnd { get; set; }
}