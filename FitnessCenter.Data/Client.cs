namespace FitnessCenter.Data;

public class Client : BaseModel
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
}