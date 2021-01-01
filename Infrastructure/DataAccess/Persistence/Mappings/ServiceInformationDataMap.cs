using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.DataAccess.Persistence.Mappings
{
    public class ServiceInformationDataMap : IEntityTypeConfiguration<ServiceInformationData>
    {
        public void Configure(EntityTypeBuilder<ServiceInformationData> builder)
        {
            builder.ToTable(@"ServiceInformationData", @"tvamain");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.SidServiceName).HasColumnName("Sid_ServiceName");
            builder.Property(x => x.SidVmServiceId).HasColumnName("Sid_VM_ServiceId");
            builder.Property(x => x.SidEpgServiceId).HasColumnName("Sid_Epg_ServiceId");
            builder.Property(x => x.SidServiceLogo).HasColumnName("Sid_ServiceLogo");
            builder.Property(x => x.SidChannelResolution).HasColumnName("Sid_ChannelResolution");
            builder.Property(x => x.SidVmServiceGroup).HasColumnName("Sid_VM_ServiceGroup");
            builder.Property(x => x.SidRowChanges).HasColumnName("Sid_RowChanges");
        }
    }
}