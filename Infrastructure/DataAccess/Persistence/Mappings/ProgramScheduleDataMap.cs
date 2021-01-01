using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataAccess.Persistence.Mappings
{
    public class ProgramScheduleDataMap : IEntityTypeConfiguration<ProgramScheduleData>
    {
        public void Configure(EntityTypeBuilder<ProgramScheduleData> builder)
        {
            builder.ToTable(@"ProgramScheduleData", @"tvamain");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PsdServiceIdReference).HasColumnName("Psd_ServiceIdReference");
            builder.Property(x => x.PsdScheduleStart).HasColumnName("Psd_ScheduleStart");
            builder.Property(x => x.PsdScheduleEnd).HasColumnName("Psd_ScheduleEnd");
            builder.Property(x => x.PsdEventDuration).HasColumnName("Psd_ScheduleDuration");
            builder.Property(x => x.PsdProgramCrid).HasColumnName("Psd_ProgramCrid");
            builder.Property(x => x.PsdProgramImi).HasColumnName("Psd_ProgramImi");
            builder.Property(x => x.PsdPurchaseList).HasColumnName("Psd_PurchaseList");
            builder.Property(x => x.PsdCaptionLanguage).HasColumnName("Psd_CaptionLanguage");
            builder.Property(x => x.PsdAvAttributes).HasColumnName("Psd_AV_Attributes");
            builder.Property(x => x.PsdTmsId).HasColumnName("Psd_TmsId");
            builder.Property(x => x.PsdScheduledStartTime).HasColumnName("Psd_ScheduledStartTime");
            builder.Property(x => x.PsdScheduledEndTime).HasColumnName("Psd_ScheduledEndTime");
            builder.Property(x => x.PsdEventDuration).HasColumnName("Psd_EventDuration");
            builder.Property(x => x.PsdRowChange).HasColumnName("Psd_RowChange");
        }
    }
}