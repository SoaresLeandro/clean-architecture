using CleanArchitecture.Domain.Accounts.Entities;
using CleanArchitecture.Domain.Shared.Repositories.Abstractions;

namespace CleanArchitecture.Domain.Accounts.Repositories.Abastractions
{
    public interface IAccountRepository : IRepository<Student>
    {
        Task CreateAsync(Student student, CancellationToken cancellationToken = default);
    }
}
