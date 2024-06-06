using Microsoft.EntityFrameworkCore;
using WordsOfPeace.Domain.Entity;
using WordsOfPeace.Infrastructure.DBContext;

namespace WordsOfPeace.Infrastructure.Repositories;
public class WordRepository : IWordRepository
{
    private readonly DictionaryContext _context;

    public WordRepository(DictionaryContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }
    public Task<Word[]> GetAllAsync()
    {
        return _context.Words.Include(c => c.Categoryes).ToArrayAsync();
    }

    public Task<Word> GetAsync(int entityId)
    {
        return _context.Words.Where(w => w.Id == entityId).Include(w => w.Categoryes).FirstOrDefaultAsync();
    }
}
