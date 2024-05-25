namespace WordsOfPeace.Domain.Entity.Word;
/// <inheritdoc />
public class Word : IWord
{
    /// <inheritdoc />
    public string Value { get; init; }
    /// <inheritdoc />
    public string[] Translation { get; init; }
    /// <inheritdoc />
    public string Transcription  { get; init; }
    /// <inheritdoc />
    public int[] Categoryes  { get; init; }
}