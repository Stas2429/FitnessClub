namespace FitnessCenter.Service.CustomException;

public class NotExistException:Exception
{
    public NotExistException(string? message) : base(message)
    {
    }
}