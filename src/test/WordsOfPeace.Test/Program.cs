// See https://aka.ms/new-console-template for more information
using WordsOfPeace.Domain.AggregatesModel;
using WordsOfPeace.Infrastructure.DBContext;
using WordsOfPeace.Infrastructure.Repositories;

Console.WriteLine("Hello, World!");

string dictionaryName = "C:\\Projects\\Trash\\WordsOfPeace\\db\\EngToRus.db";

SQLiteDictionaryContextFactory dictionaryContextFactory = new SQLiteDictionaryContextFactory();
DictionaryRepository dictionaryRepository = new DictionaryRepository(dictionaryContextFactory);
WordDictionaryFactory wordDictionaryFactory = new WordDictionaryFactory(dictionaryRepository);
var dictionary = await wordDictionaryFactory.FactoryMethod(dictionaryName);
foreach (var word in dictionary.Words)
{
    Console.WriteLine((word));
}

