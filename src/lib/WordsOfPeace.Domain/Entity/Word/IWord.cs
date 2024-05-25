namespace WordsOfPeace.Domain.Entity.Word;
/// <summary>
/// Изучаемое слово. Слово и его возможные переводы, транскрипция.
/// </summary>
public interface IWord
{
    /// <summary>
    /// Иностранное слово
    /// </summary>
    public string Value { get; init; }
    /// <summary>
    /// Возможные переводы
    /// </summary>
    public string[] Translation { get; init; }
    /// <summary>
    /// Транскрипция
    /// </summary>
    public string Transcription  { get; init; }
    /// <summary>
    /// ID категории, к которым относится слово
    /// </summary>
    public int[] Categoryes  { get; init; }
}