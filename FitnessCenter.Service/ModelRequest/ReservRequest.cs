namespace FitnessCenter.Service.ModelRequest;

public class ReservRequest : BaseModelRequest
{
    public Guid ClassId { get; set; }
    public Guid TrainerId { get; set; }
    public string Type { get; set; }
    public int Number { get; set; }
}