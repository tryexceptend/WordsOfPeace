namespace WordsOfPeace.Infrastructure.DBContext;

public interface IDictionaryContextFactory
{
     DictionaryContext FactoryMethod(string dictionaryName);
}