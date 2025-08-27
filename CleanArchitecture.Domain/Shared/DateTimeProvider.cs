using CleanArchitecture.Domain.Shared.Abstractions;

namespace CleanArchitecture.Domain.Shared
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}
