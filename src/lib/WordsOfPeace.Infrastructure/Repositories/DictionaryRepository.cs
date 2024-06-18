using Microsoft.EntityFrameworkCore;
using WordsOfPeace.Domain.AggregatesModel;
using WordsOfPeace.Domain.Entity;
using WordsOfPeace.Infrastructure.Models;
using WordsOfPeace.Infrastructure.DBContext;

namespace WordsOfPeace.Infrastructure.Repositories;

public class DictionaryRepository(IDictionaryContextFactory dictionaryContextFactory) : IWordDictionaryRepository
{
    private readonly IDictionaryContextFactory _dictionaryContextFactory = dictionaryContextFactory ?? throw new ArgumentNullException(nameof(dictionaryContextFactory));
    private IWordDictionaryRepository _wordDictionaryRepositoryImplementation;

    public Task<Version> GetDictionaryVersionAsync(string dictionaryName)
    {
        using (DictionaryContext context = _dictionaryContextFactory.FactoryMethod(_dictionaryContextFactory.DecodeDictionaryName(dictionaryName)))
        {
            Dictionary<string, WordDictionaryParameter> dictionaryParams =context.Parameters.ToDictionary(p => p.Key);
            if (dictionaryParams.TryGetValue("Version", out WordDictionaryParameter? value))
            {
                return Task.FromResult(new Version(value.Value));    
            }
            else
            {
                return Task.FromResult(new Version());
            }    
        }
    }

    public Task<Dictionary<string, IWord>> GetWordsAsync(string dictionaryName)
    {
        using (DictionaryContext context = _dictionaryContextFactory.FactoryMethod(_dictionaryContextFactory.DecodeDictionaryName(dictionaryName)))
        {
            return Task.FromResult(context.Words.Include(w => w.Categoryes).Cast<IWord>().ToDictionary(w => w.Value));
        };
    }

    public Task<WordDictionaryInfo> GetWordDictionaryInfoAsync(string dictionaryName)
    {
        using (DictionaryContext context = _dictionaryContextFactory.FactoryMethod(_dictionaryContextFactory.DecodeDictionaryName(dictionaryName)))
        {
            Dictionary<string, WordDictionaryParameter> dictionaryParams =context.Parameters.ToDictionary(p => p.Key);
            WordDictionaryInfo dictionaryInfo = new WordDictionaryInfo(dictionaryName);
            dictionaryInfo.Version = dictionaryParams.TryGetValue(RepositoryConstants.VERSION_PARAMETER_KEY, out WordDictionaryParameter? version) ? new Version(version.Value) : new Version();
            dictionaryInfo.Label = dictionaryParams.TryGetValue(RepositoryConstants.LABEL_PARAMETER_KEY, out WordDictionaryParameter? label) ? label.Value : "";
            dictionaryInfo.Description = dictionaryParams.TryGetValue(RepositoryConstants.DESCRIPTION_PARAMETER_KEY, out WordDictionaryParameter? descr) ? descr.Value : "";
            return Task.FromResult(dictionaryInfo);
        }
    }
}