using CleanArchitecture.Domain.Shared.Events.Abstractions;

namespace CleanArchitecture.Domain.Shared.Entities
{
    public abstract class Entity(Guid? id) : IEquatable<Guid>
    {
        #region Private Members
        private readonly List<IDomainEvent> _events = [];
        #endregion

        #region Properties
        public Guid Id { get; } = id ?? Guid.CreateVersion7();
        #endregion

        #region Equatable Implementation
        public bool Equals(Guid id) => Id.Equals(id);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion

        #region Domain Events
        public IReadOnlyCollection<IDomainEvent> Events => _events;
        public void ClearEvents() => _events.Clear();
        public void RaiseEvent(IDomainEvent @event) => _events.Add(@event);
        #endregion
    }
}
