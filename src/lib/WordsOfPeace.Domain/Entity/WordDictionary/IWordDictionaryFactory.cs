namespace WordsOfPeace.Domain.Entity.WordDictionary;
/// <summary>
/// Интерфейс для фабрики создания словаря
/// </summary>
public interface IWordDictionaryFactory
{
    public WordDictionary FactoryMethod();    
}