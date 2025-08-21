using CleanArchitecture.Domain.Accounts.ValueObjects.Exceptions;
using CleanArchitecture.Domain.Shared.ValueObjects;

namespace CleanArchitecture.Domain.Accounts.ValueObjects
{
    public sealed record Name : ValueObject
    {
        #region Constants
        public const int MinLength = 3;
        public const int MaxLength = 60;
        #endregion

        #region Constructors
        private Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        #region Properties
        public string FirstName { get; } = string.Empty;
        public string LastName { get; } = string.Empty;
        #endregion

        #region Operators
        public static implicit operator string(Name name) => name.ToString();
        #endregion

        #region Overrides
        public override string ToString() => $"{FirstName} {LastName}";
        #endregion

        #region Factories
        public static Name Create(string firstName, string lastName)
        {
            if(string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
                throw new InvalidNameException("Name cannot be empty");

            if (firstName.Length < MinLength)
                throw new InvalidFirstNameLenghtException("First Name cannot be less than 3 characters");

            if (firstName.Length > MaxLength)
                throw new InvalidFirstNameLenghtException("First Name cannot be longer than 60 characters");

            if (lastName.Length < MinLength)
                throw new InvalidLastNameLenghtException("Last Name cannot be less than 3 characters");

            if (lastName.Length > MaxLength)
                throw new InvalidLastNameLenghtException("Last Name cannot be longer than 60 characters");

            return new Name(firstName, lastName);
        }
        #endregion
    }
}
