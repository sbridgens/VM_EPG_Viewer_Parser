using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataAccess.Persistence.Mappings
{
    class GroupInformationDataMap : IEntityTypeConfiguration<GroupInformationData>
    {
        public void Configure(EntityTypeBuilder<GroupInformationData> builder)
        {
            builder.ToTable(@"GroupInformationData", @"tvamain");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.GidGroupId).HasColumnName("Gid_GroupId");
            builder.Property(x => x.GidConnectorId).HasColumnName("Gid_ConnectorId");
            builder.Property(x => x.GidType).HasColumnName("Gid_Type");
            builder.Property(x => x.GidSeriesTitle).HasColumnName("Gid_SeriesTitle");
            builder.Property(x => x.GidSeriesId).HasColumnName("Gid_SeriesId");
            builder.Property(x => x.GidSeriesNumber).HasColumnName("Gid_SeriesNumber");
            builder.Property(x => x.GidSeriesCrid).HasColumnName("Gid_SeriesCrid");
            builder.Property(x => x.GidSynopsis).HasColumnName("Gid_Synopsis");
            builder.Property(x => x.GidGenres).HasColumnName("Gid_Genres");
            builder.Property(x => x.GidLanguage).HasColumnName("Gid_Language");
            builder.Property(x => x.GidCreditsList).HasColumnName("Gid_CreditsList");
            builder.Property(x => x.GidSeriesImages).HasColumnName("Gid_SeriesImages");
            builder.Property(x => x.GidProductionYear).HasColumnName("Gid_ProductionYear");
            builder.Property(x => x.GidRowChanges).HasColumnName("Gid_RowChanges");
        }
    }
}