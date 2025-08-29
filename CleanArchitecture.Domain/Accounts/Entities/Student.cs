using CleanArchitecture.Domain.Accounts.ValueObjects;
using CleanArchitecture.Domain.Shared.Abstractions;
using CleanArchitecture.Domain.Shared.Entities;

namespace CleanArchitecture.Domain.Accounts.Entities
{
    public class Student : Entity
    {
        #region Constructors
        private Student(
            string firstName, 
            string lastName, 
            string email,
            IDateTimeProvider dateTimeProvider) : base(Guid.CreateVersion7())
        {
            Name = Name.Create(firstName, lastName);
            Email = Email.Create(email);
            Tracker = Tracker.Create(dateTimeProvider);
        }

        private Student(
            Name name,
            Email email,
            IDateTimeProvider dateTimeProvider) : base(Guid.CreateVersion7())
        {
            Name = name;
            Email = email;
            Tracker = Tracker.Create(dateTimeProvider);
        }
        #endregion

        #region Properties
        public Name Name { get; }
        public Email Email { get; }
        public Tracker Tracker { get; }
        #endregion

        #region Factories
        public static Student Create(
            string firstName,
            string lastName, 
            string email, 
            IDateTimeProvider dateTimeProvider) => new Student(firstName, lastName, email, dateTimeProvider);

        public static Student Create(
            Name name, 
            Email email, 
            IDateTimeProvider dateTimeProvider) => new Student(name, email, dateTimeProvider);
        #endregion

        #region Overrides
        public override string ToString() => Name;
        #endregion
    }
}
