public class WrongCommandException : Exception
{
    public WrongCommandException()
    {
    }

    public WrongCommandException(string message)
        : base(message)
    {
    }

    public WrongCommandException(string message, Exception inner)
        : base(message, inner)
    {
    }
}