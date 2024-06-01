namespace WordsOfPeace.Domain.Entity;
/// <summary>
/// Изучаемое слово. Слово и его возможные переводы, транскрипция.
/// </summary>
public interface IWord
{
    /// <summary>
    /// Иностранное слово
    /// </summary>
    public string Value { get; }
    /// <summary>
    /// Возможные переводы
    /// </summary>
    public string[] Translations { get; }
    /// <summary>
    /// Транскрипция
    /// </summary>
    public string? Transcription { get; }
    /// <summary>
    /// ID категории, к которым относится слово
    /// </summary>
    public List<WordCategory> Categoryes { get; }
}