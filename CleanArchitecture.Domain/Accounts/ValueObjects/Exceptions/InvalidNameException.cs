using CleanArchitecture.Domain.Shared.Exceptions;

namespace CleanArchitecture.Domain.Accounts.ValueObjects.Exceptions
{
    public sealed class InvalidNameException(string message) : DomainException(message);
}
