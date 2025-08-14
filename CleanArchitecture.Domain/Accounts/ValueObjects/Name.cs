using CleanArchitecture.Domain.Shared.ValueObjects;

namespace CleanArchitecture.Domain.Accounts.ValueObjects
{
    public sealed record Name : ValueObject
    {
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
                throw new ArgumentException("Nome inválido");

            return new Name(firstName, lastName);
        }
        #endregion
    }
}
