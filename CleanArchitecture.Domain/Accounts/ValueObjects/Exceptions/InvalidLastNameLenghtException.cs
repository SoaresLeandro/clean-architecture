using CleanArchitecture.Domain.Shared.Exceptions;

namespace CleanArchitecture.Domain.Accounts.ValueObjects.Exceptions
{
    public sealed class InvalidLastNameLenghtException(string message) : DomainException(message);
}
