namespace WordsOfPeace.Domain.Repository;
/// <summary>
/// Репозиторий сущностей
/// </summary>
/// <typeparam name="T">Сущность</typeparam>
public interface IRepository<T>
{
    /// <summary>
    /// Возвразщает сущность из базы по Id
    /// </summary>
    /// <param name="entityId">Id сущности</param>
    /// <returns>Сущность</returns>
    public Task<T> GetAsync(int entityId);
    /// <summary>
    /// Возвращает массив всех сущностей, которые есть в базе
    /// </summary>
    /// <returns></returns>
    public Task<T[]> GetAllAsync();
}