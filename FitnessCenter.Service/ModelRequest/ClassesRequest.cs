namespace FitnessCenter.Service.ModelRequest;

public class ClassesRequest : BaseModelRequest
{
    public string Name { get; set; }
    public TimeSpan Time { get; set; }
    public decimal Cost { get; set; }
    public int MaxNumber { get; set; }
}