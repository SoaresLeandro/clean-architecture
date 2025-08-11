namespace CleanArchitecture.Domain.Shared.Entities
{
    public abstract class Entity(Guid? id) : IEquatable<Guid>
    {
        #region Properties
        public Guid Id { get; } = id ?? Guid.CreateVersion7();
        #endregion

        #region Equatable Implementation
        public bool Equals(Guid id) => Id.Equals(id);

        public override int GetHashCode() => Id.GetHashCode();
        #endregion
    }
}
