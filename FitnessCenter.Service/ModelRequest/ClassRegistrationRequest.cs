using FitnessCenter.Data;

namespace FitnessCenter.Service.ModelRequest;

public class ClassRegistrationRequest: BaseModelRequest
{
    public Guid ClientId { get; set; }
    public DateTime Time { get; set; } 
    public Guid GenreId { get; set; }
    public DateOnly Date { get; set; } 
    public int Count { get; set; }
}