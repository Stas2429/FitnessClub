namespace FitnessCenter.Data;

public class ClientReserv
{
    public int ClientId { get; set; }
    public Client Client { get; set; }
    public int ReservId { get; set; }
    public Reserv Reserv { get; set; }
}