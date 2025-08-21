using CleanArchitecture.Domain.Shared.Exceptions;

namespace CleanArchitecture.Domain.Accounts.ValueObjects.Exceptions
{
    public sealed class InvalidFirstNameLenghtException(string message) : DomainException(message);
}
