using CleanArchitecture.Domain.Shared.Abstractions;

namespace CleanArchitecture.Domain.Test.Mocks
{
    public class FakeDateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => new DateTime(2025, 8, 27, 16, 55, 30);
    }
}
