// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using WordsOfPeace.Infrastructure;

Console.WriteLine("Hello, World!");

string connectionString = "Data Source=helloapp.db";
var optionsBuilder = new DbContextOptionsBuilder<DictionaryContext>();
var options = optionsBuilder.UseSqlite(connectionString).Options;

using (DictionaryContext db = new DictionaryContext(options))
{
    /*WordCategory verbs = new("Глаголы");
    WordCategory prepositions = new("Предлоги");
    WordCategory animals = new("Животные");
    WordCategory pets = new("Домашние питомцы");

    db.WordCategoryes.AddRange([verbs, prepositions, animals, pets]);

    Word p_in = new("in", "в", null, [prepositions]);
    Word p_and = new("and", "и", null, [prepositions]);

    Word v_go = new("go", "идти,пойти,ходить,поехать,выйти,выходить,зайти,заходить,сходить", null); v_go.Categoryes = [verbs];
    Word v_swim = new("swim", "плавать,купаться,плыть", null); v_swim.Categoryes = [verbs];

    Word a_tiger = new("tiger", "тигр", null); a_tiger.Categoryes = [animals];
    Word a_dog = new("dog", "собака", null); a_dog.Categoryes = [animals, pets];
    Word a_cat = new("cat", "кошка", null); a_cat.Categoryes = [animals, pets];

    db.Words.AddRange([p_in, p_and, v_go, v_swim, a_tiger, a_dog, a_cat]);

    db.SaveChanges();*/
    var words = db.Words.Include(c => c.Categoryes).ToList();
    foreach (var word in words)
    {
        Console.WriteLine(word.ToString());
    }
}