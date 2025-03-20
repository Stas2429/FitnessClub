namespace FitnessCenter.Data;

public class TrainerReserv
{
    public int TrainerId { get; set; }
    public Trainer Trainer { get; set; }
    public int ReservId { get; set; }
    public Reserv Reserv { get; set; }
}