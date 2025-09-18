using CleanArchitecture.Domain.Shared.Aggregates.Abstractions;

namespace CleanArchitecture.Domain.Shared.Repositories.Abstractions
{
    public interface IRepository<TEntity> where TEntity : IAggregateRoot;
}
