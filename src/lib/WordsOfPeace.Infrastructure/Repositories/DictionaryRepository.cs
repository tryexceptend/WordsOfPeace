using Microsoft.EntityFrameworkCore;
using WordsOfPeace.Domain.AggregatesModel;
using WordsOfPeace.Domain.Entity;
using WordsOfPeace.Infrastructure.Models;
using WordsOfPeace.Infrastructure.DBContext;

namespace WordsOfPeace.Infrastructure.Repositories;

public class DictionaryRepository(IDictionaryContextFactory dictionaryContextFactory) : IWordDictionaryRepository
{
    private readonly IDictionaryContextFactory _dictionaryContextFactory = dictionaryContextFactory ?? throw new ArgumentNullException(nameof(dictionaryContextFactory));

    public Task<Version> GetDictionaryVersionAsync(string dictionaryName)
    {
        using (DictionaryContext context = _dictionaryContextFactory.FactoryMethod(dictionaryName))
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
        using (DictionaryContext context = _dictionaryContextFactory.FactoryMethod(dictionaryName))
        {
            return Task.FromResult(context.Words.Include(w => w.Categoryes).Cast<IWord>().ToDictionary(w => w.Value));
        };
    }
}