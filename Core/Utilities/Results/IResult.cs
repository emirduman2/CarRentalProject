namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; } // get sadece okunabilir demek.
        string Message { get; }
    }
}