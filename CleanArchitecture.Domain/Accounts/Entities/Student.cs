using CleanArchitecture.Domain.Accounts.ValueObjects;
using CleanArchitecture.Domain.Shared.Abstractions;
using CleanArchitecture.Domain.Shared.Entities;

namespace CleanArchitecture.Domain.Accounts.Entities
{
    public class Student : Entity
    {
        #region Constructors
        public Student(
            string firstName, 
            string lastName, 
            string email,
            IDateTimeProvider dateTimeProvider) : base(Guid.CreateVersion7())
        {
            Name = Name.Create(firstName, lastName);
            Email = Email.Create(email);
            Tracker = Tracker.Create(dateTimeProvider);
        }
        #endregion

        #region Properties
        public Name Name { get; }
        public Email Email { get; }
        public Tracker Tracker { get; }
        #endregion
    }
}
