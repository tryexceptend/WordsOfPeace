using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordsOfPeace.Domain.Entity;

namespace WordsOfPeace.Infrastructure.EntityConfigurations;
public class WordCategoryEntityTypeConfiguration : IEntityTypeConfiguration<WordCategory>
{
    public void Configure(EntityTypeBuilder<WordCategory> builder)
    {
        builder.ToTable("d_word_category");
    }
}
