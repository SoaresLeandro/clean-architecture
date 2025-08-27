namespace CleanArchitecture.Domain.Shared.Abstractions
{
    public interface IDateTimeProvider
    {
        #region Properties
        DateTime UtcNow { get; }
        #endregion
    }
}
