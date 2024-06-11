namespace WordsOfPeace.Domain.AggregatesModel;

public interface IDictionaryCatalog
{
    IEnumerable<WordDictionary> GetWordDictionaries();
}