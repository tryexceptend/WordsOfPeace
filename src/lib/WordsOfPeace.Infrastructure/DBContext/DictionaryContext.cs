using Microsoft.EntityFrameworkCore;
using WordsOfPeace.Domain.Entity;
using WordsOfPeace.Infrastructure.EntityConfigurations;
using WordsOfPeace.Infrastructure.Models;

namespace WordsOfPeace.Infrastructure.DBContext;

public class DictionaryContext : DbContext
{
    public DbSet<Word> Words { get; set; }
    public DbSet<WordCategory> WordCategoryes { get; set; }
    public DbSet<WordDictionaryParameter> Parameters { get; set; } 

    public DictionaryContext(DbContextOptions<DictionaryContext> options, bool delete = false)
        : base(options)
    {
        if (delete) { Database.EnsureDeleted(); }
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new WordEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new WordCategoryEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new WordDictionaryParameterConfiguration());
    }
}