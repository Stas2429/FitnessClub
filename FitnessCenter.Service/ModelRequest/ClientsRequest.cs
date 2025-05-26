namespace FitnessCenter.Service.ModelRequest;

public class ClientsRequest: BaseModelRequest
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; } 
}