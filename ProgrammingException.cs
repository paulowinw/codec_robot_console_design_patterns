public class ProgrammingException : Exception
{
    public ProgrammingException()
    {
    }

    public ProgrammingException(string message)
        : base(message)
    {
    }

    public ProgrammingException(string message, Exception inner)
        : base(message, inner)
    {
    }
}