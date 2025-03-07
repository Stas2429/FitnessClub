namespace FitnessCenter.Service.ModelRequest;

public class TrainersRequest : BaseModelRequest
{
    public string Name { get; set; }  
    public string Phone { get; set; }
    public string Specialization { get; set; }
}