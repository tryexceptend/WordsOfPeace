namespace WordsOfPeace.Domain.Entity.WordDictionary;
/// <summary>
/// Словарь иностранных слов, который содержит слова и фразы, разбитые по категориям.
/// </summary>
public class WordDictionary
{
    /// <summary>
    /// Конструктор по словарю
    /// </summary>
    /// <param name="words"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public WordDictionary(Dictionary<string, IWord> words)
    {
        Words = words ?? throw new ArgumentNullException(nameof(words));
    }
    /// <summary>
    /// Словарь слов
    /// </summary>
    public Dictionary<string, IWord> Words { get; init; }
}