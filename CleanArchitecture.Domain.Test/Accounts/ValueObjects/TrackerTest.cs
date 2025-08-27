using CleanArchitecture.Domain.Accounts.ValueObjects;
using CleanArchitecture.Domain.Shared.Abstractions;
using CleanArchitecture.Domain.Test.Mocks;

namespace CleanArchitecture.Domain.Test.Accounts.ValueObjects
{
    public class TrackerTest
    {
        private readonly IDateTimeProvider _dateTimeProvider = new FakeDateTimeProvider();

        [Fact]
        public void ShouldCreateTrackerWithCurrentUtcDateTime()
        {
            var tracker = Tracker.Create(_dateTimeProvider);

            Assert.Equal(_dateTimeProvider.UtcNow, tracker.CreatedAtUtc);
        }
    }
}
