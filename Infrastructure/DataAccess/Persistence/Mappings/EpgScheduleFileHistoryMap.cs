using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.DataAccess.Persistence.Mappings
{
    public class EpgScheduleFileHistoryMap : IEntityTypeConfiguration<EpgScheduleFileHistory>
    {
        public void Configure(EntityTypeBuilder<EpgScheduleFileHistory> builder)
        {
            builder.ToTable(@"EpgScheduleFileHistory", @"tvamain");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.EpgFilenameGz).HasColumnName("EpgFilenameGZ");
            builder.Property(x => x.EpgFilenameExtracted).HasColumnName("EpgFilenameExtracted");
            builder.Property(x => x.EpgOriginalFileSize).HasColumnName("EpgOriginalFileSize");
            builder.Property(x => x.EpgExtractedFileSize).HasColumnName("EpgExtractedFileSize");
            builder.Property(x => x.EpgDateTimeRetrieved).HasColumnName("EpgDateTimeRetrieved");
            builder.Property(x => x.EpgDateTimeParsed).HasColumnName("EpgDateTimeParsed");
            builder.Property(x => x.EpgDateTimeArchived).HasColumnName("EpgDateTimeArchived");
            builder.Property(x => x.EpgArchiveLocation).HasColumnName("EpgArchiveLocation");
        }
    }
}