namespace FitnessCenter.Data;

public class Schedule : BaseModel
{
    public DateTime Date { get; set; }
    public DateTime DateBegin { get; set; }
    public DateTime DateEnd { get; set; }
}