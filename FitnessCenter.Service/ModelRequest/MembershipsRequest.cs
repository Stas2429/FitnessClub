namespace FitnessCenter.Service.ModelRequest;

public class MembershipsRequest: BaseModelRequest
{
    public string Name { get; set; }  
    public string Description { get; set; }  
    public decimal Price { get; set; }
}