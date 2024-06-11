using Microsoft.Extensions.Configuration;
using WordsOfPeace.Domain.AggregatesModel;
using WordsOfPeace.Infrastructure.Repositories;

namespace WordsOfPeace.Infrastructure.DBContext;

public class SQLiteDictionaryCatalog(IConfiguration configuration) : IDictionaryCatalog
{
    private readonly IConfiguration _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    
    public IEnumerable<WordDictionary> GetWordDictionaries()
    {
        List<WordDictionary> result = [];
        foreach (var dictionary in GetFiles(_configuration["dictionaryesDirectory"]))
        {
            SQLiteDictionaryContextFactory factory = new SQLiteDictionaryContextFactory();
            DictionaryRepository dictionaryRepository = new DictionaryRepository(factory);
            WordDictionaryFactory wordDictionaryFactory = new WordDictionaryFactory(dictionaryRepository);
            yield return wordDictionaryFactory.FactoryMethodAsync(dictionary).GetAwaiter().GetResult();
        }
    }
    
    static IEnumerable<string> GetFiles(string path)
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(path);
        while (queue.Count > 0) {
            path = queue.Dequeue();
            try {
                foreach (string subDir in Directory.GetDirectories(path)) {
                    queue.Enqueue(subDir);
                }
            }
            catch(Exception ex) {
                Console.Error.WriteLine(ex);
            }
            string[] files = null;
            try {
                files = Directory.GetFiles(path,"*.db");
            }
            catch (Exception ex) {
                Console.Error.WriteLine(ex);
            }
            if (files != null) {
                for(int i = 0 ; i < files.Length ; i++) {
                    yield return files[i];
                }
            }
        }
    }
}

