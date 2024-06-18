namespace WordsOfPeace.Domain.AggregatesModel;

public interface IDictionaryCatalog
{
    IEnumerable<WordDictionaryInfo> GetWordDictionaries();
}