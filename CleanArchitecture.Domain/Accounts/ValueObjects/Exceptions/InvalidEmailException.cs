namespace CleanArchitecture.Domain.Accounts.ValueObjects.Exceptions
{
    public sealed class InvalidEmailException(string message) : Exception(message);
}
