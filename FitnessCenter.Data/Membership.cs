namespace FitnessCenter.Data;

public class Membership: BaseModel
{
    public Subscription Subscription { get; set; }
    public string Type { get; set; }  
    public string Description { get; set; }  
    public int Price { get; set; }
    public List<ClassRegistration> ClassRegistration { get; set; }
}