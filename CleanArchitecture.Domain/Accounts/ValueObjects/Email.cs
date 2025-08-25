using CleanArchitecture.Domain.Accounts.ValueObjects.Exceptions;
using CleanArchitecture.Domain.Shared.ValueObjects;
using System.Text.RegularExpressions;

namespace CleanArchitecture.Domain.Accounts.ValueObjects
{
    public sealed partial record Email : ValueObject
    {
        #region Constants
        public const int MinLength = 8;
        public const int MaxLength = 160;
        private const string Pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9-]+(?:\.[A-Za-z0-9-]+)*\.[A-Za-z]{2,}$";
        #endregion

        #region Constructors
        public Email(string address)
        {
            Address = address;
        }
        #endregion

        #region Properties
        public string Address { get; }
        #endregion

        #region Factories
        public static Email Create(string address)
        {
            if(string.IsNullOrWhiteSpace(address))
                throw new InvalidEmailLengthException("Email cannot be null or empty");

            address = address.Trim().ToLower();

            if(!EmailRegex().IsMatch(address))
                throw new InvalidEmailException("Invalid email address");

            return new Email(address);
        }
        #endregion

        #region Source Generators
        [GeneratedRegex(Pattern)]
        private static partial Regex EmailRegex();
        #endregion

        #region Overrides
        public override string ToString() => Address;
        #endregion
    }
}
