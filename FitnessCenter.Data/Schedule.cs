namespace FitnessCenter.Data;

public class Schedule : BaseModel
{
    public Class Class { get; set; }
    public Day Day{ get; set; }
    public DateTime Begin { get; set; }
    public DateTime End { get; set; }
}