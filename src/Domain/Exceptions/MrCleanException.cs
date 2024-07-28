namespace MrClean.Domain.Exceptions;

public class MrCleanException : ApplicationException
{
    public MrCleanException(string message) : base(message) { }
}
