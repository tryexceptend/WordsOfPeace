using WordsOfPeace.Domain.Entity;

namespace WordsOfPeace.Infrastructure.Repositories;
public class WordRepository : IWordRepository
{
    public Task<Word[]> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Word> GetAsync(int entityId)
    {
        throw new NotImplementedException();
    }
}
