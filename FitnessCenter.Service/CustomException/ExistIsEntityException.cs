namespace FitnessCenter.Service.CustomException;

public class ExistIsEntityException: Exception
{
    public ExistIsEntityException(string? message) : base(message)
    {
    }
}