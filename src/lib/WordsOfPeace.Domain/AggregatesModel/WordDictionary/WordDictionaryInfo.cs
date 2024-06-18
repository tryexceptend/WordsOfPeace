namespace WordsOfPeace.Domain.AggregatesModel;

public class WordDictionaryInfo
{
    /// <summary>
    /// Уникальное имя, по которому будем получать словать от репозитория
    /// </summary>
    public string Name { get; init; }
    /// <summary>
    /// Версия словаря
    /// </summary>
    public Version Version { get; set; }
    /// <summary>
    /// Названия для отображения пользователю
    /// </summary>
    public string Label { get; set; }
    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; }

    public WordDictionaryInfo(string name)
    {
        Name = name;
    }
}