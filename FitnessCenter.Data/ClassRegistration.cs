using System.Runtime.InteropServices.JavaScript;

namespace FitnessCenter.Data;

public class ClassRegistration : BaseModel
{
    public Client Client { get; set; }
    public Schedule Schedule { get; set; } 
    public Membership Membership { get; set; }
    public DateTime Start { get; set; } 
    public DateTime End { get; set; }
}