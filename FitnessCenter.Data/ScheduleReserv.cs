namespace FitnessCenter.Data;

public class ScheduleReserv
{
    public int ScheduleId { get; set; }
    public Schedule Schedule { get; set; }
    public int ReservId { get; set; }
    public Reserv Reserv { get; set; }
}