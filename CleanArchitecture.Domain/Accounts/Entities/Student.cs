using CleanArchitecture.Domain.Shared.Entities;

namespace CleanArchitecture.Domain.Accounts.Entities
{
    public class Student : Entity
    {
        #region Constructors
        public Student() : base(Guid.CreateVersion7())
        {
        }
        #endregion

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
