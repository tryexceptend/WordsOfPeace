using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordsOfPeace.Domain.Entity;

namespace WordsOfPeace.Infrastructure.EntityConfigurations;

public class WordEntityTypeConfiguration : IEntityTypeConfiguration<Word>
{
    public void Configure(EntityTypeBuilder<Word> builder)
    {
        builder.ToTable("e_word");
        builder.Ignore(u => u.Translations);
        builder.Property("translation");
    }
}