namespace WordsOfPeace.Domain.Entity;
/// <inheritdoc />
public class Word : IWord
{
    public int Id { get; set; }
    /// <inheritdoc />
    public string Value { get; set; }
    /// <inheritdoc />
    public string[] Translations { get => translation.Split(','); set => translation = string.Join(",", value); }
    string translation;
    /// <inheritdoc />
    public string? Transcription { get; set; }
    /// <inheritdoc />
    public List<WordCategory> Categoryes { get; set; } = [];
    public Word(string value, string translation, string? transcription, List<WordCategory> categoryes)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (translation == null || translation.Length == 0)
        {
            ArgumentNullException.ThrowIfNull(translation);
        }
        Value = value;
        this.translation = translation;
        Transcription = transcription;
        Categoryes.AddRange(categoryes);
    }
    public Word(string value, string translation, string transcription)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (translation == null || translation.Length == 0)
        {
            ArgumentNullException.ThrowIfNull(translation);
        }
        Value = value;
        this.translation = translation;
        Transcription = transcription;
    }
    public override string ToString()
    {
        return Value + " - " + translation + " (" + string.Join(",", Categoryes.Select(c => c.Name)) + ")";
    }
}