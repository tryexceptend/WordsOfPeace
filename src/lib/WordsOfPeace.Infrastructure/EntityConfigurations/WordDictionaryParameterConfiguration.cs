using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WordsOfPeace.Infrastructure.Models;

namespace WordsOfPeace.Infrastructure.EntityConfigurations;

public class WordDictionaryParameterConfiguration: IEntityTypeConfiguration<WordDictionaryParameter>
{
    public void Configure(EntityTypeBuilder<WordDictionaryParameter> builder)
    {
        builder.ToTable("s_parameters");
    }
}