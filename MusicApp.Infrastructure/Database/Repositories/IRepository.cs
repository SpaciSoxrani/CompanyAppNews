using MusicApp.Core.Domain.Models;

namespace MusicApp.Infrastructure.Database.Repositories;

public interface IRepository<T> where T : BaseEntity
{
    IEnumerable<T?> GetAll();
    T? GetById(Guid id);
    void Insert(T? entity);
    void Update(T entity);
    void Delete(Guid id);
}