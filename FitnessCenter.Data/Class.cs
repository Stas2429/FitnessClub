namespace FitnessCenter.Data;

public class Class : BaseModel
{
    public string Name { get; set; }
    public TimeSpan Time { get; set; }
    public decimal Cost { get; set; }
    public int MaxNumber { get; set; }
}