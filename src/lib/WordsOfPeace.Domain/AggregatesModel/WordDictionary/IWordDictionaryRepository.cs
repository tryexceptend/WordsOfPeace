using WordsOfPeace.Domain.Entity;

namespace WordsOfPeace.Domain.AggregatesModel;

public interface IWordDictionaryRepository
{
    Task<Version> GetDictionaryVersionAsync(string dictionaryName);
    Task<Dictionary<string, IWord>> GetWordsAsync(string dictionaryName);
    Task<WordDictionaryInfo> GetWordDictionaryInfoAsync(string dictionaryName);
}