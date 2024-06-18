namespace WordsOfPeace.Infrastructure.DBContext;

public interface IDictionaryContextFactory
{
     DictionaryContext FactoryMethod(string decodeDictionaryName);
     /// <summary>
     /// Расшифровывает имя словаря в нужные данные для репозитория
     /// </summary>
     /// <param name="dictionaryName">Шифрованное имя</param>
     /// <returns></returns>
     string DecodeDictionaryName(string dictionaryName);
     /// <summary>
     /// Шифрует данные для доступа к словарю в уникальное имя
     /// </summary>
     /// <param name="dictionaryName"></param>
     /// <returns></returns>
     string EncodeDictionaryName(string dictionaryName);
}