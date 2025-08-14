using CleanArchitecture.Domain.Accounts.ValueObjects;
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
            string password) : base(Guid.CreateVersion7())
        {
            Name = Name.Create(firstName, lastName);
            Email = email;
            Password = password;
        }
        #endregion

        #region Properties
        public Name Name { get; set; }
        public string Email { get; } = string.Empty;
        public string Password { get; } = string.Empty;
        #endregion
    }
}
