namespace FitnessCenter.Data;

public class Reserv : BaseModel
{
    public int ClassId { get; set; }
    public Class Class { get; set; }
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }
    public string Type { get; set; }
    public int Number { get; set; }
}