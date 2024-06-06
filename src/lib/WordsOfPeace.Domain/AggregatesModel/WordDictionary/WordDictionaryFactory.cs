namespace WordsOfPeace.Domain.AggregatesModel;

public class WordDictionaryFactory : IWordDictionaryFactory
{
    private readonly IWordDictionaryRepository _repository;

    public WordDictionaryFactory(IWordDictionaryRepository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }
    public async Task<WordDictionary> FactoryMethod(string dictionaryName)
    {
        var version = await _repository.GetDictionaryVersionAsync(dictionaryName);
        return version.Major switch
        {
            1 => new WordDictionary(await _repository.GetWordsAsync(dictionaryName)),
            _ => null
        };
    }
}