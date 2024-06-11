// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Configuration;
using WordsOfPeace.Domain.AggregatesModel;
using WordsOfPeace.Infrastructure.DBContext;
using WordsOfPeace.Infrastructure.Repositories;


string dictionaryName = "db";

IConfigurationRoot configuration = new ConfigurationBuilder().AddJsonFile("applicationConfig.json").Build();
SQLiteDictionaryCatalog catalog = new SQLiteDictionaryCatalog(configuration);
foreach (var dictionary in catalog.GetWordDictionaries() )
{
    Console.WriteLine(dictionary.Name);
}

