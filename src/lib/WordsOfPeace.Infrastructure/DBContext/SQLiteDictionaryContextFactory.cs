using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WordsOfPeace.Infrastructure.DBContext;

public class SQLiteDictionaryContextFactory(IConfiguration configuration) : IDictionaryContextFactory
{
    private readonly IConfiguration _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    public DictionaryContext FactoryMethod(string decodeDictionaryName)
    {
        string connectionString = "Data Source="+decodeDictionaryName;
        var optionsBuilder = new DbContextOptionsBuilder<DictionaryContext>();
        var options = optionsBuilder.UseSqlite(connectionString).Options;
        return new DictionaryContext(options);
    }
    /// <summary>
    /// <inheritdoc />
    /// </summary>
    public string DecodeDictionaryName(string dictionaryName)
    {
        return _configuration["dictionaryesDirectory"]+Path.DirectorySeparatorChar+dictionaryName.Replace("_",Path.DirectorySeparatorChar.ToString());
    }
    /// <summary>
    /// <inheritdoc />
    /// </summary>
    public string EncodeDictionaryName(string dictionaryName)
    {
        return dictionaryName.Replace(_configuration["dictionaryesDirectory"] + Path.DirectorySeparatorChar, "").Replace(Path.DirectorySeparatorChar.ToString(),"_");
    }
}