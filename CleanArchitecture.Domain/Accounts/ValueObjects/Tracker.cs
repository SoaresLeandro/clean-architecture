using CleanArchitecture.Domain.Shared.Abstractions;
using CleanArchitecture.Domain.Shared.ValueObjects;

namespace CleanArchitecture.Domain.Accounts.ValueObjects
{
    public sealed record Tracker : ValueObject
    {
        #region Constructors
        public Tracker(DateTime createdAtUtc, DateTime updatedAtUtc)
        {
            CreatedAtUtc = createdAtUtc;
            UpdatedAtUtc = updatedAtUtc;
        }
        #endregion

        #region Properties
        public DateTime CreatedAtUtc { get; }
        public DateTime UpdatedAtUtc { get; private set; }
        #endregion

        #region Factories
        public static Tracker Create(IDateTimeProvider dateTimeProvider) => 
            new Tracker(dateTimeProvider.UtcNow, dateTimeProvider.UtcNow);

        public static Tracker Create(DateTime createdAtUtc, DateTime updatedAtUtc) =>
            new Tracker(createdAtUtc, updatedAtUtc);
        #endregion

        #region Public Methods
        public void Update(IDateTimeProvider dateTimeProvider)
        {
            UpdatedAtUtc = dateTimeProvider.UtcNow;
        }
        #endregion
    }
}
