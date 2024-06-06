using Microsoft.EntityFrameworkCore;

namespace WordsOfPeace.Infrastructure.DBContext;

public class SQLiteDictionaryContextFactory : IDictionaryContextFactory
{
    public DictionaryContext FactoryMethod(string dictionaryName)
    {
        string connectionString = "Data Source="+dictionaryName;
        var optionsBuilder = new DbContextOptionsBuilder<DictionaryContext>();
        var options = optionsBuilder.UseSqlite(connectionString).Options;
        return new DictionaryContext(options);
    }
}