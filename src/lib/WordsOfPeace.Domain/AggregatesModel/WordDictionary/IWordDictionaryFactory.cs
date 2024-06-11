namespace WordsOfPeace.Domain.AggregatesModel;
/// <summary>
/// Интерфейс для фабрики создания словаря
/// </summary>
public interface IWordDictionaryFactory
{
    Task<WordDictionary> FactoryMethodAsync(string dictionaryName);    
}