namespace WordsOfPeace.Domain.Entity;
/// <summary>
/// Категория слов
/// </summary>
public interface IWordCategory
{
    /// <summary>
    /// Уникальный ID
    /// </summary>
    public int id { get; }
    /// <summary>
    /// Название на языке ученика
    /// </summary>
    public int Name { get; }
}