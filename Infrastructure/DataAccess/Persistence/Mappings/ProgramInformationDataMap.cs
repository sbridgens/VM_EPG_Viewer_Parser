using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataAccess.Persistence.Mappings
{
    public class ProgramInformationDataMap : IEntityTypeConfiguration<ProgramInformationData>
    {
        public void Configure(EntityTypeBuilder<ProgramInformationData> builder)
        {
            builder.ToTable(@"ProgramInformationData", @"tvamain");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PidCrid).HasColumnName("Pid_Crid");
            builder.Property(x => x.PidTmsId).HasColumnName("Pid_TmsId");
            builder.Property(x => x.PidRootId).HasColumnName("Pid_RootId");
            builder.Property(x => x.PidImdbId).HasColumnName("Pid_ImdbId");
            builder.Property(x => x.PidSeriesLink).HasColumnName("Pid_SeriesLink");
            builder.Property(x => x.PidEpisodeNumber).HasColumnName("Pid_EpisodeNumber");
            builder.Property(x => x.PidTitleMain).HasColumnName("Pid_TitleMain");
            builder.Property(x => x.PidEpisodeTitle).HasColumnName("Pid_EpisodeTitle");
            builder.Property(x => x.PidSynopsisShort).HasColumnName("Pid_SynopsisShort");
            builder.Property(x => x.PidSynopsisMedium).HasColumnName("Pid_SynopsisMedium");
            builder.Property(x => x.PidSynopsisLong).HasColumnName("Pid_SynopsisLong");
            builder.Property(x => x.PidProgramGenres).HasColumnName("Pid_ProgramGenres");
            builder.Property(x => x.PidParentalGuidance).HasColumnName("Pid_ParentalGuidance");
            builder.Property(x => x.PidCreditsList).HasColumnName("Pid_CreditsList");
            builder.Property(x => x.PidProgramImages).HasColumnName("Pid_ProgramImages");
            builder.Property(x => x.PidProductionYear).HasColumnName("Pid_ProductionYear");
            builder.Property(x => x.PidProductionLocation).HasColumnName("Pid_ProductionLocation");
            builder.Property(x => x.PidRowChanges).HasColumnName("Pid_RowChanges");
        }
    }
}