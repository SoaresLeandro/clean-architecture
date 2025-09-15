using CleanArchitecture.Domain.Shared.Events.Abstractions;

namespace CleanArchitecture.Domain.Accounts.Events
{
    public sealed record OnStudentCreatedEvent(Guid Id, string Name, string Email) : IDomainEvent;
}
