namespace FitnessCenter.Data;

public class SubscriptionReserv
{
    public int SubscriptionId { get; set; }
    public Subscription Subscription { get; set; }
    public int ReservId { get; set; }
    public Reserv Reserv { get; set; }
}