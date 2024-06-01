namespace WordsOfPeace.Domain.Entity;

/// <summary>
/// <inheritdoc />
/// </summary>
public class WordCategory(string name) : IWordCategory
{
    /// <inheritdoc />
    public int Id { get; set; }
    /// <inheritdoc />
    public string Name { get; set; } = name;
    public List<Word> Words { get; set; } = [];
}