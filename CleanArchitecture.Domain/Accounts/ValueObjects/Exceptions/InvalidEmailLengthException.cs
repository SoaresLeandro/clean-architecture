namespace CleanArchitecture.Domain.Accounts.ValueObjects.Exceptions
{
    public sealed class InvalidEmailLengthException(string message) : Exception(message);
}
