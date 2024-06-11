using WordsOfPeace.Domain.Entity;
namespace WordsOfPeace.Domain.AggregatesModel;
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
    public WordDictionary(Dictionary<string, IWord> words, string name)
    {
        Words = words ?? throw new ArgumentNullException(nameof(words));
        Name = name;
    }
    /// <summary>
    /// Словарь слов
    /// </summary>
    public Dictionary<string, IWord> Words { get; init; }

    public string Name { get; }
}